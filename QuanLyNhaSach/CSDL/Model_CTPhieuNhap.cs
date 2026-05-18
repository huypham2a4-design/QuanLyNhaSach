using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.CSDL
{
    public class Model_CTPhieuNhap
    {
        private readonly CSDL.Connect_DB conn = new Connect_DB();
        public DataTable LayChiTiet(string mapn)
        {
            string sql = @"
                SELECT ct.mapn, ct.mash, s.tensh, ct.soluong, ct.dongia, ct.thanhtien
                FROM ChiTietPhieuNhap ct
                JOIN SACH s ON ct.mash = s.mash
                WHERE ct.mapn = @mapn";
            DataTable dt = new DataTable();
            try
            {
                conn.open_connect();
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@mapn", mapn);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { throw ex; }
            finally { conn.close_connect(); }
            return dt;
        }

        // 2. Thêm chi tiết + cộng tồn kho
        public bool Them(string mapn, string mash, int soluong, float dongia)
        {
            float thanhtien = soluong * dongia;
            string sql = @"
                BEGIN TRANSACTION;
                
                INSERT INTO ChiTietPhieuNhap(mapn, mash, soluong, dongia, thanhtien)
                VALUES(@mapn, @mash, @soluong, @dongia, @thanhtien);
                
                UPDATE SACH SET SLTONKHO = SLTONKHO + @soluong WHERE MASH = @mash;
                
                COMMIT;";

            return ExecuteNonQuery(sql, mapn, mash, soluong, dongia, thanhtien);
        }

        // 3. Sửa chi tiết + cập nhật tồn kho (trừ cũ, cộng mới)
        public bool Sua(string mapn, string mash, int soluongMoi, float dongiaMoi)
        {
            float thanhtien = soluongMoi * dongiaMoi;

            // Lấy số lượng cũ trước
            int soluongCu = LaySoLuongCu(mapn, mash);

            string sql = @"
                BEGIN TRANSACTION;
                
                UPDATE ChiTietPhieuNhap 
                SET soluong = @soluongMoi, dongia = @dongiaMoi, thanhtien = @thanhtien
                WHERE mapn = @mapn AND mash = @mash;
                
                UPDATE SACH 
                SET SLTONKHO = SLTONKHO - @soluongCu + @soluongMoi 
                WHERE MASH = @mash;
                
                COMMIT;";

            try
            {
                conn.open_connect();
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@mapn", mapn);
                cmd.Parameters.AddWithValue("@mash", mash);
                cmd.Parameters.AddWithValue("@soluongMoi", soluongMoi);
                cmd.Parameters.AddWithValue("@dongiaMoi", dongiaMoi);
                cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
                cmd.Parameters.AddWithValue("@soluongCu", soluongCu);
                cmd.ExecuteNonQuery();
                conn.close_connect();
                return true;
            }
            catch
            {
                conn.close_connect();
                return false;
            }
        }

        // 4. Xóa chi tiết + trừ tồn kho
        public bool Xoa(string mapn, string mash)
        {
            int soluong = LaySoLuongCu(mapn, mash);
            string sql = @"
                BEGIN TRANSACTION;
                DELETE FROM ChiTietPhieuNhap WHERE mapn = @mapn AND mash = @mash;
               
                COMMIT;";

            return ExecuteNonQuery(sql, mapn, mash, soluong, 0, 0);
        }

        // Hàm hỗ trợ
        private int LaySoLuongCu(string mapn, string mash)
        {
            string sql = "SELECT ISNULL(soluong,0) FROM ChiTietPhieuNhap WHERE mapn=@mapn AND mash=@mash";
            try
            {
                conn.open_connect();
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@mapn", mapn);
                cmd.Parameters.AddWithValue("@mash", mash);
                object result = cmd.ExecuteScalar();
                conn.close_connect();
                return Convert.ToInt32(result);
            }
            catch { conn.close_connect(); return 0; }
        }

        public bool ExecuteNonQuery(string sql, string mapn, string mash, int soluong, float dongia, float thanhtien)
        {
            try
            {
                conn.open_connect();
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());

                cmd.Parameters.AddWithValue("@mapn", mapn);
                cmd.Parameters.AddWithValue("@mash", mash);

                // Hỗ trợ cả 2 kiểu tên
               
                cmd.Parameters.AddWithValue("@sl", soluong);

               
                cmd.Parameters.AddWithValue("@dg", dongia);

              
                cmd.Parameters.AddWithValue("@tt", thanhtien);

                cmd.ExecuteNonQuery();
                conn.close_connect();
                return true;
            }
            catch (Exception ex)
            {
                conn.close_connect();
                MessageBox.Show("Lỗi SQL: " + ex.Message); // Thêm dòng này để thấy lỗi thật
                return false;
            }
        }
        public DataTable LayDSSach()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.open_connect();
                string sql = "SELECT MASH, TENSH, GIA FROM SACH";
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.close_connect();
            }
            catch
            {
                conn.close_connect();
            }
            return dt;
        }
        public bool CapNhatTonKhoKhiNhap(string mapn)
        {
            try
            {
                conn.open_connect();
                SqlTransaction transaction = conn.get_connect().BeginTransaction();

                try
                {
                    // 1. ĐẦU TIÊN: Reset tồn kho về trạng thái ban đầu (trước khi nhập phiếu này)
                    string sqlReset = @"
                UPDATE SACH
                SET SLTONKHO = SLTONKHO - ct.soluong
                FROM SACH s
                INNER JOIN ChiTietPhieuNhap ct ON s.MASH = ct.mash
                WHERE ct.mapn = @mapn";

                    SqlCommand cmdReset = new SqlCommand(sqlReset, conn.get_connect(), transaction);
                    cmdReset.Parameters.AddWithValue("@mapn", mapn);
                    cmdReset.ExecuteNonQuery();

                    // 2. SAU ĐÓ: Cộng lại tồn kho theo số lượng hiện tại trong chi tiết
                    string sqlUpdate = @"
                UPDATE SACH
                SET SLTONKHO = SLTONKHO + ct.soluong
                FROM SACH s
                INNER JOIN ChiTietPhieuNhap ct ON s.MASH = ct.mash
                WHERE ct.mapn = @mapn";

                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn.get_connect(), transaction);
                    cmdUpdate.Parameters.AddWithValue("@mapn", mapn);
                    cmdUpdate.ExecuteNonQuery();

                    transaction.Commit();
                    conn.close_connect();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    conn.close_connect();
                    MessageBox.Show("Lỗi khi cập nhật tồn kho: " + ex.Message);
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.close_connect();
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return false;
            }
        }
        public DataTable LayThongTinPhieuNhap(string mapn)
        {
            string sql = @"
        SELECT pn.mapn, pn.ngaynhap, ncc.TenNCC, nv.TenNV
        FROM PhieuNhap pn
        LEFT JOIN NhaCungCap ncc ON pn.mancc = ncc.MaNCC
        LEFT JOIN NhanVien nv ON pn.manv = nv.MaNV
        WHERE pn.mapn = @mapn";

            DataTable dt = new DataTable();
            try
            {
                conn.open_connect();
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@mapn", mapn);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            finally { conn.close_connect(); }
            return dt;
        }
    }
}
