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
    public partial class frmKhachHang : Form
    {
        // Khai báo 
        CSDL.Model_KhachHang kh = new CSDL.Model_KhachHang();
        DataSet ds_kh = new DataSet();

        public frmKhachHang()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

       
        // Hàm Load dữ liệu lên DataGridview Khách hàng
        public void load_DVG_KH()
        {
            ds_kh = kh.load_dulieuDGV_KH();
            dgv_KH.DataSource = ds_kh.Tables[0];
        }


        // Load dữ liệu
        public void load()
        {
            //Xoá dòng trống cuối cùng, chỉ đọc
            dgv_KH.ReadOnly = true;
            dgv_KH.AllowUserToAddRows = false;           
                           
            ds_kh = kh.load_dulieuDGV_KH();
          
            // Dùng vòng lặp
            //string[] gt = { "Nam", "Nữ", "Khác" };
            //foreach (string s in gt)
            //{
            //    cbo_GioiTinh.Items.Add(s); //thêm item vào combobox
            //}

            cbo_GioiTinh.Items.Add("Nam");
            cbo_GioiTinh.Items.Add("Nữ");
            cbo_GioiTinh.Items.Add("Khác");

            load_DVG_KH();
            dgv_KH.ClearSelection();
            btn_Moi_KH.Enabled = false;

            // không cho bấm vào DGV
            dgv_KH.Enabled = false;

            // ẩn dòng cột trên DGV
            dgv_KH.RowHeadersVisible = false;
            dgv_KH.ColumnHeadersVisible = false;
            dgv_KH.Columns[0].Visible = false;
            dgv_KH.Columns[1].Visible = false;
            dgv_KH.Columns[2].Visible = false;
            dgv_KH.Columns[3].Visible = false;
            dgv_KH.Columns[4].Visible = false;
            dgv_KH.Columns[5].Visible = false;
                                     
            // Vô hiệu hoá tất cả các button         
            btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Moi_KH.Enabled = btn_TimKiem.Enabled = btn_Them_Moi.Enabled = btn_Xong.Enabled = btn_CapNhat.Enabled = false;
            txt_MaKH.Enabled = false;
            txt_TenKhachHang.Enabled = txt_TenKH.Enabled = cbo_GioiTinh.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = txt_Email.Enabled = false;
        }
        
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgv_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Moi_KH.Enabled = true;
            txt_MaKH.DataBindings.Clear();
            txt_TenKH.DataBindings.Clear();
            cbo_GioiTinh.DataBindings.Clear();
            txt_DiaChi.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();
            txt_Email.DataBindings.Clear();

            txt_MaKH.Text = dgv_KH.CurrentRow.Cells["makh"].Value.ToString();
            txt_TenKH.Text = dgv_KH.CurrentRow.Cells["tenkh"].Value.ToString();
            cbo_GioiTinh.Text = dgv_KH.CurrentRow.Cells["gioitinh"].Value.ToString();
            txt_DiaChi.Text = dgv_KH.CurrentRow.Cells["diachi"].Value.ToString();
            txt_SDT.Text = dgv_KH.CurrentRow.Cells["sdt"].Value.ToString();
            txt_Email.Text = dgv_KH.CurrentRow.Cells["email"].Value.ToString();                
        }
     
        private void btn_Chon_Click(object sender, EventArgs e)
        {
            //int index = dgv_KH.CurrentRow.Index;
            dgv_KH.CurrentRow.Cells[0].Value.ToString();

            //this.Close();
        }

        private void btn_Moi_KH_Click(object sender, EventArgs e)
        {
                   
            if (MessageBox.Show("Bạn chắn chắn muốn làm mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            btn_Them_Moi.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = true;
            btn_Them.Enabled = false;

            cbo_GioiTinh.SelectedIndex = -1;
            txt_MaKH.ResetText();
            txt_TenKH.ResetText();
            cbo_GioiTinh.ResetText();
            txt_DiaChi.ResetText();
            txt_SDT.ResetText();
            txt_Email.ResetText();

            //txt_TenKH.Enabled = cbo_GioiTinh.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = txt_Email.Enabled = false;

            load_DVG_KH();
            dgv_KH.ClearSelection();   
        }

        //Tìm kiếm khách hàng theo tên khách hàng hoặc mã khách hàng 
        public void setdata_grv_txtSearch()
        {
            DataView dv_Kh = new DataView(ds_kh.Tables[0]);
            dv_Kh.RowFilter = "makh like '%" + txt_TenKhachHang.Text.ToString() + "%' or tenkh like '%" + txt_TenKhachHang.Text.ToString() + "%'";
            dgv_KH.DataSource = dv_Kh;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            setdata_grv_txtSearch();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (  
                !ValidateSDT() || !ValidateEmail())
                return;
            if (txt_MaKH.Text.Length == 0 || txt_TenKH.Text.Length == 0 || cbo_GioiTinh.SelectedItem == null || txt_DiaChi.Text.Length == 0 || txt_SDT.Text.Length == 0 || txt_Email.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
                return;
            }
            else if (kh.KT_KhoaChinh(txt_MaKH.Text) != 0)
            {
                MessageBox.Show("Mã Khách hàng này đã tồn tại!");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn chắn chắn muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                Model.KhachHang a = new Model.KhachHang();
                a.Makh = txt_MaKH.Text;               
                a.Tenkh = txt_TenKH.Text;
                a.Gioitinh = cbo_GioiTinh.SelectedItem.ToString();
                a.Diachi = txt_DiaChi.Text;               
                a.Sdt = txt_SDT.Text;
                a.Email = txt_Email.Text;
              
                if (kh.ThemKH(a) != 0)
                {
                    load_DVG_KH(); 
                    MessageBox.Show("Thêm thành công!");
                    txt_MaKH.Clear();
                    txt_TenKH.Clear();
                    cbo_GioiTinh.SelectedIndex = -1;
                    txt_DiaChi.Clear();
                    txt_SDT.Clear();
                    txt_Email.Clear();   
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
        }
            
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (kh.KT_KhoaChinh(txt_MaKH.Text) == 0)
            {
                MessageBox.Show("Mã Khách Hàng không có không thể sửa thông tin!");
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn chắn chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                Model.KhachHang a = new Model.KhachHang();
                a.Makh = txt_MaKH.Text;
                a.Tenkh = txt_TenKH.Text;
                a.Gioitinh = cbo_GioiTinh.SelectedItem.ToString();
                a.Diachi = txt_DiaChi.Text;
                a.Sdt = txt_SDT.Text;
                a.Email = txt_Email.Text;

                if (kh.capNhatKH(a) != 0)
                {
                    load_DVG_KH();
                    MessageBox.Show("Sửa thành công!");
                    dgv_KH.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (kh.KT_KhoaChinh(txt_MaKH.Text) == 0)
            {
                MessageBox.Show("Mã Khách hàng không có nên không có thông tin để xoá");
                return;
            }
            if (MessageBox.Show("Bạn Chắn chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            Model.KhachHang a = new Model.KhachHang();
            a.Makh = txt_MaKH.Text;

            if (kh.xoaKH(a) != 0)
            {
                load_DVG_KH();
                MessageBox.Show("Xóa thành công!");
                dgv_KH.ClearSelection();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_XemNV_Click(object sender, EventArgs e)
        {
            // Khi bấm vào button xem DS thì Bảng NV, button tìm kiếm và button thêm nhân viên, textbox tìm kiếm có hiệu lực
            //dgv_NV.Enabled = true;
            btn_TimKiem.Enabled = true;
            // btn_Them_Moi.Enabled = true;
            btn_CapNhat.Enabled = true;
            txt_TenKhachHang.Enabled = true;

            // Hiển thị lại dòng cột         
            dgv_KH.RowHeadersVisible = true;
            dgv_KH.ColumnHeadersVisible = true;
            dgv_KH.Columns[0].Visible = true;
            dgv_KH.Columns[1].Visible = true;
            dgv_KH.Columns[2].Visible = true;
            dgv_KH.Columns[3].Visible = true;
            dgv_KH.Columns[4].Visible = true;
            dgv_KH.Columns[5].Visible = true;

            // Load dữ liệu lên Datagridview
            load_DVG_KH();
            dgv_KH.ReadOnly = true;
            dgv_KH.AllowUserToAddRows = false;
          
            dgv_KH.ClearSelection(); 
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật dữ liệu?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            // DGV có hiệu lực, button xong có hiệu lực
            dgv_KH.Enabled = true;
            btn_CapNhat.Enabled = false;
            btn_Xong.Enabled = true;
            txt_TenKhachHang.Clear();

            // Xoá tất cả dòng trên TextBox, Combobox, đặt ngày tháng thành ngày hiện tại
            load_DVG_KH();

            txt_MaKH.Text = dgv_KH.CurrentRow.Cells["makh"].Value.ToString();
            txt_TenKH.Text = dgv_KH.CurrentRow.Cells["tenkh"].Value.ToString();
            cbo_GioiTinh.Text = dgv_KH.CurrentRow.Cells["gioitinh"].Value.ToString();
            txt_DiaChi.Text = dgv_KH.CurrentRow.Cells["diachi"].Value.ToString();
            txt_SDT.Text = dgv_KH.CurrentRow.Cells["sdt"].Value.ToString();
            txt_Email.Text = dgv_KH.CurrentRow.Cells["email"].Value.ToString(); 
 
            txt_TenKH.Enabled = cbo_GioiTinh.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = txt_Email.Enabled = true;
            btn_Them_Moi.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Moi_KH.Enabled = true;
        }

        private void btn_Them_Moi_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Sua.Enabled = btn_Xoa.Enabled = false;
            txt_TenKH.Enabled = cbo_GioiTinh.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = txt_Email.Enabled = true;
            
            btn_Them_Moi.Enabled = false;
            cbo_GioiTinh.SelectedIndex = -1;            
            txt_MaKH.Clear();
            txt_TenKH.Clear();        
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            txt_Email.Clear();
            txt_TenKH.Focus();

            int count = 0;
            count = dgv_KH.Rows.Count;

            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(dgv_KH.Rows[count - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi1.Remove(0, 2)));

            if (chuoi2 + 1 < 10)
            {
                txt_MaKH.Text = "KH00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txt_MaKH.Text = "KH0" + (chuoi2 + 1).ToString();
            }
        }

        private void dgv_KH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_KH.Enabled == true)
                txt_TenKH.Enabled = cbo_GioiTinh.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = txt_Email.Enabled = true;
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
            load_DVG_KH();
            dgv_KH.ClearSelection();
            dgv_KH.Enabled = false;
            btn_Them_Moi.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = btn_Moi_KH.Enabled = false;
            txt_TenKH.Enabled = cbo_GioiTinh.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = txt_Email.Enabled = false;

            cbo_GioiTinh.SelectedIndex = -1;
            txt_MaKH.Clear();
            txt_TenKH.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            txt_Email.Clear();       
        }
        private bool ValidateSDT()
        {
            string sdt = txt_SDT.Text.Trim();
            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                txt_SDT.Focus();
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^0[1-9]\d{8,9}$"))
            {
                MessageBox.Show("Số điện thoại phải là số Việt Nam hợp lệ (10 hoặc 11 số, bắt đầu bằng 0)!");
                txt_SDT.Focus();
                return false;
            }
            return true;
        }
        private bool ValidateEmail()
        {
            string email = txt_Email.Text.Trim();
            if (string.IsNullOrEmpty(email)) return true; // cho phép trống

            if (!System.Text.RegularExpressions.Regex.IsMatch(email,
                @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            {
                MessageBox.Show("Email không hợp lệ! Ví dụ đúng: abc@example.com");
                txt_Email.Focus();
                return false;
            }
            return true;
        }

        private void txt_SDT_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
