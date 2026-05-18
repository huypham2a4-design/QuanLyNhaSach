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
    public class Model_PhieuNhap
    { CSDL.Connect_DB conn = new CSDL.Connect_DB();
        //Lấy dữ liệu khách hàng
        public DataSet load_dulieuDGV_PN()
        {
            conn.open_connect();
            string str = "select *from phieunhap";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds, "PhieuNhap");
            conn.close_connect();
            return ds;
        }
        //public DataTable load_cboTenNV()
        //{
        //    conn.open_connect();
        //    string str = "Select * from nhanvien";
        //    DataTable ds = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
        //    da.Fill(ds);
        //    return ds;
        //}
        public DataTable load_Cbo_ncc()
        {
            conn.open_connect();
            string str = "SELECT MaNCC, TenNCC FROM NhaCungCap";

            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds);
            conn.close_connect();
            return ds;
        }
        public int KT_KhoaChinh_PN(string pMa)
        {
            try
            {
                conn.open_connect();
                string str = "select count(*) from PHIEUNHAP where Mapn ='" + pMa + "'";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());

                int a = (int)cmd.ExecuteScalar();
                conn.close_connect();
                return a;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int ThemPhieuNhap(Model.PhieuNhap pn)
        {
            try
            {
                conn.open_connect();
                string str = "INSERT INTO PhieuNhap (Mapn, Manv, Mancc, Ngaynhap) VALUES (@Mapn, @Manv, @Mancc, @Ngaynhap)";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                cmd.Parameters.AddWithValue("@Mapn", pn.Mapn);
                cmd.Parameters.AddWithValue("@Manv", pn.Manv);
                cmd.Parameters.AddWithValue("@Mancc", pn.Mancc);
                cmd.Parameters.Add("@Ngaynhap", SqlDbType.Date).Value = pn.Ngaynhap; // kiểu Date hoặc DateTime

                int result = cmd.ExecuteNonQuery();
                conn.close_connect();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu nhập: " + ex.Message);
                return 0;
            }
        }
        public int capNhatPN(Model.PhieuNhap pn)
        {
            try
            {
                conn.open_connect();
                string str = "UPDATE PhieuNhap SET Manv = @Manv, Mancc = @Mancc, Ngaynhap = @Ngaynhap WHERE Mapn = @Mapn";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                cmd.Parameters.AddWithValue("@Mapn", pn.Mapn);
                cmd.Parameters.AddWithValue("@Manv", pn.Manv);
                cmd.Parameters.AddWithValue("@Mancc", pn.Mancc);
                cmd.Parameters.AddWithValue("@Ngaynhap", pn.Ngaynhap);

                int result = cmd.ExecuteNonQuery();
                conn.close_connect();
                return result;
            }
            catch (Exception ex)
            {
                conn.close_connect();
                System.Windows.Forms.MessageBox.Show("Lỗi cập nhật phiếu nhập: " + ex.Message);
                return 0;
            }
        }

        //Hàm xóa dữ liệu khách hàng khỏi database
        public int xoaPN(Model.PhieuNhap pn)
        {
            try
            {
                conn.open_connect();
                SqlTransaction transaction = conn.get_connect().BeginTransaction();

                try
                {
                    // Bước 1: Xóa tất cả chi tiết phiếu nhập trước
                    string sqlDeleteCT = "DELETE FROM ChiTietPhieuNhap WHERE mapn = @mapn";
                    SqlCommand cmdCT = new SqlCommand(sqlDeleteCT, conn.get_connect(), transaction);
                    cmdCT.Parameters.AddWithValue("@mapn", pn.Mapn);
                    cmdCT.ExecuteNonQuery();

                    // Bước 2: Xóa phiếu nhập
                    string sqlDeletePN = "DELETE FROM PhieuNhap WHERE mapn = @mapn";
                    SqlCommand cmdPN = new SqlCommand(sqlDeletePN, conn.get_connect(), transaction);
                    cmdPN.Parameters.AddWithValue("@mapn", pn.Mapn);
                    int result = cmdPN.ExecuteNonQuery();

                    transaction.Commit();
                    conn.close_connect();
                    return result;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    conn.close_connect();
                    MessageBox.Show("Lỗi khi xóa phiếu nhập: " + ex.Message +
                                  "\n\nCó thể do phiếu nhập đã có chi tiết.",
                                  "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                conn.close_connect();
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return 0;
            }
        }
    }
}
