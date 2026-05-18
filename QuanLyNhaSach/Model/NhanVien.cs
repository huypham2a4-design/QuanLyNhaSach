using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    public class NhanVien
    {
        private string manv, tennv, ngaysinh, gioitinh, cmnd, diachi, sdt;

        public NhanVien()
        { }

        public NhanVien(string manv, string tennv, string ngaysinh, string gioitinh, string cmnd, string diachi, string sdt)
        {
            this.manv = manv;
            this.tennv = tennv;           
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
            this.diachi = diachi;
            this.sdt = sdt;          
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

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
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

        public string Tennv
        {
            get
            {
                return tennv;
            }

            set
            {
                tennv = value;
            }
        }

        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
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
    }
}
