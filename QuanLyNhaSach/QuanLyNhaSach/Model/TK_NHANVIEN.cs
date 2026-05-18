using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class TK_NHANVIEN
    {
        private string manv, matkhau;

        public TK_NHANVIEN () 
        {
 
        }

        public TK_NHANVIEN (string manv, string matkhau)
        {
            this.manv = manv;
            this.matkhau = matkhau;
        }

        public string Manv
        {
            get { return manv; }
            set { manv = value; }          
        }

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
    }
}
