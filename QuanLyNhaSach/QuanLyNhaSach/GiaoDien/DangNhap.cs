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
    public partial class DangNhap : Form
    {
        // Khai báo CSDL.model_DangNhap để kết nối database
        CSDL.Model_DangNhap dn = new CSDL.Model_DangNhap();

        public DangNhap()
        {
            InitializeComponent();
            this.CenterToScreen();
            //rdo_NhanVien.Checked = true;
        }
               
        private void txt_TaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text.Length == 0)
            {
                errorProvider1.SetError(txt_TaiKhoan, "Vui lòng nhập tài khoản!");
            }
            else
                errorProvider1.SetError(txt_TaiKhoan, null);
        }

        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text.Length == 0)
            {
                errorProvider1.SetError(txt_MatKhau, "Vui lòng nhập mật khẩu!");
            }
            else
                errorProvider1.SetError(txt_MatKhau, null);
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

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Model.TK_NHANVIEN NV = new Model.TK_NHANVIEN();
            Model.TK_QUANLY QL = new Model.TK_QUANLY();

            if (txt_TaiKhoan.Text.Length != 0 && txt_MatKhau.Text.Length != 0)
            {
                //Quyền nhân viên
                if (rdo_NhanVien.Checked)
                {
                    NV.Manv = txt_TaiKhoan.Text;
                    NV.Matkhau = txt_MatKhau.Text;
                    bool kiemtra = dn.kiemtra_nhanvien(NV);            
                    if (kiemtra)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        ChuongTrinh ct = new ChuongTrinh(txt_TaiKhoan.Text);
                        this.Visible = false;
                        ct.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mặt khẩu không chính xác!");
                        //txt_MatKhau.Clear();
                        //txt_TaiKhoan.Clear();
                        txt_TaiKhoan.Focus();
                    }
                }

                //Quyền quản lý
                else if (rdo_QuanLy.Checked)
                {
                    QL.Maql = txt_TaiKhoan.Text;
                    QL.Matkhau = txt_MatKhau.Text;
                    bool kiemtra = dn.kiemtra_quanly(QL);
                    if (kiemtra)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        ChuongTrinh ct = new ChuongTrinh(txt_TaiKhoan.Text);
                        this.Visible = false;
                        ct.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mặt khẩu không chính xác!");
                        //txt_MatKhau.Clear();
                        //txt_TaiKhoan.Clear();
                        txt_TaiKhoan.Focus();
                    }
                }
                else if (rdo_QuanLy.Checked == false || rdo_NhanVien.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn quyền truy cập!");
                    //txt_MatKhau.Clear();
                    //txt_TaiKhoan.Clear();
                    gb_PhanQuyen.Focus();
                }                   
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void btn_DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_DangNhap.PerformClick();
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {         
            DialogResult r;
            if (this.Visible == true)
            {
                r = MessageBox.Show("Bạn có muốn thoát chương trình?", "CHƯƠNG TRÌNH THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r != DialogResult.OK && this.Visible == true)
                    e.Cancel = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGhiNhoTK_CheckedChanged(object sender, EventArgs e)
        {
           
            if (cbGhiNhoTK.Checked && rdo_QuanLy.Checked)
            {
                Properties.Settings.Default.User = txt_TaiKhoan.Text;
                Properties.Settings.Default.Pass = txt_MatKhau.Text;
                Properties.Settings.Default.Save();

            }
            else if (cbGhiNhoTK.Checked && rdo_NhanVien.Checked)
            {
                Properties.Settings.Default.User = txt_TaiKhoan.Text;
                Properties.Settings.Default.Pass = txt_MatKhau.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.User = "";
                Properties.Settings.Default.Pass = "";
                Properties.Settings.Default.Save();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {          
            
                txt_TaiKhoan.Text = Properties.Settings.Default.User;
                txt_MatKhau.Text = Properties.Settings.Default.Pass;
                
                if (Properties.Settings.Default.User != "")
                {
                    cbGhiNhoTK.Checked = true;                   
                }
                
            
            
            
            //rdo_QuanLy.Checked = Properties.Settings.Default.QuyenDN;
         
            //if (Properties.Settings.Default.User != "")
            //{   
            //    cbGhiNhoTK.Checked = true;
            //}
                 
        }                            
    }
}
