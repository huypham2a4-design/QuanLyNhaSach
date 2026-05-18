using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class Sach
    {
        private string mash, tensh, tacgia, theloai, nxb;
        private float dongia;
        private int soluong;

        public Sach() { }

        public Sach(string mash, string tensh, string tacgia, string theloai, float dongia, string nxb, int soluong)
        {
            this.mash = mash;
            this.tensh = tensh;
            this.tacgia = tacgia;
            this.soluong = soluong;
            this.theloai = theloai;
            this.nxb = nxb;
            this.dongia = dongia;           
        }
       
        public string Mash
        {
            get
            {
                return mash;
            }

            set
            {
                mash = value;
            }
        }

        public string Tensh
        {
            get
            {
                return tensh;
            }

            set
            {
                tensh = value;
            }
        }

        public string Tacgia
        {
            get
            {
                return tacgia;
            }

            set
            {
                tacgia = value;
            }
        }

        
        public string Nxb
        {
            get
            {
                return nxb;
            }

            set
            {
                nxb = value;
            }
        }
       
        public string Theloai
        {
            get
            {
                return theloai;
            }

            set
            {
                theloai = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }
    }
}
