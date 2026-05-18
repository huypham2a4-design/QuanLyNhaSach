using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.GiaoDien
{
    public partial class ThemNhanVien : Form
    {
        CSDL.Model_QuanLy_NhanVien QLNV = new CSDL.Model_QuanLy_NhanVien();

        public ThemNhanVien()
        {
            InitializeComponent();
            this.CenterToScreen();
        }       

        public ThemNhanVien(string a) : this()
        {
            txt_TaiKhoan.Text = a;
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Enabled = txt_MatKhau.Enabled = false;
            txt_MatKhau.Text = "123456";
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
        }

        private void btn_taotaikhoan_Click(object sender, EventArgs e)
        {
            if (QLNV.KT_KhoaChinh_NV(txt_TaiKhoan.Text) != 0)
            {
                MessageBox.Show("Đã tồn tại");
                return;
            }  
            else
            {
                Model.TK_NHANVIEN tknv = new Model.TK_NHANVIEN(txt_TaiKhoan.Text, txt_MatKhau.Text);
                QLNV.ThemTKNV(tknv);
                this.Visible = false;   
            }                              
        }

        private void ThemNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            if (this.Visible == true)
            {
                r = MessageBox.Show("Bạn có muốn thoát!", "CHƯƠNG TRÌNH THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r != DialogResult.OK && this.Visible == true)
                    e.Cancel = true;
                else
                {
                    this.Visible = false;
                    frmNhanVien nv = new frmNhanVien();
                    nv.ShowDialog();
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


    }
}
