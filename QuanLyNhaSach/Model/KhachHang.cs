using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class KhachHang
    {
        private string makh;
        private string tenkh;
        private string gioitinh;
        private string diachi;
        private string sdt;       
        private string email;

        public KhachHang () { }

        public KhachHang (string makh, string tenkh, string gioitinh, string diachi, string sdt, string email)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.email = email;
        }

        public string Makh
        {
            get
            {
                return makh;
            }

            set
            {
                makh = value;
            }
        }

        public string Tenkh
        {
            get
            {
                return tenkh;
            }

            set
            {
                tenkh = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }
     
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
