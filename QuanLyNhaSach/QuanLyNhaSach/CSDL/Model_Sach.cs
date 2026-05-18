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
        DataSet QL_NHASACH = new DataSet();
    
        //Load dữ liệu sách lên datagridview
        public DataSet load_dulieuDGV_sach()
        {
            conn.open_connect();
            string str = "select * from Sach";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.get_connect());
            da.Fill(ds, "Sach");
            conn.close_connect();
            return ds;
        }

        //Kiểm tra khóa chính bảng sách
        public bool KT_KhoaChinh(string pMa)
        {
            conn.open_connect();
            //Thiet lap chuoi truy van dang hien thi du lieu
            string str = "select count(*) from sach where mash ='" + pMa + "'";
            //Xay dung SqlCommand truy van
            SqlCommand cmd = new SqlCommand(str, conn.get_connect());
            //Goi phuong thuc truy van dang hien thi du lieu
            SqlDataReader rd = cmd.ExecuteReader();
            //Xu ly ket qua
            if (rd.HasRows)
            {
                rd.Close();
                conn.close_connect();
                return false;
            }
            else
            {
                rd.Close();
                conn.close_connect();
                return true;
            }                           
        }
        
        //public int ThemSach(Model.Sach sach)
        //{
        //    try
        //    {   
        //        conn.open_connect();
        //        string insertString;
        //        insertString = "insert into Sach values('" + sach.Mash
        //        + "', N'" + txt_TenSach.Text + "',N'" + txt_TacGia.Text + "', N'" + txt_TheLoai.Text + "','" + txt_DonGia.Text + "',N'" + txt_NXB.Text + "', " + txt_SoLuong.Text + ")";
        //        SqlCommand cmd = new SqlCommand(insertString, conn.get_connect());
        //        cmd.ExecuteNonQuery();
        //        conn.close_connect();
                     
                        
                
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("That bai");
        //    }

        //}


    }
}
