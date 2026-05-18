using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaSach.CSDL
{
    public class Model_NhanVien_QL
    {
        CSDL.Connect_DB conn = new CSDL.Connect_DB();

        //Lấy dữ liệu đọc giả
        public DataSet load_tkdangnhap(string maql)
        {
            conn.open_connect();
            string str = "select maql from tk_quanly where maql = '" + maql + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds, "tk_quanly");
            conn.close_connect();
            return ds;
        }

        //Kiểm tra tên đăng nhập nhân viên
        public bool kiemtra_tenDNNV(string manv)
        {
            try
            {
                conn.open_connect();
                string str = "select count(*) from tk_nhanvien where manv = '" + manv + "'";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                int a = (int)cmd.ExecuteScalar();
                if (a == 0)
                {
                    return false;
                }
                conn.close_connect();
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        //Kiểm tra mật khẩu cũ nhân viên
        public bool kiemtra_MatKhauNV(Model.TK_NHANVIEN NV)
        {
            try
            {
                conn.open_connect();
                string str = "select count(*) from tk_nhanvien where matkhau = '" + NV.Matkhau + "' and manv = '" + NV.Manv + "'";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                int a = (int)cmd.ExecuteScalar();
                if (a == 0)
                {
                    return false;
                }
                conn.close_connect();
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        //Cập nhật mật khẩu nhân viên
        public int capnhat_MatKhauNV(Model.TK_NHANVIEN NV)
        {
            try
            {
                conn.open_connect();
                string str = "update tk_nhanvien set matkhau = '" + NV.Matkhau + "' where manv = '" + NV.Manv + "'";               
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                return cmd.ExecuteNonQuery();                       
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //Kiểm tra tên đăng nhập quản lý
        public bool kiemtra_tenDNQL(string maql)
        {
            try
            {
                conn.open_connect();
                string str = "select count(*) from tk_quanly where maql = '" + maql + "'";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                int a = (int)cmd.ExecuteScalar();
                if (a == 0)
                {
                    return false;
                }
                conn.close_connect();
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        //Kiểm tra mật khẩu cũ quản lý
        public bool kiemtra_MatKhauQL(Model.TK_QUANLY QL)
        {
            try
            {
                conn.open_connect();
                string str = "select count(*) from tk_quanly where matkhau = '" + QL.Matkhau + "' and maql = '" + QL.Maql + "'";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                int a = (int)cmd.ExecuteScalar();
                if (a == 0)
                {
                    return false;
                }
                conn.close_connect();
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        //Cập nhật mật khẩu
        public int capnhat_MatKhauQL(Model.TK_QUANLY QL)
        {
            try
            {
                conn.open_connect();
                string str = "update tk_quanly set matkhau = '" + QL.Matkhau + "' where maql = '" + QL.Maql + "'";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        
    }
}
