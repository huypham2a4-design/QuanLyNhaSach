using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaSach.CSDL
{
    public class Model_KhachHang
    {
        CSDL.Connect_DB conn = new CSDL.Connect_DB();

        //Lấy dữ liệu khách hàng
        public DataSet load_dulieuDGV_KH()
        {
            conn.open_connect();
            string str = "select * from khachhang";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds, "Khachhang");
            conn.close_connect();
            return ds;
        }

        //Kiểm tra khóa chính bảng khách hàng
        public int KT_KhoaChinh(string pMa)
        {
            try
            {
                conn.open_connect();
                string str = "select count(*) from khachhang where makh ='" + pMa + "'";
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

        //Hàm thêm dữ liệu khách hàng xuống database
        public int ThemKH(Model.KhachHang KH)
        {
            try
            {
                conn.open_connect();
                string str = "insert into KHACHHANG values ('" + KH.Makh + "',N'" + KH.Tenkh + "',N'" + KH.Gioitinh + "',N'" + KH.Diachi + "','" + KH.Sdt + "', '" +KH.Email + "')";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());                
                return cmd.ExecuteNonQuery();
                conn.close_connect();               
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //hàm cập nhật dữ liệu khách hàng xuống database
        public int capNhatKH(Model.KhachHang KH)
        {
            try
            {
                conn.open_connect();
                string str = "update KHACHHANG set tenkh = N'" + KH.Tenkh + "', gioitinh = N'" + KH.Gioitinh + "', Diachi = N'" + KH.Diachi + "', sdt = '" + KH.Sdt + "', email = '" + KH.Email + "' where makh = '" + KH.Makh + "' ";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());

                return cmd.ExecuteNonQuery();
                conn.close_connect();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //Hàm xóa dữ liệu khách hàng khỏi database
        public int xoaKH(Model.KhachHang KH)
        {
            try
            {
                conn.open_connect();
                string str = "delete from KHACHHANG where makh = '" + KH.Makh + "' ";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());

                return cmd.ExecuteNonQuery();
                conn.close_connect();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
