using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaSach.CSDL
{
    public class Model_Sach
    {
        CSDL.Connect_DB conn = new CSDL.Connect_DB();
        DataSet QUANLY_NHASACH = new DataSet();
        //Lấy dữ liệu khách hàng
        public DataSet load_dulieuDGV_sach()
        {
            conn.open_connect();
            string str = "select Sach.*, tentgchinh, tennxb, tenkho from sach ,tacgia ,nhaxuatban, khohang where sach.matgchinh = tacgia.matgchinh and sach.makho = khohang.makho and sach.manxb = nhaxuatban.manxb";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds, "Sach");
            conn.close_connect();
            return ds;
        }

        //Lấy dữ liệu lên combobox Sách
        public DataTable lay_Data_Cbx_TheLoai()
        {
            conn.open_connect();
            string str = "Select theloai from SACH";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds);
            conn.close_connect();
            return ds;

        }

        //Lấy dữ liệu lên combobox Tác giả
        public DataTable lay_Data_Cbx_NXB()
        {
            conn.open_connect();
            string str = "Select * from NhaXuatBan";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds);
            conn.close_connect();
            return ds;

        }

        //Lấy dữ liệu lên combobox Tác giả
        public DataTable lay_Data_Cbx_MaTGC()
        {
            conn.open_connect();
            string str = "Select * from TACGIA";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds);
            conn.close_connect();
            return ds;

        }

        //Lấy dữ liệu lên combobox kho
        public DataTable lay_Data_Cbx_MaKho()
        {
            conn.open_connect();
            string str = "Select * from Khohang";
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds);
            conn.close_connect();
            return ds;

        }

        //Kiểm tra khóa chính 
        public int KT_KhoaChinh(string pMa)
        {
            try
            {
                conn.open_connect();
                string str = "select count(*) from Sach where mash ='" + pMa + "'";
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
        public int ThemSach(Model.Sach sach)
        {
            try
            {
                conn.open_connect();
                string str = "insert into Sach values ('" + sach.Mash + "',N'" + sach.Tensh + "',N'" + sach.Theloai + "',N'" + sach.Dongia + "','" + sach.Soluong + "', '" + sach.Nxb + "', '" + sach.Tacgia + "', '"+sach.Makho+"')";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                return cmd.ExecuteNonQuery();
                conn.close_connect();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //hàm cập nhật dữ liệu sách xuống database
        public int capNhatSach(Model.Sach sach)
        {
            try
            {
                conn.open_connect();
                string str = "update sach set tensh = N'" + sach.Tensh + "', theloai= N'" + sach.Theloai + "', gia = '" + sach.Dongia + "', sltonkho = '" + sach.Soluong + "', manxb = '" + sach.Nxb + "', matgchinh = N'" + sach.Tacgia + "', makho = '" + sach.Makho + "' where mash = '" + sach.Mash + "' ";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());

                return cmd.ExecuteNonQuery();
                conn.close_connect();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //Hàm xóa dữ liệu sách khỏi database
        public int xoaSach(Model.Sach sach)
        {
            try
            {
                conn.open_connect();
                string str = "delete from Sach where mash = '" + sach.Mash + "' ";
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
