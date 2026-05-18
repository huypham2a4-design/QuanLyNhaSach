using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.CSDL;
using QuanLyNhaSach.Model;

namespace QuanLyNhaSach.GiaoDien
{
    public partial class frmHoaDon : Form
    {
        private bool dangThemMoi = false;  // hoặc true tùy mặc định
        Model_HoaDon model = new Model_HoaDon();
        bool isAdding = false;
       
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDSHoaDon();
            LoadComboKhachHang();
            LoadComboNhanVien();
            ResetInputFields();
            lblKhachHang.Visible = false;
            isAdding = false;
        }
        void LoadDSHoaDon()
        {
            try
            {
                DataTable dt = model.LayDSHoaDon();
                dgv_HoaDon.DataSource = dt;

                if (dt.Columns.Contains("NGAYXUATHD"))
                    dgv_HoaDon.Columns["NGAYXUATHD"].HeaderText = "Ngày xuất hóa đơn";

                if (dt.Columns.Contains("TONGTIEN"))
                {
                    dgv_HoaDon.Columns["TONGTIEN"].HeaderText = "Tổng tiền";
                    dgv_HoaDon.Columns["TONGTIEN"].DefaultCellStyle.Format = "N0";
                    dgv_HoaDon.Columns["TONGTIEN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dt.Columns.Contains("PHANTRAMGIAM"))
                {
                    dgv_HoaDon.Columns["PHANTRAMGIAM"].HeaderText = "% Giảm giá";
                    dgv_HoaDon.Columns["PHANTRAMGIAM"].DefaultCellStyle.Format = "P0"; // Hiển thị %
                    dgv_HoaDon.Columns["PHANTRAMGIAM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                foreach (DataGridViewRow row in dgv_HoaDon.Rows)
                {
                    if (row.Cells["PHANTRAMGIAM"].Value != DBNull.Value)
                    {
                        double giam = Convert.ToDouble(row.Cells["PHANTRAMGIAM"].Value);
                        if (giam > 0)
                            row.DefaultCellStyle.BackColor = Color.LightGreen; // Nổi bật hóa đơn có giảm giá
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load hóa đơn: " + ex.Message);
            }
        }
        private void LoadComboKhachHang()
        {
            cbo_makh.DataSource = model.LayDSKhachHang();
            cbo_makh.DisplayMember = "TENKH";  // Hiển thị tên khách hàng
            cbo_makh.ValueMember = "MAKH";      // Giá trị thực sự lưu vào CSDL
            cbo_makh.SelectedIndex = -1;        // Không chọn gì mặc định
        }

        private void LoadComboNhanVien()
        {
            cbonv.DataSource = model.LayDSNhanVien();
            cbonv.DisplayMember = "TENNV";      // Hiển thị tên nhân viên
            cbonv.ValueMember = "MANV";         // Giá trị thực sự lưu vào CSDL
            cbonv.SelectedIndex = -1;           // Không chọn gì mặc định
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            dangThemMoi = true;
            ResetInputFields();
            checkBox1.Checked = false;
            txt_MaHD.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!");
                return;
            }

            if (cbonv.SelectedValue == null || cbonv.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Vui lòng chọn nhân viên!");
                return;
            }
            HoaDon hd = new HoaDon();
            hd.Mahd = txt_MaHD.Text;
            hd.Manv = cbonv.SelectedValue.ToString();
            hd.Ngaynhap = dtpNgay.Value;

            // Xác định khách lẻ hay không
            bool isKhachLe = checkBox1.Checked;

            if (!isKhachLe)
            {
                if (cbo_makh.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng!");
                    return;
                }
                hd.Makh = cbo_makh.SelectedValue.ToString();
            }
            else
            {
                hd.Makh = null;  // ← GÁN NULL CHO KHÁCH LẺ
            }

            Model_HoaDon model = new Model_HoaDon();

            if (dangThemMoi) // đang thêm
            {
                if (model.ThemHoaDon(hd, isKhachLe))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadDSHoaDon();
                    ResetInputFields();
                    dangThemMoi = false;
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
            else // đang sửa
            {
                if (model.CapNhatHoaDon(hd, isKhachLe))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadDSHoaDon();
                    ResetInputFields();
                }
                else
                    MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_HoaDon.CurrentRow != null)
            {
                string mahd = dgv_HoaDon.CurrentRow.Cells["MAHD"].Value.ToString();
                if (model.XoaHoaDon(mahd))
                {
                    MessageBox.Show("Đã xóa!");
                    LoadDSHoaDon();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_HoaDon.Rows[e.RowIndex];

                txt_MaHD.Text = row.Cells["MAHD"].Value?.ToString() ?? "";

                // Xử lý MAKH - kiểm tra NULL
                if (row.Cells["MAKH"].Value != DBNull.Value && !string.IsNullOrEmpty(row.Cells["MAKH"].Value.ToString()))
                {
                    checkBox1.Checked = false;
                    cbo_makh.SelectedValue = row.Cells["MAKH"].Value;
                }
                else
                {
                    checkBox1.Checked = true;  // ← LÀ KHÁCH LẺ (MAKH = NULL)
                    cbo_makh.SelectedIndex = -1;
                }

                // Xử lý MANV
                if (row.Cells["MANV"].Value != DBNull.Value)
                    cbonv.SelectedValue = row.Cells["MANV"].Value;
                else
                    cbonv.SelectedIndex = -1;

                // Xử lý NGAYXUATHD
                if (row.Cells["NGAYXUATHD"].Value != DBNull.Value &&
                    DateTime.TryParse(row.Cells["NGAYXUATHD"].Value.ToString(), out DateTime ngay))
                {
                    dtpNgay.Value = ngay;
                }
                else
                {
                    dtpNgay.Value = DateTime.Now;
                }

                isAdding = false;
            }
        }
        void ResetInputFields()
        {
            txt_MaHD.Clear();
            cbo_makh.SelectedIndex = -1;
            cbonv.SelectedIndex = -1;
            dtpNgay.Value = DateTime.Now;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
           

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true; // NGĂN ĐÓNG FORM
                return;
            }
            ChuongTrinh ct = new ChuongTrinh();
            ct.Show(); // Form cũ vẫn đang mở → 2 form chồng lên nhau!
        }

        private void btnbsct_Click(object sender, EventArgs e)
        {
            if (dgv_HoaDon.CurrentRow != null)
            {
                string mahd = dgv_HoaDon.CurrentRow.Cells["MAHD"].Value.ToString();
                frmChiTietHD f = new frmChiTietHD(mahd);
                f.FormClosed += (s, args) => LoadDSHoaDon();
                f.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Khách lẻ: ẩn combobox khách hàng
                lblKhachHang.Visible = true;
                cbo_makh.Visible = false;
                cbo_makh.SelectedIndex = -1; // bỏ chọn
                                                 // Nếu muốn nhập tên khách lẻ tạm
                                                 // txtTenKhachLe.Visible = true;
            }
            else
            {
                // Khách thường: hiện combobox
                lblKhachHang.Visible = false;
                cbo_makh.Visible = true;
                // txtTenKhachLe.Visible = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv_HoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để sửa!");
                return;
            }
            dangThemMoi = false; // Chỉ cần đặt cái này là đủ
            isAdding = false;
        }
    }
}
