using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhaSach.Model;

namespace QuanLyNhaSach.GiaoDien
{
    public partial class frmSach : Form
    {
        CSDL.Connect_DB conn = new CSDL.Connect_DB();
        CSDL.Model_Sach sach = new CSDL.Model_Sach();       

        DataSet QL_NHASACH = new DataSet();
        DataSet ds_sach = new DataSet();

        public frmSach()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            
            this.Close();

        }

        public void setdata_grv_sach()
        {
            dgv_Sach.DataSource = ds_sach.Tables[0];
        }

       
        public void load_DVG_Sach()
        {
            ds_sach = sach.load_dulieuDGV_sach();
            dgv_Sach.DataSource = ds_sach.Tables[0];
        }
        public void LoadtoTextBox()
        {
            //txt_MaSach.DataBindings.Clear();
            //txt_TenSach.DataBindings.Clear();
            //txt_TheLoai.DataBindings.Clear();
            //txt_NXB.DataBindings.Clear();
            //txt_TacGia.DataBindings.Clear();
            //txt_SoLuong.DataBindings.Clear();
            //txt_DonGia.DataBindings.Clear();

            txt_MaSach.Text = dgv_Sach.CurrentRow.Cells["mash"].Value.ToString();
            txt_TenSach.Text = dgv_Sach.CurrentRow.Cells["tensh"].Value.ToString();
            txt_TheLoai.Text = dgv_Sach.CurrentRow.Cells["theloai"].Value.ToString();
            cbo_NXB.Text = dgv_Sach.CurrentRow.Cells["tennxb"].Value.ToString();
            cbo_TacGia.Text = dgv_Sach.CurrentRow.Cells["tentgchinh"].Value.ToString();
            txt_SoLuong.Text = dgv_Sach.CurrentRow.Cells["sltonkho"].Value.ToString();
            txt_DonGia.Text = dgv_Sach.CurrentRow.Cells["gia"].Value.ToString();
            cbo_MaKho.Text = dgv_Sach.CurrentRow.Cells["tenkho"].Value.ToString();
        }

        public void loadDuLieu()
        {
            //dgv_muontra.ReadOnly = true;
            //dgv_muontra.AllowUserToAddRows = false;

            //Xoá dòng trống cuối cùng, chỉ đọc
            dgv_Sach.ReadOnly = true;
            dgv_Sach.AllowUserToAddRows = false;

            ds_sach = sach.load_dulieuDGV_sach();
            set_Cbx_TacGia();
            set_Cbx_Kho();
            set_Cbx_NXB();
            load_DVG_Sach();
            cbo_NXB.SelectedIndex = -1;
            cbo_TacGia.SelectedIndex = -1;
            cbo_MaKho.SelectedIndex = -1;
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            dgv_Sach.CellDoubleClick += dgv_Sach_CellDoubleClick;
        }

        private void frmSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK) // Nếu không phải chọn sách
            {
                DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                {
                    e.Cancel = true; // Hủy đóng form
                }
                else
                {
                    // Chỉ mở trang chủ khi thực sự thoát
                  

                }
            }
        }

        DataTable dt_NXB;
        DataTable dt_tg;
        DataTable dt_kho;

        //Lấy data cho combobox tác giả từ database
        public void set_Cbx_NXB()
        {
            dt_NXB = sach.lay_Data_Cbx_NXB();
            cbo_NXB.DataSource = dt_NXB;
            cbo_NXB.DisplayMember = "tennxb";
            cbo_NXB.ValueMember = "manxb";
            cbo_NXB.SelectedIndex = 0;
        }

        //Lấy data cho combobox tác giả từ database
        public void set_Cbx_TacGia()
        {
            dt_tg = sach.lay_Data_Cbx_MaTGC();
            cbo_TacGia.DataSource = dt_tg;
            cbo_TacGia.DisplayMember = "tentgchinh";
            cbo_TacGia.ValueMember = "MAtgchinh";
            cbo_TacGia.SelectedIndex = 0;
        }

        //Lấy data cho combobox tác giả từ database
        public void set_Cbx_Kho()
        {
            dt_kho = sach.lay_Data_Cbx_MaKho();
            cbo_MaKho.DataSource = dt_kho;
            cbo_MaKho.DisplayMember = "tenkho";
            cbo_MaKho.ValueMember = "MAkho";
            cbo_MaKho.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txt_MaSach.Text.Length == 0 || txt_TenSach.Text.Length == 0 || txt_TheLoai.Text.Length == 0 || txt_DonGia.Text.Length == 0 || txt_SoLuong.Text.Length == 0 || cbo_NXB.SelectedValue == null || cbo_TacGia.SelectedValue == null || cbo_MaKho.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
                return;
            }
            else if (sach.KT_KhoaChinh(txt_MaSach.Text) != 0)
            {
                MessageBox.Show("Mã sách này đã tồn tại!");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn chắn chắn muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                Model.Sach a = new Model.Sach();
                a.Mash = txt_MaSach.Text;
                a.Tensh = txt_TenSach.Text;
                a.Theloai = txt_TheLoai.Text;
                a.Dongia = txt_DonGia.Text;
                a.Soluong = txt_SoLuong.Text;
                a.Nxb = cbo_NXB.SelectedValue.ToString();
                a.Tacgia = cbo_TacGia.SelectedValue.ToString();
                a.Makho = cbo_MaKho.SelectedValue.ToString();

                if (sach.ThemSach(a) != 0)
                {
                    load_DVG_Sach();
                    MessageBox.Show("Thêm thành công!");
                    txt_MaSach.Clear();
                    txt_TenSach.Clear();
                    txt_TheLoai.Clear();
                    txt_DonGia.Clear();
                    cbo_NXB.SelectedIndex = -1;
                    cbo_TacGia.SelectedIndex = -1;
                    cbo_MaKho.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }

        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (sach.KT_KhoaChinh(txt_MaSach.Text) == 0)
            {
                MessageBox.Show("Sách không tồn tại");
                return;
            }
            if (MessageBox.Show("Bạn Chắn chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            Model.Sach a = new Model.Sach();

            a.Mash = txt_MaSach.Text;

            if (sach.xoaSach(a) != 0)
            {
                load_DVG_Sach();
                MessageBox.Show("Xóa thành công!");
                dgv_Sach.ClearSelection();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void dgv_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadtoTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (sach.KT_KhoaChinh(txt_MaSach.Text) == 0)
            {
                MessageBox.Show("Không thể sửa bởi không tìm thấy Mã nhân viên");
                return;
            }
            if (MessageBox.Show("Bạn chắn chắn muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            Model.Sach a = new Model.Sach();
            a.Mash = txt_MaSach.Text;
            a.Tensh = txt_TenSach.Text;
            a.Theloai = txt_TheLoai.Text;
            a.Dongia = txt_DonGia.Text;
            a.Soluong = txt_SoLuong.Text;
            a.Nxb = cbo_NXB.SelectedValue.ToString();
            a.Tacgia = cbo_TacGia.SelectedValue.ToString();
            a.Makho = cbo_MaKho.SelectedValue.ToString();

            if (sach.capNhatSach(a) != 0)
            {
                load_DVG_Sach();
                MessageBox.Show("Sửa thành công!");
                dgv_Sach.ClearSelection();
                //txt_MaNV.Clear();
                //txt_TenNV.Clear();
                //cbo_GioiTinh.SelectedIndex = -1;
                //txt_Cmnd.Clear();
                //txt_DiaChi.Clear();
                //txt_SDT.Clear();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void btn_Moi_NV_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn chắn chắn muốn làm mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            btn_Sua.Enabled = btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;

            txt_MaSach.ResetText();
            txt_TenSach.ResetText();
            txt_TheLoai.ResetText();
            cbo_NXB.SelectedIndex = -1;
            cbo_TacGia.SelectedIndex = -1;
            cbo_MaKho.SelectedIndex = -1;
            txt_SoLuong.ResetText();
            txt_DonGia.ResetText();

            load_DVG_Sach();
            dgv_Sach.ClearSelection();  
        }
       
        //Tìm kiếm sách theo tên sách 
        public void setdata_grv_txtSearch()
        {
            DataView dv_sh = new DataView(ds_sach.Tables[0]);
            dv_sh.RowFilter = "tensh like '%" + txt_TimKiem.Text.ToString() + "%' ";
            dgv_Sach.DataSource = dv_sh;
        }

        //DataTable dt_sach;

        ////Lấy data cho combobox kệ từ database
        //public void set_Cbx_TheLoai()
        //{
        //    dt_sach = sach.lay_Data_Cbx_TheLoai();
        //    DataView dv = new DataView(dt_sach);
        //    dv.RowFilter = "THeloai like '%" + cbTimTheLoai.SelectedValue.ToString() + "%'";
        //    cbTimTheLoai.DataSource = dv;
        //    cbTimTheLoai.DisplayMember = "THELOAI";
        //    cbTimTheLoai.ValueMember = "THELOAI";
        //}


        //private void cbTimTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    set_Cbx_TheLoai();
        //}

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            setdata_grv_txtSearch();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void txt_TenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Sach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            LoadtoTextBox();
        }

        public string SelectedMaSach { get; private set; }
        private void dgv_Sach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedMaSach = dgv_Sach.Rows[e.RowIndex].Cells["mash"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txt_SoLuong_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_SoLuong.Text))
            {
                if (int.TryParse(txt_SoLuong.Text, out int soLuong))
                {
                    if (soLuong < 0)
                    {
                        MessageBox.Show("Số lượng không được âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_SoLuong.Focus();
                        txt_SoLuong.SelectAll();
                        // Có thể đặt lại về 0 hoặc giá trị cũ
                        txt_SoLuong.Text = "1";
                    }
                }
                else
                {
                    // Nếu không parse được (trường hợp hiếm do đã chặn ở KeyPress)
                    txt_SoLuong.Text = "1";
                }
            }
            else
            {
                // Nếu để trống thì mặc định về 0
                txt_SoLuong.Text = "1";
            }
        }

        private void txt_DonGia_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_DonGia.Text))
            {
                // Thử parse thành decimal hoặc int tùy kiểu dữ liệu bạn dùng cho cột "gia" trong DB
                if (decimal.TryParse(txt_DonGia.Text, out decimal donGia))
                {
                    if (donGia < 0)
                    {
                        MessageBox.Show("Đơn giá không được âm!", "Lỗi nhập liệu",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_DonGia.Focus();
                        txt_DonGia.SelectAll();
                        txt_DonGia.Text = "0";  // hoặc "10000" nếu muốn giá trị mặc định hợp lý
                    }
                }
                else
                {
                    // Nếu nhập lung tung (hiếm vì đã chặn KeyPress)
                    MessageBox.Show("Đơn giá phải là số hợp lệ!", "Lỗi nhập liệu",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_DonGia.Focus();
                    txt_DonGia.SelectAll();
                    txt_DonGia.Text = "0";
                }
            }
            else
            {
                // Nếu để trống thì mặc định về 0 hoặc một giá trị hợp lý
                txt_DonGia.Text = "0";
                MessageBox.Show("Đơn giá không được để trống, đã đặt về 0.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
