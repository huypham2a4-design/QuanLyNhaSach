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
            if (this.Visible == true)
                this.Close();                
        }

        public void setdata_grv_sach()
        {
            dgv_Sach.DataSource = ds_sach.Tables[0];
        }

        //Hiển thị thông tin lên textbox
        void databinding(DataTable b)
        {
            txt_MaSach.DataBindings.Clear();
            txt_TacGia.DataBindings.Clear();
            txt_TenSach.DataBindings.Clear();
            txt_DonGia.DataBindings.Clear();
            txt_TheLoai.DataBindings.Clear();
            txt_SoLuong.DataBindings.Clear();

            txt_MaSach.DataBindings.Add("Text", b, "MaSH");
            txt_TacGia.DataBindings.Add("Text", b, "TenTG");
            txt_TenSach.DataBindings.Add("Text", b, "TenSH");
            txt_DonGia.DataBindings.Add("Text", b, "DonGia");
            txt_TheLoai.DataBindings.Add("Text", b, "TheLoai");
            txt_SoLuong.DataBindings.Add("Text", b, "SoLuong");
                  
        }

        public void load_DVG_Sach()
        {
            ds_sach = sach.load_dulieuDGV_sach();
            dgv_Sach.DataSource = ds_sach.Tables[0];
        }

        public void loadDuLieu()
        {          
            //dgv_muontra.ReadOnly = true;
            //dgv_muontra.AllowUserToAddRows = false;

            //Xoá dòng trống cuối cùng, chỉ đọc
            dgv_Sach.ReadOnly = true;
            dgv_Sach.AllowUserToAddRows = false;

            ////Lấy dữ liệu từ database           
            //ds_muontra = docgia.load_dulieuDGV_muontra(madg);
            //ds_docgia = docgia.load_dulieuDocGia(madg);

            ////Đổ dữ liệu lên datagridview
            //dgv_muontra.DataSource = ds_muontra.Tables[0];
            ////Set định dạng ngày cho cột
            //dgv_muontra.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dgv_muontra.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dgv_muontra.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";

            //databinding(ds_docgia.Tables[0]);

            ds_sach = sach.load_dulieuDGV_sach();
            
            load_DVG_Sach();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void frmSach_FormClosing(object sender, FormClosingEventArgs e)
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


        //Kiểm tra khóa chính bảng sách
        public bool KT_KhoaChinh(string pMa)
        {
            conn.open_connect();
            //Thiet lap chuoi truy van dang hien thi du lieu
            string str = "select * from sach where mash ='" + pMa + "'";
            //Xay dung SqlCommand truy van
            SqlCommand cmd = new SqlCommand(str, conn.get_connect());
            //Goi phuong thuc truy van dang hien thi du lieu
            SqlDataReader rd = cmd.ExecuteReader();
            //Xu ly ket qua
            if (rd.HasRows)
            {
                rd.Close();
                conn.close_connect();
                return false;
            }
            else
            {
                rd.Close();
                conn.close_connect();
                return true;
            }


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaSach.Text == string.Empty || txt_TenSach.Text == string.Empty || txt_TacGia.Text == string.Empty || txt_DonGia.Text == string.Empty || txt_TheLoai.Text == string.Empty || txt_NXB.Text == string.Empty || txt_SoLuong.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                    txt_MaSach.Focus();
                    return;
                }
                if (KT_KhoaChinh(txt_MaSach.Text) == true)
                {
                    conn.open_connect();
                    string insertString;
                    insertString = "insert into Sach values('" + txt_MaSach.Text
                    + "', N'" + txt_TenSach.Text + "',N'" + txt_TacGia.Text + "', N'" + txt_TheLoai.Text + "','" + txt_DonGia.Text + "',N'" + txt_NXB.Text + "', " + txt_SoLuong.Text + ")";
                    SqlCommand cmd = new SqlCommand(insertString, conn.get_connect());
                    cmd.ExecuteNonQuery();
                    conn.close_connect();
                    load_DVG_Sach();
                    MessageBox.Show("Thanh cong");
                }
                else { MessageBox.Show("Trung ma sach"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
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
    

        

       
        
    }
}
