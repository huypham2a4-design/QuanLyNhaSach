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
    public partial class ChuongTrinh : Form
    {
        CSDL.Model_NhanVien_QL NV = new CSDL.Model_NhanVien_QL();

        public ChuongTrinh()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        string Madn = "";
        //Lấy dữ mã đăng nhập hiện tại từ form đăng nhập
        public ChuongTrinh (string giatrinhan) : this()
        {
            Madn = giatrinhan;           
            lbl_TenDN.Text = Madn;
          
            Properties.Settings.Default.madn = lbl_TenDN.Text;
            Properties.Settings.Default.Save();                     
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            if (this.Visible == true)
                this.Close();          
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {                     
            DangNhap dn = new DangNhap();
            this.Visible = false;
            dn.ShowDialog();                 
        }

        private void ChuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            if (this.Visible == true)
            {
                r = MessageBox.Show("Bạn có muốn thoát chương trình?", "CHƯƠNG TRÌNH THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r != DialogResult.OK && this.Visible == true)
                    e.Cancel = true;
            }           
        }

        private void Sach_Click(object sender, EventArgs e)
        {
            frmSach frmSach = new frmSach();
            this.Visible = false;
            frmSach.ShowDialog();
        }

        private void LapPN_Click(object sender, EventArgs e)
        {
            frmPhieuNhap pn = new frmPhieuNhap();
            this.Visible = false;
            pn.ShowDialog();
        }

        private void ChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất?", "CHƯƠNG TRÌNH THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //if (DangXuat.CheckState == CheckState.Checked)
            //{
            //    if (r != DialogResult.OK && this.Visible == true)
            //    {
            //        this.Close();
            //    }
            //    else
            //    {
            //        this.Visible = false;
            //        DangNhap frmLG = new DangNhap();
            //        frmLG.ShowDialog();
            //    }
            //}          
        }

        private void ChuongTrinh_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            GiaoDien.Enabled = false;
            
            // Lưu tên đăng nhập hiện tại
            lbl_TenDN.Text = Properties.Settings.Default.madn;

            // Nếu nhân viên đăng nhập thì chức năng Admin sẽ bị ẩn đi tên đăng nhập hiện tại của nhân viên sẽ là màu xanh đen, admin là màu đỏ
            if (Madn.StartsWith("NV"))
            {
                lbl_TenDN.ForeColor = System.Drawing.Color.DarkBlue;
                Admin.Visible = false;
            }
            else
            {
                lbl_TenDN.ForeColor = System.Drawing.Color.Red;
            }              
        }

        private void DoiMatKhau_Click(object sender, EventArgs e)
        {            
            frmDoiMatKhau dmk = new frmDoiMatKhau(Madn);
            dmk.ShowDialog();
        }

        private void KH_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            this.Visible = false;
            kh.ShowDialog();
        }

        private void QL_NV_Click(object sender, EventArgs e)
        {
            frmNhanVien qlnv = new frmNhanVien();
            this.Visible = false;
            qlnv.ShowDialog();
        }

                                        
    }
}
