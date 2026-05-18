using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class ChiTietHoaDon
    {
        private string mahd, mash;
        private int soluong;
        private float dongia, thanhtien;
        public ChiTietHoaDon() { }
        public ChiTietHoaDon(string mahd, string mash, int soluong, float dongia, float thanhtien)
        {
            this.mahd = mahd;
            this.mash = mash;
            this.soluong = soluong;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
        }
        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        public string Mash
        {
            get { return mash; }
            set { mash = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public float Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public float Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
    }
}
