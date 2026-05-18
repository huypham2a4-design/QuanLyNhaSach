using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class TK_QUANLY
    {
        private string maql, matkhau;

        public TK_QUANLY () 
        {
 
        }

        public TK_QUANLY (string maql, string matkhau)
        {
            this.maql = maql;
            this.matkhau = matkhau;
        }

        public string Maql
        {
            get { return maql; }
            set { maql = value; }          
        }

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
    }
}
