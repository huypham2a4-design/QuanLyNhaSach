using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class PhieuNhap  
    {
        private string connectionString = "Data Source=LAPTOP;Initial Catalog=QUANLY_NHASACH;Integrated Security=True";

        private string mapn, manv, mancc, ngaynhap;
        public PhieuNhap() { }
        public PhieuNhap(string mapn, string manv, string mancc, string ngaynhap)
        {
            this.mapn = mapn;
            this.manv = manv;
            this.mancc = mancc;
            this.ngaynhap = ngaynhap;
        }
        public string Mapn
        {
            get { return mapn; }
            set { mapn = value; }
        }
        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        public string Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }
        public string Ngaynhap
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }
        public DataTable LoadChiTietPN(string maPN)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT ct.mapn, ct.mash, s.tensh, ct.soluong, ct.dongia, ct.thanhtien
                                   FROM ChiTietPhieuNhap ct
                                   INNER JOIN Sach s ON ct.mash = s.mash
                                   WHERE ct.mapn = @mapn";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@mapn", maPN);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi load chi tiết phiếu nhập: " + ex.Message);
                }
            }

            return dt;
        }
        public string GetConnectionString()
        {
            return connectionString;
        }
    }
}
