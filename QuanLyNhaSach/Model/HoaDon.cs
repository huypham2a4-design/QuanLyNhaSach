using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class HoaDon
    {
        private string mahd, makh, manv;

        public DateTime ngayxuathd { get; set; }
        public HoaDon() { }
        public HoaDon(string mahd, string makh, string manv, DateTime ngayxuathd)
        {
            this.mahd = mahd;
            this.makh = makh;
            this.manv = manv;
            this.ngayxuathd = ngayxuathd;
        }
        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        public DateTime Ngaynhap
        {
            get { return ngayxuathd; }
            set { ngayxuathd = value; }
        }

    }
}
