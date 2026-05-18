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

namespace QuanLyNhaSach.GiaoDien
{
    public partial class frmNhanVien : Form
    {
        // Khai báo 
        CSDL.Model_QuanLy_NhanVien QLNV = new CSDL.Model_QuanLy_NhanVien();
        DataSet ds_nv = new DataSet();
        
        // Biến tạm dùng lưu mã nhân viên
        string manv = "";

        public frmNhanVien()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public void LoadtoTextBox()
        {
            txt_MaNV.Text = dgv_NV.CurrentRow.Cells["manv"].Value.ToString();
            txt_TenNV.Text = dgv_NV.CurrentRow.Cells["tennv"].Value.ToString();
            dtp_NgaySinh.Text = dgv_NV.CurrentRow.Cells["ngaysinh"].Value.ToString();
            cbo_GioiTinh.Text = dgv_NV.CurrentRow.Cells["gioitinh"].Value.ToString();
            txt_Cmnd.Text = dgv_NV.CurrentRow.Cells["Cmnd"].Value.ToString();
            txt_DiaChi.Text = dgv_NV.CurrentRow.Cells["diachi"].Value.ToString();
            txt_SDT.Text = dgv_NV.CurrentRow.Cells["sdt"].Value.ToString();
        }

        private void dgv_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadtoTextBox(); 
        }

        // Hàm Load dữ liệu lên DataGridview Nhân viên
        public void load_DVG_NV()
        {
            ds_nv = QLNV.load_dulieuDGV_NV();
            dgv_NV.DataSource = ds_nv.Tables[0];
        }

        // Load dữ liệu lên Form
        public void load()
        {         
            // không cho bấm vào DGV
            dgv_NV.Enabled = false;

            // ẩn dòng cột trên DGV
            dgv_NV.RowHeadersVisible = false;
            dgv_NV.ColumnHeadersVisible = false;
            dgv_NV.Columns[0].Visible = false;
            dgv_NV.Columns[1].Visible = false;
            dgv_NV.Columns[2].Visible = false;
            dgv_NV.Columns[3].Visible = false;
            dgv_NV.Columns[4].Visible = false;
            dgv_NV.Columns[5].Visible = false;
            dgv_NV.Columns[6].Visible = false;

            // Set định dạng ngày tháng năm cho cột ngày sinh trên DGV
            dgv_NV.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Giá trị combobox giới tính
            cbo_GioiTinh.Items.Add("Nam");
            cbo_GioiTinh.Items.Add("Nữ");
            cbo_GioiTinh.Items.Add("Khác");

            set_Cbx_TinhTP();

            // Vô hiệu hoá tất cả các button         
            btn_ThemNV.Enabled = btn_SuaNV.Enabled = btn_XoaNV.Enabled = btn_Moi_NV.Enabled = btn_TimKiem.Enabled = btn_Them_Moi.Enabled = btn_Xong.Enabled = btn_CapNhat.Enabled = false;
            txt_TenMaNV.Enabled = false;
            txt_MaNV.Enabled = txt_TenNV.Enabled = dtp_NgaySinh.Enabled = cbo_GioiTinh.Enabled = txt_Cmnd.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = false;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            load_DVG_NV();
            load();
        }

        private void btn_XemNV_Click(object sender, EventArgs e)
        {
            // Khi bấm vào button xem DS thì Bảng NV, button tìm kiếm và button thêm nhân viên, textbox tìm kiếm có hiệu lực
            //dgv_NV.Enabled = true;
            btn_TimKiem.Enabled = true;
            // btn_Them_Moi.Enabled = true;
            btn_CapNhat.Enabled = true;
            txt_TenMaNV.Enabled = true;

            // Hiển thị lại dòng cột
            dgv_NV.RowHeadersVisible = true;
            dgv_NV.ColumnHeadersVisible = true;
            dgv_NV.Columns[0].Visible = true;
            dgv_NV.Columns[1].Visible = true;
            dgv_NV.Columns[2].Visible = true;
            dgv_NV.Columns[3].Visible = true;
            dgv_NV.Columns[4].Visible = true;
            dgv_NV.Columns[5].Visible = true;
            dgv_NV.Columns[6].Visible = true;


            // Load dữ liệu lên Datagridview
            load_DVG_NV();
            dgv_NV.ReadOnly = true;
            dgv_NV.AllowUserToAddRows = false;

            dgv_NV.ClearSelection(); 
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            if (txt_TenNV.Text.Length == 0 || dtp_NgaySinh.Value == DateTime.Today || cbo_GioiTinh.SelectedItem == null || txt_Cmnd.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin bắt buộc");
                return;
            }          
            else
            {
                if (txt_DiaChi.Text.Length == 0)
                {
                    txt_DiaChi.Text = "Trống";                  
                }
                if (txt_SDT.Text.Length == 0)
                {                  
                    txt_SDT.Text = "0";
                }
                if (dtp_NgaySinh.Value > DateTime.Today)
                {
                    MessageBox.Show("Vui lòng chọn lại ngày!");
                    return;
                }
                if (MessageBox.Show("Bạn Chắn chắn muốn Thêm không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
                if (!KiemTraSDT()) return;
                manv = txt_MaNV.Text;
                ThemNhanVien tknv = new ThemNhanVien(manv);
                tknv.ShowDialog();

                Model.NhanVien nv = new Model.NhanVien();
                nv.Manv = txt_MaNV.Text;
                nv.Tennv = txt_TenNV.Text;
                nv.Ngaysinh = dtp_NgaySinh.Value.ToShortDateString();
                nv.Gioitinh = cbo_GioiTinh.SelectedItem.ToString();
                nv.Cmnd = txt_Cmnd.Text;
                string TinhTP = cbo_TinhTP.SelectedValue.ToString();
                //string QuanHuyen = cbo_QuanHuyen.SelectedValue.ToString();
                nv.Diachi = txt_DiaChi.Text + ", " + TinhTP;           
                nv.Sdt = txt_SDT.Text;

                if (QLNV.ThemNV(nv) != 0)
                {
                    load_DVG_NV();
                    MessageBox.Show("Thêm thành công!");
                    btn_ThemNV.Enabled = false;
                    cbo_GioiTinh.SelectedIndex = -1;
                    dtp_NgaySinh.Value = DateTime.Today;
                    txt_MaNV.Clear();
                    txt_TenNV.Clear();
                    txt_Cmnd.Clear();
                    txt_DiaChi.Clear();
                    txt_SDT.Clear();
                    btn_Them_Moi.Enabled = btn_SuaNV.Enabled = btn_XoaNV.Enabled = true;               
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                    QLNV.XoaNV(nv);
                    btn_SuaNV.Enabled = btn_XoaNV.Enabled = true;
                    btn_Them_Moi.Enabled = false;
                }
               
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (QLNV.KT_KhoaChinh_NV(txt_MaNV.Text) == 0)
            {
                MessageBox.Show("Không thể xoá bởi không tìm thấy Mã nhân viên");
                return;
            }
            if (MessageBox.Show("Bạn Chắn chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            Model.NhanVien nv = new Model.NhanVien();
            nv.Manv = txt_MaNV.Text;
            nv.Tennv = txt_TenNV.Text;
            nv.Ngaysinh = dtp_NgaySinh.Value.ToShortDateString();
            nv.Gioitinh = cbo_GioiTinh.SelectedItem.ToString();
            nv.Cmnd = txt_Cmnd.Text;
            nv.Diachi = txt_DiaChi.Text;
            nv.Sdt = txt_SDT.Text;
            if (QLNV.XoaNV(nv) != 0)
            {
                load_DVG_NV();
                MessageBox.Show("Xóa thành công!");
                cbo_GioiTinh.SelectedIndex = -1;
                dtp_NgaySinh.Value = DateTime.Today;
                txt_MaNV.Clear();
                txt_TenNV.Clear();
                txt_Cmnd.Clear();
                txt_DiaChi.Clear();
                txt_SDT.Clear();
                dgv_NV.ClearSelection();               
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (QLNV.KT_KhoaChinh_NV(txt_MaNV.Text) == 0)
            {
                MessageBox.Show("Không thể sửa bởi không tìm thấy Mã nhân viên");
                return;
            }
            if (!KiemTraSDT()) return;
            if (MessageBox.Show("Bạn chắn chắn muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            Model.NhanVien nv = new Model.NhanVien();
            nv.Manv = txt_MaNV.Text;
            nv.Tennv = txt_TenNV.Text;
            nv.Ngaysinh = dtp_NgaySinh.Value.ToShortDateString();
            nv.Gioitinh = cbo_GioiTinh.SelectedItem.ToString();
            nv.Cmnd = txt_Cmnd.Text;
            nv.Diachi = txt_DiaChi.Text;
            nv.Sdt = txt_SDT.Text;

            if (QLNV.SuaNV(nv) != 0)
            {
                load_DVG_NV();
                MessageBox.Show("Sửa thành công!");
                dgv_NV.ClearSelection();
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

            btn_Them_Moi.Enabled = btn_SuaNV.Enabled = btn_XoaNV.Enabled = true;
            btn_ThemNV.Enabled = false;
            txt_MaNV.ResetText();
            txt_TenNV.ResetText();
            dtp_NgaySinh.Value = DateTime.Today;
            cbo_GioiTinh.SelectedIndex = -1;
            cbo_GioiTinh.ResetText();
            txt_Cmnd.ResetText();
            txt_DiaChi.ResetText();
            txt_SDT.ResetText();

            txt_TenNV.Enabled = dtp_NgaySinh.Enabled = cbo_GioiTinh.Enabled = txt_Cmnd.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = false;

            load_DVG_NV();
            dgv_NV.ClearSelection();                                 
        }

        private void btn_Them_Moi_Click(object sender, EventArgs e)
        {
            btn_ThemNV.Enabled = true;
            btn_SuaNV.Enabled = btn_XoaNV.Enabled = false;
            txt_TenNV.Enabled = dtp_NgaySinh.Enabled = cbo_GioiTinh.Enabled = txt_Cmnd.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = true;
            //+ Cho phép thêm các dòng tiếp theo trên datagridview
            //dgv_NV.AllowUserToAddRows = true;

            //Không được sửa các dòng trên datagridview đã có dữ liệu
            //for (int i = 0; i < dgv_NV.Rows.Count - 1; i++)
            //{
            //    dgv_NV.Rows[i].ReadOnly = true;
            //}
            //dgv_NV.FirstDisplayedScrollingRowIndex = dgv_NV.Rows.Count - 1;
            btn_Them_Moi.Enabled = false;
            cbo_GioiTinh.SelectedIndex = -1;
            dtp_NgaySinh.Value = DateTime.Today;
            txt_MaNV.Clear();
            txt_TenNV.Clear();
            txt_Cmnd.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            txt_TenNV.Focus();

            int count = 0;
            count = dgv_NV.Rows.Count;

            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(dgv_NV.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi1.Remove(0, 2)));

            if (chuoi2 + 1 < 10)
            {
                txt_MaNV.Text = "NV0" + (chuoi2 + 1).ToString();
            }               
            else if (chuoi2 + 1 < 100)
            {
                txt_MaNV.Text = "NV" + (chuoi2 + 1).ToString();
            }
        }

        void timkiemNV()
        {
            DataView dsnv = new DataView(ds_nv.Tables[0]);
            dsnv.RowFilter = " MANV LIKE '%" + txt_TenMaNV.Text.ToString() + "%' OR TENNV LIKE '%" + txt_TenMaNV.Text.ToString() + "%' ";
            dgv_NV.DataSource = dsnv;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            timkiemNV();
            dgv_NV.ClearSelection();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Bạn có muốn cập nhật dữ liệu?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Cancel)
            {                
                return;
            }

            // DGV có hiệu lực, button xong có hiệu lực
            dgv_NV.Enabled = true;
            btn_CapNhat.Enabled = false;
            btn_Xong.Enabled = true;
            txt_TenMaNV.Clear();

            // Xoá tất cả dòng trên TextBox, Combobox, đặt ngày tháng thành ngày hiện tại
            load_DVG_NV();
            LoadtoTextBox();
            txt_TenNV.Enabled = dtp_NgaySinh.Enabled = cbo_GioiTinh.Enabled = txt_Cmnd.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = true;
            btn_Them_Moi.Enabled = true;
            btn_SuaNV.Enabled = true;
            btn_XoaNV.Enabled = true;
            btn_Moi_NV.Enabled = true;
        }

        private void btn_Xong_Click(object sender, EventArgs e)
        {        
            if (MessageBox.Show("Bạn đã cập nhật xong chưa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Cancel)
            {
                btn_CapNhat.Enabled = false;
                btn_Xong.Enabled = true;

                return;
            }

            btn_CapNhat.Enabled = true;
            btn_Xong.Enabled = false;
            load_DVG_NV();
            dgv_NV.ClearSelection();
            dgv_NV.Enabled = false;
            btn_Them_Moi.Enabled = btn_SuaNV.Enabled = btn_XoaNV.Enabled = btn_Moi_NV.Enabled = false;
            txt_TenNV.Enabled = dtp_NgaySinh.Enabled = cbo_GioiTinh.Enabled = txt_Cmnd.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = false;
            
            cbo_GioiTinh.SelectedIndex = -1;
            dtp_NgaySinh.Value = DateTime.Today;
            txt_MaNV.Clear();
            txt_TenNV.Clear();
            txt_Cmnd.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
                    ChuongTrinh ct = new ChuongTrinh();
                    ct.ShowDialog();
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_NV.Enabled == true)
                txt_TenNV.Enabled = dtp_NgaySinh.Enabled = cbo_GioiTinh.Enabled = txt_Cmnd.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = true;
        }

        private void txt_Cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        DataTable dt_TinhTP = new DataTable();
        DataTable dt_QuanHuyen = new DataTable();
        //// Lấy data cho combobox tỉnh thành phố từ database
        public void set_Cbx_TinhTP()
        {
            dt_TinhTP = QLNV.lay_Data_Cbx_TinhTP();
            cbo_TinhTP.DataSource = dt_TinhTP;
            cbo_TinhTP.DisplayMember = "tenTinhThanhPho";
            //cbo_TinhTP.ValueMember = "tentinhthanhpho";
            cbo_TinhTP.ValueMember = "ID";
            cbo_TinhTP.SelectedIndex = -1;
        }

        ////Đổ dữ liệu lên cbx_ke
        //public void set_cbx_QuanHuyen()
        //{
        //    dt_QuanHuyen = QLNV.lay_Data_Cbx_QuanHuyen();
        //    //cbo_QuanHuyen.DataSource = dt_QuanHuyen;
        //    DataView dv = new DataView(dt_QuanHuyen);
        //    dv.RowFilter = " tinhthanhphoid like '%" + cbo_TinhTP.SelectedValue.ToString() + "%' ";
        //    cbo_QuanHuyen.DataSource = dv.ToTable();
        //    cbo_QuanHuyen.DisplayMember = "tenquanhuyen";
        //    cbo_QuanHuyen.ValueMember = "id";
        //    cbo_QuanHuyen.SelectedIndex = -1;
        //}

        //DataSet ds = new DataSet();

        ////Đổ dữ liệu lên dgv_sach khi lọc bằng combobox
        //public void setdata_grv_sach_loc()
        //{
        //    DataView dv1 = new DataView(ds.Tables[0]);
        //    dv1.RowFilter = "id like '%" + cbo_QuanHuyen.SelectedValue.ToString() + "%'";
        //    dgv_NV.DataSource = dv1;

        //}

        private void cbo_TinhTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set_cbx_QuanHuyen();
        }

        private void cbo_QuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //setdata_grv_sach_loc();
        }

        ////Lấy data cho combobox tỉnh thành phố từ database
        //public void set_Cbx_QuanHuyen()
        //{
        //    set_Cbx_TinhTP();
        //    dt_QuanHuyen = QLNV.lay_Data_Cbx_QuanHuyen();
        //    cbo_QuanHuyen.DataSource = dt_QuanHuyen;
        //    cbo_QuanHuyen.DisplayMember = "tenquanhuyen";
        //    cbo_QuanHuyen.ValueMember = "tinhthanhphoID";
        //    //cbo_QuanHuyen.ValueMember = cbo_TinhTP.ValueMember;
        //    cbo_QuanHuyen.SelectedIndex = -1;
        //}
        private bool KiemTraSDT()
        {
            string sdt = txt_SDT.Text.Trim();
            if (sdt.Length != 10 || sdt[0] != '0' || !long.TryParse(sdt, out _))
            {
                MessageBox.Show("Số điện thoại phải đúng 10 chữ số và bắt đầu bằng 0!");
                txt_SDT.Focus();
                return false;
            }
            return true;
        }

    }
}
