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

            txt_MaKH.Text = dgv_KH.CurrentRow.Cells["makhachhang"].Value.ToString();
            txt_TenKH.Text = dgv_KH.CurrentRow.Cells["tenkhachhang"].Value.ToString();
            cbo_GioiTinh.Text = dgv_KH.CurrentRow.Cells["gioitinh"].Value.ToString();
            txt_DiaChi.Text = dgv_KH.CurrentRow.Cells["diachi"].Value.ToString();
            txt_SDT.Text = dgv_KH.CurrentRow.Cells["sodienthoai"].Value.ToString();
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
            //txt_MaKH.Text = row.Cells["makhachhang"].Value.ToString();
            //txt_TenKH.Text = row.Cells["tenkhachhang"].Value.ToString();
            //cbo_GioiTinh.Text = row.Cells["gioitinh"].Value.ToString();
            //txt_DiaChi.Text = row.Cells["diachi"].Value.ToString();
            //txt_SDT.Text = row.Cells["sodienthoai"].Value.ToString();
            //txt_Email.Text = row.Cells["email"].Value.ToString();

            cbo_GioiTinh.SelectedIndex = -1;
            txt_MaKH.ResetText();
            txt_TenKH.ResetText();
            cbo_GioiTinh.ResetText();
            txt_DiaChi.ResetText();           
            txt_SDT.ResetText();           
            txt_Email.ResetText();          
            load_DVG_KH();
            dgv_KH.ClearSelection();
        }

        //Tìm kiếm khách hàng theo tên khách hàng hoặc mã khách hàng 
        public void setdata_grv_txtSearch()
        {
            DataView dv_Kh = new DataView(ds_kh.Tables[0]);
            dv_Kh.RowFilter = "makhachhang like '%" + txt_TenKhachHang.Text.ToString() + "%' or tenkhachhang like '%" + txt_TenKhachHang.Text.ToString() + "%'";
            dgv_KH.DataSource = dv_Kh;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            setdata_grv_txtSearch();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Không tồn tại");
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
                MessageBox.Show("Khách hàng không tồn tại");
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

                         
    }
}
