using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.CSDL;
using QuanLyNhaSach.Model;



namespace QuanLyNhaSach.GiaoDien
{
    public partial class frmChiTietHD : Form
    {
        private string mahd;
        private Model_CTHoaDon model = new Model_CTHoaDon();
        private bool isAdding = false;

        private PrintDocument printDoc = new PrintDocument();
        private PrintPreviewDialog printPreview = new PrintPreviewDialog();
        public frmChiTietHD(string _mahd)
        {
            InitializeComponent();
            mahd = _mahd;

            txtSLnhap.TextChanged += (s, e) => TinhThanhTien();
            txtDonGia.TextChanged += (s, e) => TinhThanhTien();
        }

        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            LoadDSSach();
            LoadDSChiTiet();
            cbo_sach.SelectedIndexChanged += cbo_sach_SelectedIndexChanged;
        }
        void LoadDSSach()
        {
            cbo_sach.DataSource = model.LayDSSach();
            cbo_sach.DisplayMember = "TENSH";
            cbo_sach.ValueMember = "MASH";
            cbo_sach.SelectedIndex = -1;
        }

        void LoadDSChiTiet()
        {
            dgvCTHD.DataSource = model.LayDSChiTiet(mahd);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ResetInput();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float dongia;
            int soluong;

            if (!int.TryParse(txtSLnhap.Text, out soluong) || !float.TryParse(txtDonGia.Text, out dongia))
            {
                MessageBox.Show("Vui lòng nhập đúng Số lượng và Đơn giá!");
                return;
            }

            float thanhtien = soluong * dongia;
            txtThanhTien.Text = thanhtien.ToString("0.##");
            ChiTietHoaDon cthd = new ChiTietHoaDon()
            {
                Mahd = mahd,
                Mash = cbo_sach.SelectedValue.ToString(),
                Soluong = int.Parse(txtSLnhap.Text),
                Dongia = float.Parse(txtDonGia.Text),
                Thanhtien = float.Parse(txtThanhTien.Text)
            };

            bool result = isAdding ? model.ThemChiTiet(cthd) : model.CapNhatChiTiet(cthd);

            if (result)
            {
                MessageBox.Show("Lưu thành công!");
                LoadDSChiTiet();
                isAdding = false;
            }
            else
            {
                MessageBox.Show("Lưu thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.CurrentRow != null)
            {
                string mash = dgvCTHD.CurrentRow.Cells["MASH"].Value.ToString();
                if (model.XoaChiTiet(mahd, mash))
                {
                    MessageBox.Show("Đã xóa chi tiết!");
                    LoadDSChiTiet();
                }
            }
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvCTHD.Rows[e.RowIndex];
                cbo_sach.SelectedValue = r.Cells["MASH"].Value;
                txtSLnhap.Text = r.Cells["SOLUONG"].Value.ToString();
                txtDonGia.Text = r.Cells["DONGIA"].Value.ToString();
                txtThanhTien.Text = r.Cells["THANHTIEN"].Value.ToString();
                isAdding = false;
            }
        }
        void ResetInput()
        {
            cbo_sach.SelectedIndex = -1;
            txtSLnhap.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (model.LayDSChiTiet(mahd).Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có sách nào để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Bước 2: Hỏi xác nhận
                    if (MessageBox.Show(
                $"Bạn có chắc muốn XUẤT HÓA ĐƠN {mahd}?\n\nSố lượng sách trong kho sẽ bị trừ ngay lập tức!",
                "Xác nhận xuất hóa đơn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                    {
                return;
            }
            // Bước 3: Cập nhật tồn kho
            if (!model.CapNhatTonKho(mahd))
            {
                return; // Nếu không đủ hàng → dừng luôn
            }
            model.CapNhatGiamGiaHoaDon(mahd);
            InHoaDonTrucTiep();
        }
        
        private void InHoaDonTrucTiep()
        {
           
            try
            {
                model.CapNhatGiamGiaHoaDon(mahd);
                LoadDSChiTiet();
                DataTable dtHD = model.LayThongTinHoaDon(mahd);
                DataTable dtCT = model.LayDSChiTiet(mahd);

                if (dtHD.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!");
                    return;
                }

                DataRow hd = dtHD.Rows[0];
                string tenKH = hd["TENKH"].ToString();  // Giờ luôn có giá trị, không NULL
                string tenNV = hd["TENNV"].ToString();
                string ngayXuat = Convert.ToDateTime(hd["NGAYXUATHD"]).ToString("dd/MM/yyyy");

                printDoc.DocumentName = $"Hóa đơn {mahd}";
                printDoc.PrintPage += (s, ev) => PrintPageHandler(ev, dtHD, dtCT, tenKH, tenNV, ngayXuat);

                printPreview.Document = printDoc;
                printPreview.Text = "Xem trước - Hóa đơn " + mahd;

                if (printPreview.ShowDialog() == DialogResult.OK)
                {
                    PrintDialog pd = new PrintDialog();
                    pd.Document = printDoc;
                    if (pd.ShowDialog() == DialogResult.OK)
                    {
                        printDoc.Print();
                        MessageBox.Show("In thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in: " + ex.Message);
            }
        }

        private void PrintPageHandler(PrintPageEventArgs e, DataTable dtHD, DataTable dtCT, string tenKH, string tenNV, string ngayXuat)
        {
            Graphics g = e.Graphics;
            Font fTieuDe = new Font("Arial", 16, FontStyle.Bold);
            Font fNormal = new Font("Arial", 10);
            Font fNho = new Font("Arial", 9);
            Brush b = Brushes.Black;
            Pen p = Pens.Gray;

            float y = 40;
            float left = e.MarginBounds.Left;
            float center = e.MarginBounds.Width / 2 + left;

            // Tiêu đề hóa đơn
            g.DrawString("HÓA ĐƠN BÁN HÀNG", fTieuDe, b, center, y, new StringFormat { Alignment = StringAlignment.Center });
            y += 40;

            g.DrawString("CỬA HÀNG SÁCH ABC", fNormal, b, left, y); y += 18;
            g.DrawString("Địa chỉ: 123 Đường Sách, Q.1, TP.HCM", fNho, b, left, y); y += 15;
            g.DrawString("Điện thoại: 0123.456.789", fNho, b, left, y); y += 30;

            g.DrawString($"Mã HD: {mahd}", fNormal, b, left, y); y += 18;
            g.DrawString($"Khách hàng: {tenKH}", fNormal, b, left, y); y += 18;
            g.DrawString($"Nhân viên: {tenNV}", fNormal, b, left, y); y += 18;
            g.DrawString($"Ngày xuất: {ngayXuat}", fNormal, b, left, y); y += 30;

            // Vẽ bảng chi tiết
            float[] colX = { left, left + 40, left + 260, left + 320, left + 420, left + 520 };
            int rowH = 25;
            int stt = 1;
            double tong = 0;  // Tổng tiền gốc

            // Header bảng
            DrawRow(g, p, b, fNormal, y, rowH, colX, "STT", "Tên sách", "SL", "Đơn giá", "Thành tiền");
            y += rowH;

            // Nội dung chi tiết
            foreach (DataRow r in dtCT.Rows)
            {
                string ten = r["TENSH"].ToString();
                int sl = Convert.ToInt32(r["SOLUONG"]);
                double dg = Convert.ToDouble(r["DONGIA"]);
                double tt = Convert.ToDouble(r["THANHTIEN"]);
                tong += tt;

                DrawRow(g, p, b, fNho, y, rowH, colX,
                    stt++.ToString(),
                    ten.Length > 30 ? ten.Substring(0, 27) + "..." : ten,
                    sl.ToString(),
                    dg.ToString("N0"),
                    tt.ToString("N0"));
                y += rowH;
            }

            // Lấy giảm giá và tổng sau giảm (an toàn với NULL và cột chưa tồn tại)
            double phanTramGiam = 0;
            double tongSauGiam = tong;  // Mặc định bằng tổng gốc nếu không có giảm

            if (dtHD.Columns.Contains("PHANTRAMGIAM") && dtHD.Rows[0]["PHANTRAMGIAM"] != DBNull.Value)
            {
                phanTramGiam = Convert.ToDouble(dtHD.Rows[0]["PHANTRAMGIAM"]);
            }

            if (dtHD.Columns.Contains("TONGTIEN") && dtHD.Rows[0]["TONGTIEN"] != DBNull.Value)
            {
                tongSauGiam = Convert.ToDouble(dtHD.Rows[0]["TONGTIEN"]);
            }

            // Vẽ phần tổng kết
            y += 10;
            g.DrawString($"Tổng tiền tạm tính: {tong:N0} VNĐ", fNormal, b, colX[3], y);
            y += 20;

            if (phanTramGiam > 0)
            {
                g.DrawString($"Giảm giá khách thân thiết: {phanTramGiam * 100}%",
                             new Font("Arial", 11, FontStyle.Bold), Brushes.Blue, colX[3], y);
                y += 20;
            }

            g.DrawString($"THÀNH TIỀN: {tongSauGiam:N0} VNĐ",
                         new Font("Arial", 12, FontStyle.Bold), Brushes.Red, colX[3], y);

            y += 30;
            if (phanTramGiam > 0)
            {
                g.DrawString("Cảm ơn Quý khách đã mua sách tại cửa hàng!", fNormal, b, left, y);
            }

            e.HasMorePages = false;
        }

        private void DrawRow(Graphics g, Pen p, Brush b, Font f, float y, int h, float[] x, params string[] cells)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                g.DrawRectangle(p, x[i], y, x[i + 1] - x[i], h);
                g.DrawString(cells[i], f, b, x[i] + 5, y + 5);
            }
        }

        private void cbo_sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_sach.SelectedIndex == -1 || cbo_sach.SelectedValue == null)
                return;

            // Lấy DataTable từ DataSource của cbo_sach
            DataTable dt = (DataTable)cbo_sach.DataSource;
            string maSH = cbo_sach.SelectedValue.ToString();

            // Tìm dòng sách có MASH tương ứng
            DataRow[] rows = dt.Select($"MASH = '{maSH}'");
            if (rows.Length > 0)
            {
                float gia = Convert.ToSingle(rows[0]["GIA"]);
                txtDonGia.Text = gia.ToString("0.##"); // Định dạng số
            }

            // Tính lại thành tiền nếu đã có số lượng
            TinhThanhTien();
        }
        private void TinhThanhTien()
        {
            if (string.IsNullOrWhiteSpace(txtSLnhap.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                txtThanhTien.Clear();
                return;
            }

            if (int.TryParse(txtSLnhap.Text, out int sl) && float.TryParse(txtDonGia.Text, out float dg))
            {
                float tt = sl * dg;
                txtThanhTien.Text = tt.ToString("0.##");
            }
            else
            {
                txtThanhTien.Clear();
            }
        }

        private void txtSLnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Chặn hoàn toàn ký tự không hợp lệ
            }
        }
    }
}
