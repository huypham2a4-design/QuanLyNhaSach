using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class Sach
    {
        private string mash, tensh, tacgia, theloai, nxb, makho;
        private string dongia;
        private string soluong;

        public Sach() { }

        public Sach(string mash, string tensh, string theloai, string dongia, string soluong, string nxb, string tacgia, string makho)
        {
            this.mash = mash;
            this.tensh = tensh;
            this.theloai = theloai;
            this.dongia = dongia;
            this.soluong = soluong;
            this.nxb = nxb;
            this.tacgia = tacgia;
            this.makho = makho;
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

        public string Soluong
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
        public string Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public string Makho
        {
            get
            {
                return makho;
            }

            set
            {
                makho = value;
            }
        }
    }
}
