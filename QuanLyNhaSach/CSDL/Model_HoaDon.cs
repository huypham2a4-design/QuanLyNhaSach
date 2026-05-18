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
    public class Model_HoaDon
    {
        Connect_DB conn = new Connect_DB();

        // Lấy toàn bộ danh sách hóa đơn
        public DataTable LayDSHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.open_connect();
                string sql = "SELECT * FROM HOADON";
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.close_connect();
            }
            catch (Exception)
            {
                conn.close_connect();
            }
            return dt;
        }

        // Thêm hóa đơn
        public bool ThemHoaDon(HoaDon hd, bool isKhachLe = false)
        {
            try
            {
                conn.open_connect();
                string sql = @"INSERT INTO HOADON (MAHD, MAKH, MANV, NGAYXUATHD) 
                       VALUES (@MAHD, @MAKH, @MANV, @NGAYXUATHD)";

                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@MAHD", hd.Mahd);

                // Nếu là khách lẻ thì MAKH = NULL
                if (isKhachLe || string.IsNullOrEmpty(hd.Makh) || hd.Makh == "0")
                    cmd.Parameters.AddWithValue("@MAKH", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@MAKH", hd.Makh);

                cmd.Parameters.AddWithValue("@MANV", hd.Manv);
                cmd.Parameters.AddWithValue("@NGAYXUATHD", hd.Ngaynhap);

                int rows = cmd.ExecuteNonQuery();
                conn.close_connect();
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm hóa đơn: " + ex.Message);
                conn.close_connect();
                return false;
            }
        }

        // Cập nhật hóa đơn
        public bool CapNhatHoaDon(HoaDon hd, bool isKhachLe = false)
        {
            try
            {
                conn.open_connect();
                string sql = @"UPDATE HOADON
                       SET MAKH = @MAKH, MANV = @MANV, NGAYXUATHD = @NGAYXUATHD
                       WHERE MAHD = @MAHD";

                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@MAHD", hd.Mahd);

                // Kiểm tra xem MAKH = "0" thì coi như khách lẻ
                if (isKhachLe || string.IsNullOrEmpty(hd.Makh) || hd.Makh == "0")
                    cmd.Parameters.AddWithValue("@MAKH", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@MAKH", hd.Makh);

                cmd.Parameters.AddWithValue("@MANV", hd.Manv);
                cmd.Parameters.AddWithValue("@NGAYXUATHD", hd.Ngaynhap);

                int rows = cmd.ExecuteNonQuery();
                conn.close_connect();
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật hóa đơn: " + ex.Message);
                conn.close_connect();
                return false;
            }
        }

        // Xóa hóa đơn
        public bool XoaHoaDon(string mahd)
        {
            try
            {
                conn.open_connect();

                // Bước 1: Xóa chi tiết trước
                string sqlChiTiet = "DELETE FROM CHITIET_HOADON WHERE MAHD = @MAHD";
                SqlCommand cmdCT = new SqlCommand(sqlChiTiet, conn.get_connect());
                cmdCT.Parameters.AddWithValue("@MAHD", mahd);
                cmdCT.ExecuteNonQuery();

                // Bước 2: Xóa hóa đơn
                string sql = "DELETE FROM HOADON WHERE MAHD = @MAHD";
                SqlCommand cmd = new SqlCommand(sql, conn.get_connect());
                cmd.Parameters.AddWithValue("@MAHD", mahd);
                int rows = cmd.ExecuteNonQuery();

                conn.close_connect();
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa hóa đơn: " + ex.Message); // Thêm để xem lỗi chi tiết
                conn.close_connect();
                return false;
            }
        }
        public DataTable LayDSKhachHang()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.open_connect();
                string sql = "SELECT MAKH, TENKH FROM KHACHHANG";
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

        public DataTable LayDSNhanVien()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.open_connect();
                string sql = "SELECT MANV, TENNV FROM NHANVIEN";
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
    }
}

