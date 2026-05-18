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
    public partial class frmDoiMatKhau : Form
    {
        CSDL.Model_NhanVien_QL TK = new CSDL.Model_NhanVien_QL();

        public frmDoiMatKhau()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        //Lấy mã quản lý từ form đăng nhập
        public frmDoiMatKhau (string giatrinhan) : this()
        {
            txt_TaiKhoan.Text = giatrinhan;
        }
        
        private void frmDoiMatKhau_Load (object sender, EventArgs e)
        {
            txt_TaiKhoan.Enabled = false;
        }

        private void txt_MKCu_Leave(object sender, EventArgs e)
        {
            if (txt_MKCu.Text.Length != 0)
            {
                if (TK.kiemtra_tenDNQL(txt_TaiKhoan.Text))
                {
                    Model.TK_QUANLY ql = new Model.TK_QUANLY();
                    ql.Maql = txt_TaiKhoan.Text;
                    ql.Matkhau = txt_MKCu.Text;

                    if (!TK.kiemtra_MatKhauQL(ql))
                    {
                        errorProvider1.SetError(txt_MKCu, "Mật khẩu cũ không chính xác!");
                    }
                    else
                        errorProvider1.SetError(txt_MKCu, null);   
                }
                else if (TK.kiemtra_tenDNNV(txt_TaiKhoan.Text))
                {
                    Model.TK_NHANVIEN nv = new Model.TK_NHANVIEN();
                    nv.Manv = txt_TaiKhoan.Text;
                    nv.Matkhau = txt_MKCu.Text;

                    if (!TK.kiemtra_MatKhauNV(nv))
                    {
                        errorProvider1.SetError(txt_MKCu, "Mật khẩu cũ không chính xác!");
                    }
                    else
                        errorProvider1.SetError(txt_MKCu, null);
                }          
            }                                                   
        }

        private void txt_MKMoi_Leave(object sender, EventArgs e)
        {
            if (txt_MKMoi.Text.Length == 0)
            {
                errorProvider1.SetError(txt_MKMoi, "Vui lòng nhập mật khẩu mới!");
            }
            else if (txt_MKMoi .Text.Length < 6 && txt_MKMoi.Text.Length > 60)
                errorProvider1.SetError(txt_MKMoi, "Vui lòng không nhập không dưới 6 và không quá 60 kí tự!");
            else
                errorProvider1.SetError(txt_MKMoi, null);
        }

        private void txt_ReMKMoi_Leave(object sender, EventArgs e)
        {
            if (txt_ReMKMoi.Text.Length == 0)
            {
                errorProvider1.SetError(txt_ReMKMoi, "Vui lòng nhập lại mật khẩu mới!");
            }
            else if (!txt_ReMKMoi.Text.Equals(txt_MKMoi.Text))
                errorProvider1.SetError(txt_ReMKMoi, "Mật khẩu nhập lại không đúng!");
            else
                errorProvider1.SetError(txt_ReMKMoi, null);
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txt_MKMoi.Text.Length != 0)
            {
                if (txt_MKMoi.Text.Length < 6 || txt_MKMoi.Text.Length > 60)
                {
                    MessageBox.Show("Mật khẩu phải tối thiếu 6 ký tự và tối đa 60 ký tự!");
                }
                else if (txt_ReMKMoi.Text.Length < 6 || txt_ReMKMoi.Text.Length > 60)
                {
                    MessageBox.Show("Mật khẩu nhập lại phải tối thiếu 6 ký tự và tối đa 60 ký tự!");
                }
                else if (txt_MKCu.Text == txt_MKMoi.Text && txt_MKCu.Text == txt_ReMKMoi.Text)
                {
                    MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ! Vui lòng nhập lại mật khẩu mới!"); ;
                }
                else if (txt_MKMoi.Text != txt_ReMKMoi.Text)
                {
                    errorProvider1.SetError(txt_ReMKMoi, "Mật khẩu nhập lại không đúng!");
                }              
                else if (TK.kiemtra_tenDNQL(txt_TaiKhoan.Text))
                {
                    Model.TK_QUANLY ktql = new Model.TK_QUANLY();
                    ktql.Maql = txt_TaiKhoan.Text;
                    ktql.Matkhau = txt_MKCu.Text;
                    if (!TK.kiemtra_MatKhauQL(ktql))
                    {
                        errorProvider1.SetError(txt_MKCu, "Mật khẩu cũ không chính xác!");
                    }
                    else
                    {
                        Model.TK_QUANLY ql = new Model.TK_QUANLY();
                        ql.Maql = txt_TaiKhoan.Text;
                        ql.Matkhau = txt_MKMoi.Text;

                        int check = TK.capnhat_MatKhauQL(ql);
                        if (check != 0)
                        {
                            MessageBox.Show("Cập nhật mật khẩu thành công!");
                            txt_MKCu.Clear();
                            txt_MKMoi.Clear();
                            txt_ReMKMoi.Clear();
                            this.Visible = false;
                        }
                        else
                            MessageBox.Show("Cập nhật mật khẩu không thành công!");
                    }                                                                                                                                   
                }
                else if (TK.kiemtra_tenDNNV(txt_TaiKhoan.Text))
                {
                   Model.TK_NHANVIEN ktnv = new Model.TK_NHANVIEN();
                   ktnv.Manv = txt_TaiKhoan.Text;
                   ktnv.Matkhau = txt_MKCu.Text;
                   if (!TK.kiemtra_MatKhauNV(ktnv))
                   {
                       errorProvider1.SetError(txt_MKCu, "Mật khẩu cũ không chính xác!");
                   }
                   else
                   {
                       Model.TK_NHANVIEN nv = new Model.TK_NHANVIEN();
                       nv.Manv = txt_TaiKhoan.Text;
                       nv.Matkhau = txt_MKMoi.Text;

                       int check = TK.capnhat_MatKhauNV(nv);
                       if (check != 0)
                       {
                           MessageBox.Show("Cập nhật mật khẩu thành công!");
                           txt_MKCu.Clear();
                           txt_MKMoi.Clear();
                           txt_ReMKMoi.Clear();
                           this.Visible = false;
                       }
                       else
                           MessageBox.Show("Cập nhật mật khẩu không thành công!");
                   }              
                 }                 
            }           
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void frmDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            if (this.Visible == true)
            {
                r = MessageBox.Show("Bạn có muốn thoát ?", "CHƯƠNG TRÌNH THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r != DialogResult.OK && this.Visible == true)
                    e.Cancel = true;
                else
                {
                    this.Hide(); 
                }
            }
        }
        
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();                  
        }

        private void btnDoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoi.PerformClick();
            }
        }
    }
}
