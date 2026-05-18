using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyNhaSach.GiaoDien
{
    public partial class frmQuyDinh : Form
    {
        public class QuyDinh
        {
            public string LuongSach { get; set; }
            public string Ton1 { get; set; }
            public string Ton2 { get; set; }
            public string No { get; set; }

            private static string filePath = "quydinh.txt";

            public QuyDinh()
            {
                // Gán mặc định
                LuongSach = "10";
                Ton1 = "30";
                Ton2 = "20";
                No = "300.000 VND";
            }

            // Lưu dữ liệu vào file
            public void Luu()
            {
                File.WriteAllText(filePath, $"{LuongSach}\n{Ton1}\n{Ton2}\n{No}");
            }

            // Đọc dữ liệu từ file (nếu có)
            public void Doc()
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    if (lines.Length >= 4)
                    {
                        LuongSach = lines[0];
                        Ton1 = lines[1];
                        Ton2 = lines[2];
                        No = lines[3];
                    }
                }
            }
        }
        private QuyDinh quydinh; // Tạo biến chứa dữ liệu

        public frmQuyDinh()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            quydinh = new QuyDinh();
            quydinh.Doc(); // Đọc dữ liệu từ file nếu có

            // Gán lên textbox
            txtLuongSach.Text = quydinh.LuongSach;
            txtTon1.Text = quydinh.Ton1;
            txtTon2.Text = quydinh.Ton2;
            txtNo.Text = quydinh.No;
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuyDinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát!",
                "CHƯƠNG TRÌNH THÔNG BÁO",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);

            if (r != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                this.Visible = false;
                ChuongTrinh ct = new ChuongTrinh();
                ct.ShowDialog();
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            quydinh.LuongSach = txtLuongSach.Text;
            quydinh.Ton1 = txtTon1.Text;
            quydinh.Ton2 = txtTon2.Text;
            quydinh.No = txtNo.Text;

            quydinh.Luu(); // Lưu vào file

            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
