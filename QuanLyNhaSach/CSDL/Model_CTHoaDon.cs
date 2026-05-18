using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.Model;

namespace QuanLyNhaSach.CSDL
{
    class Model_CTHoaDon
    {
        CSDL.Connect_DB conn = new Connect_DB();
        public DataTable LayDSChiTiet(string mahd)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.open_connect();
                string sql = @"
            SELECT 
                ct.MAHD,
                ct.MASH,
                s.TENSH,
                ct.SOLUONG,
                ct.DONGIA,
                ct.THANHTIEN
            FROM CHITIET_HOADON ct
            INNER JOIN SACH s ON ct.MASH = s.MASH
            WHERE ct.MAHD = @MAHD
            ORDER BY s.TENSH";

                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@MAHD", mahd);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load chi tiết hóa đơn: " + ex.Message);
            }
            finally
            {
                conn.close_connect();
            }
            return dt;
        }

        public bool ThemChiTiet(ChiTietHoaDon cthd)
        {
            try
            {
                conn.open_connect();
                string sql = @"INSERT INTO CHITIET_HOADON(MAHD, MASH, SOLUONG, DONGIA, THANHTIEN)
                               VALUES(@MAHD, @MASH, @SOLUONG, @DONGIA, @THANHTIEN)";
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@MAHD", cthd.Mahd);
                cmd.Parameters.AddWithValue("@MASH", cthd.Mash);
                cmd.Parameters.AddWithValue("@SOLUONG", cthd.Soluong);
                cmd.Parameters.AddWithValue("@DONGIA", cthd.Dongia);
                cmd.Parameters.AddWithValue("@THANHTIEN", cthd.Thanhtien);
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

    
        public bool XoaChiTiet(string mahd, string mash)
        {
            try
            {
                conn.open_connect();
                string sql = "DELETE FROM CHITIET_HOADON WHERE MAHD = @MAHD AND MASH = @MASH";
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@MAHD", mahd);
                cmd.Parameters.AddWithValue("@MASH", mash);
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

        public bool CapNhatChiTiet(ChiTietHoaDon cthd)
        {
            try
            {
                conn.open_connect();
                string sql = @"UPDATE CHITIET_HOADON 
                               SET SOLUONG=@SOLUONG, DONGIA=@DONGIA, THANHTIEN=@THANHTIEN
                               WHERE MAHD=@MAHD AND MASH=@MASH";
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@MAHD", cthd.Mahd);
                cmd.Parameters.AddWithValue("@MASH", cthd.Mash);
                cmd.Parameters.AddWithValue("@SOLUONG", cthd.Soluong);
                cmd.Parameters.AddWithValue("@DONGIA", cthd.Dongia);
                cmd.Parameters.AddWithValue("@THANHTIEN", cthd.Thanhtien);
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
        public DataTable LayThongTinHoaDon(string mahd)
        {
            DataTable dt = new DataTable();
            try
            {
                // KHÔNG open_connect() và close_connect() ở đây nữa
                // Dùng kết nối đã mở từ hàm gọi (CapNhatGiamGiaHoaDon)
                string sql = @"
            SELECT h.MAHD, h.NGAYXUATHD, h.MAKH, h.MANV,
                   ISNULL(kh.TENKH, 'Khách lẻ') AS TENKH,
                   nv.TENNV,
                   ISNULL(h.PHANTRAMGIAM, 0) AS PHANTRAMGIAM,
                   ISNULL(h.TONGTIEN, 0) AS TONGTIEN
            FROM HOADON h
            LEFT JOIN KHACHHANG kh ON h.MAKH = kh.MAKH
            INNER JOIN NHANVIEN nv ON h.MANV = nv.MANV
            WHERE h.MAHD = @MAHD";
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@MAHD", mahd);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy thông tin hóa đơn: " + ex.Message);
            }
            // KHÔNG close ở đây
            return dt;
        }
        public bool CapNhatTonKho(string mahd)
        {
            try
            {
                conn.open_connect();
                SqlTransaction transaction = conn.get_connect().BeginTransaction();
                try
                {

                    string sql = @"
                UPDATE SACH
                SET SLTONKHO = SLTONKHO - ct.SOLUONG
                FROM SACH s
                INNER JOIN CHITIET_HOADON ct ON s.MASH = ct.MASH
                WHERE ct.MAHD = @MAHD
                  AND s.SLTONKHO >= ct.SOLUONG";
                    SqlCommand cmd = new SqlCommand(sql, conn.get_connect(), transaction);
                    cmd.Parameters.AddWithValue("@MAHD", mahd);
                    cmd.ExecuteNonQuery();
                    string checkSql = @"
                SELECT COUNT(*)
                FROM CHITIET_HOADON ct
                JOIN SACH s ON ct.MASH = s.MASH
                WHERE ct.MAHD = @MAHD
                  AND s.SLTONKHO < 0";
                    cmd = new SqlCommand(checkSql, conn.get_connect(), transaction);
                    cmd.Parameters.AddWithValue("@MAHD", mahd);
                    int negativeCount = (int)cmd.ExecuteScalar();
                    if (negativeCount > 0)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Không đủ số lượng tồn kho để xuất hóa đơn!\nMột số sách đã hết hàng.",
                        "Lỗi tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.close_connect();
                        return false;
                    }
                    transaction.Commit();
                    conn.close_connect();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                conn.close_connect();
                MessageBox.Show("Lỗi cập nhật tồn kho: " + ex.Message);
                return false;
            }
        }
        // Tính tổng số lượng sách trong hóa đơn
        public int TongSoLuongSach(string mahd)
        {
            int tong = 0;
            try
            {
                // KHÔNG open_connect() ở đây nữa, dùng kết nối đã mở từ hàm gọi
                string sql = "SELECT SUM(SOLUONG) FROM CHITIET_HOADON WHERE MAHD = @MAHD";
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@MAHD", mahd);
                object result = cmd.ExecuteScalar();
                tong = result == DBNull.Value ? 0 : Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính tổng số lượng: " + ex.Message);
            }
            // Không close_connect() ở đây
            return tong;
        }

        // Tính và cập nhật giảm giá + tổng tiền vào bảng HOADON
        public void CapNhatGiamGiaHoaDon(string mahd)
        {
            try
            {
                conn.open_connect();  // Mở 1 lần duy nhất ở đầu

                // Lấy thông tin hóa đơn để biết có phải khách lẻ không
                DataTable dtHD = LayThongTinHoaDon(mahd);
                if (dtHD.Rows.Count == 0)
                {
                    conn.close_connect();
                    return;
                }

                bool isKhachLe = dtHD.Rows[0]["MAKH"] == DBNull.Value || dtHD.Rows[0]["MAKH"] == null;

                // Tính tổng tiền gốc từ chi tiết
                string sqlTong = "SELECT SUM(THANHTIEN) FROM CHITIET_HOADON WHERE MAHD = @MAHD";
                SqlCommand cmdTong = new SqlCommand(sqlTong, conn.get_connect());
                cmdTong.Parameters.AddWithValue("@MAHD", mahd);
                object tongObj = cmdTong.ExecuteScalar();
                double tongTienGoc = tongObj == DBNull.Value ? 0 : Convert.ToDouble(tongObj);

                // Tính phần trăm giảm
                double phanTramGiam = 0;
                if (!isKhachLe)
                {
                    int tongSL = TongSoLuongSach(mahd);  
                    if (tongSL >= 20) phanTramGiam = 0.15;
                    else if (tongSL >= 10) phanTramGiam = 0.10;
                    else if (tongSL >= 5) phanTramGiam = 0.05;
                }

                double tongSauGiam = tongTienGoc * (1 - phanTramGiam);

                // Cập nhật vào HOADON
                string sqlUpdate = @"UPDATE HOADON 
                             SET PHANTRAMGIAM = @PHANTRAMGIAM, 
                                 TONGTIEN = @TONGTIEN 
                             WHERE MAHD = @MAHD";
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn.get_connect());
                cmdUpdate.Parameters.AddWithValue("@PHANTRAMGIAM", phanTramGiam);
                cmdUpdate.Parameters.AddWithValue("@TONGTIEN", tongSauGiam);
                cmdUpdate.Parameters.AddWithValue("@MAHD", mahd);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật giảm giá: " + ex.Message);
            }
            finally
            {
                conn.close_connect();  // Chỉ đóng 1 lần ở cuối
            }
        }
    }


}


