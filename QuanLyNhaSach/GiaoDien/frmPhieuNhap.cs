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
    public partial class frmPhieuNhap : Form
    {
        CSDL.Model_PhieuNhap pn = new CSDL.Model_PhieuNhap();
        DataSet ds_pn = new DataSet();
        DataTable dtNCC;
        string mapn = "";
        public frmPhieuNhap()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

    
        private void load()
        {
            Load_cboNcc();

            dgv_DSPN.ReadOnly = true;
            dgv_DSPN.AllowUserToAddRows = false;

          
            dgv_DSPN.Visible = false;

            

            dgv_DSPN.ClearSelection();

            
            btn_Moi_PN.Enabled = true;

        }
        public void Load_cboNcc()
        {
            dtNCC = pn.load_Cbo_ncc();

            if (dtNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có nhà cung cấp nào trong CSDL!");
                return;
            }

            // Thêm dòng trống vào đầu
            DataRow dr = dtNCC.NewRow();
            dr["MaNCC"] = "";
            dr["TenNCC"] = "-- Chọn nhà cung cấp --";
            dtNCC.Rows.InsertAt(dr, 0);

            cbo_mancc.DataSource = dtNCC;
            cbo_mancc.DisplayMember = "TenNCC";
            cbo_mancc.ValueMember = "MaNCC";
            cbo_mancc.SelectedIndex = 0;


        }
        public void load_DVG_PN()
        {
            ds_pn = pn.load_dulieuDGV_PN();
            dgv_DSPN.DataSource = ds_pn.Tables[0];
        }

        private void frmPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát!", "CHƯƠNG TRÌNH THÔNG BÁO",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.No)
            {
                e.Cancel = true; 
                return;
            }

            ChuongTrinh ct = new ChuongTrinh();
            ct.Show();  
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNhap.Text))
            {
                MessageBox.Show("Chưa nhập Mã phiếu nhập!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_manv.Text))
            {
                MessageBox.Show("Chưa nhập Mã nhân viên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manv.Focus();
                return;
            }

            if (cbo_mancc.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn Nhà cung cấp!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo_mancc.Focus();
                return;
            }
            else if (pn.KT_KhoaChinh_PN(txt_MaNhap.Text) != 0)
            {
                MessageBox.Show("Mã Phiếu này đã tồn tại!");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn chắn chắn muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                Model.PhieuNhap a = new Model.PhieuNhap();
                a.Mapn = txt_MaNhap.Text;
                a.Manv = txt_manv.Text;
                a.Mancc = cbo_mancc.SelectedValue.ToString();
                a.Ngaynhap = dtpNgay.Value.ToString("yyyy-MM-dd");

                if (pn.ThemPhieuNhap(a) != 0)
                {
                    load_DVG_PN();
                    MessageBox.Show("Thêm thành công!");
                    txt_MaNhap.Clear();
                    txt_manv.Clear();
                    cbo_mancc.SelectedIndex = 1;
                    dtpNgay.Value = DateTime.Today;

                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (pn.KT_KhoaChinh_PN(txt_MaNhap.Text) == 0)
            {
                MessageBox.Show("Không tồn tại");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn chắn chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                Model.PhieuNhap a = new Model.PhieuNhap();
                a.Mapn = txt_MaNhap.Text;
                a.Manv = txt_manv.Text;
                a.Mancc = cbo_mancc.SelectedValue.ToString();
                a.Ngaynhap = dtpNgay.Value.ToString("yyyy-MM-dd");

                if (pn.capNhatPN(a) != 0)
                {
                    load_DVG_PN();
                    MessageBox.Show("Sửa thành công!");
                    dgv_DSPN.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (pn.KT_KhoaChinh_PN(txt_MaNhap.Text) == 0)
            {
                MessageBox.Show("Khách hàng không tồn tại");
                return;
            }
            if (MessageBox.Show("Bạn Chắn chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            Model.PhieuNhap a = new Model.PhieuNhap();
            a.Mapn = txt_MaNhap.Text;

            if (pn.xoaPN(a) != 0)
            {
                load_DVG_PN();
                MessageBox.Show("Xóa thành công!");
                dgv_DSPN.ClearSelection();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btn_Moi_PN_Click(object sender, EventArgs e)
        {
            txt_MaNhap.ResetText();
            txt_manv.ResetText();
            cbo_mancc.SelectedIndex = 0;
            dtpNgay.Value = DateTime.Today;

            // Load dữ liệu từ database
            ds_pn = pn.load_dulieuDGV_PN();
            dgv_DSPN.DataSource = ds_pn.Tables[0];

            // Hiển thị DGV
            dgv_DSPN.Visible = true;

            dgv_DSPN.ClearSelection();
        }

        private void btnbsct_Click(object sender, EventArgs e)
        {
            frmChiTietPN ctpn = new frmChiTietPN(txt_MaNhap.Text);
            ctpn.ShowDialog();
        }

        private void dgv_DSPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Moi_PN.Enabled = true;
            txt_MaNhap.DataBindings.Clear();
            txt_manv.DataBindings.Clear();
            cbo_mancc.DataBindings.Clear();
            dtpNgay.DataBindings.Clear();

            txt_MaNhap.Text = dgv_DSPN.CurrentRow.Cells["mapn"].Value.ToString();
            txt_manv.Text = dgv_DSPN.CurrentRow.Cells["manv"].Value.ToString();
            cbo_mancc.SelectedValue = dgv_DSPN.CurrentRow.Cells["mancc"].Value.ToString();
            dtpNgay.Text = dgv_DSPN.CurrentRow.Cells["ngaynhap"].Value.ToString();
        }

       

        private void frmPhieuNhap_Load_1(object sender, EventArgs e)
        {
            dgv_DSPN.Visible = false;

            // Load danh sách nhà cung cấp
            Load_cboNcc();

            // Thiết lập DGV
            dgv_DSPN.ReadOnly = true;
            dgv_DSPN.AllowUserToAddRows = false;

            btn_Moi_PN.Enabled = true;

        }

        private void btnbsct_Click_1(object sender, EventArgs e)
        {
            if (dgv_DSPN.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập trước khi xem chi tiết!");
                return;
            }

            string maPN = dgv_DSPN.CurrentRow.Cells["mapn"].Value.ToString();

            // Truyền maPN vào constructor
            frmChiTietPN ctpn = new frmChiTietPN(maPN);
            ctpn.ShowDialog();

        }
    }
}
