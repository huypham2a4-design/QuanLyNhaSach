using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaSach.CSDL
{
    public class Model_QuanLy_NhanVien
    {
        CSDL.Connect_DB conn = new CSDL.Connect_DB();

        // Lấy dữ liệu nhân viên
        public DataSet load_dulieuDGV_NV()
        {
            conn.open_connect();
            string str = "select * from nhanvien";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds, "nhanvien");
            conn.close_connect();
            return ds;
        }

        public int KT_KhoaChinh_NV(string pMa)
        {
            try
            {
                conn.open_connect();
                string str = "select count(*) from NHANVIEN where MANV ='" + pMa + "'";
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

        // Thêm Nhân viên
        public int ThemNV(Model.NhanVien nv)
        {
            try
            {
                conn.open_connect();
                string str = "insert into NHANVIEN values ('" + nv.Manv + "', N'" + nv.Tennv + "', '" + nv.Ngaysinh + "', N'" + nv.Gioitinh + "', '" + nv.Cmnd + "', N'" + nv.Diachi + "', '" + nv.Sdt + "' )";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());

                return cmd.ExecuteNonQuery();
                conn.close_connect();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public void ThemTKNV(Model.TK_NHANVIEN tknv)
        {
            conn.open_connect();
            string str = "insert into TK_NHANVIEN values ('" + tknv.Manv + "','" + tknv.Matkhau + "')";
            SqlCommand cmd = new SqlCommand(str, conn.get_connect());

            cmd.ExecuteNonQuery();
            conn.close_connect();
        }

        public int SuaNV(Model.NhanVien nv)
        {
            try
            {
                conn.open_connect();
                string str = "update NhanVien set TenNV = N'" + nv.Tennv + "', NGAYSINH = '" + nv.Ngaysinh + "',gioitinh = N'" + nv.Gioitinh + "', cmnd = '" + nv.Cmnd + "', diachi = N'" + nv.Diachi + "', sdt = '" + nv.Sdt + "' where MANV = '" + nv.Manv + "' ";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                return cmd.ExecuteNonQuery();
                conn.close_connect();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int XoaNV(Model.NhanVien nv)
        {
            try
            {
                conn.open_connect();
                string str = "delete NHANVIEN where MANV = '" + nv.Manv + "'";
                string str1 = "delete TK_NHANVIEN where MANV = '" + nv.Manv + "'";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                SqlCommand cmd1 = new SqlCommand(str1, conn.get_connect());
                int a = cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                return a;
                conn.close_connect();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable lay_Data_Cbx_TinhTP()
        {
            conn.open_connect();
            string str = "Select * from TinhThanhPho";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds);
            conn.close_connect();
            return ds;

        }
      
        public DataTable lay_Data_Cbx_QuanHuyen()
        {
            conn.open_connect();
            string str = "Select * from QuanHuyen";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds);
            conn.close_connect();
            return ds;

        }

        //public int Load_QuanHuyen(string pMa)
        //{
        //    try
        //    {
        //        conn.open_connect();
        //        string str = "select count(tenquanhuyen) from QUANHUYEN where tinhthanhphoID =" + pMa + " ";
        //        SqlCommand cmd = new SqlCommand(str, conn.get_connect());

        //        int a = (int)cmd.ExecuteScalar();
        //        conn.close_connect();
        //        return a;
        //    }
        //    catch (Exception)
        //    {
        //        return 0;
        //    }

                  
        //}
    }
}
