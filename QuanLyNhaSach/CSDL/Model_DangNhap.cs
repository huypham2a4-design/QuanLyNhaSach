using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaSach.CSDL
{
    public class Model_DangNhap
    {
        CSDL.Connect_DB conn = new CSDL.Connect_DB();

        //Kiểm tra đăng nhập nhân viên
        public bool kiemtra_nhanvien(Model.TK_NHANVIEN NV)
        {
            try
            {
                conn.open_connect();
                string str = "select * from TK_NHANVIEN";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (NV.Manv.Equals(rdr["manv"]) && NV.Matkhau.Equals(rdr["matkhau"]))
                    {
                        return true;
                    }
                }
                conn.close_connect();
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Kiểm tra đăng nhập quản lý
        public bool kiemtra_quanly(Model.TK_QUANLY QL)
        {
            try
            {
                conn.open_connect();
                string str = "select * from tk_quanly";
                SqlCommand cmd = new SqlCommand(str, conn.get_connect());
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (QL.Maql.Equals(rdr["maql"]) && QL.Matkhau.Equals(rdr["matkhau"]))
                    {
                        return true;
                    }
                }
                conn.close_connect();
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
