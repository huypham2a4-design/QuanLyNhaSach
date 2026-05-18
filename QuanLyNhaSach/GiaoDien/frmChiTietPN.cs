using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.CSDL;
using QuanLyNhaSach.Model;

namespace QuanLyNhaSach.GiaoDien
{
    public partial class frmChiTietPN : Form
    {
        private readonly Model_CTPhieuNhap model = new Model_CTPhieuNhap();
        private string mapn = "";
        private bool isAdding = false, isEditing = false;
        private PrintDocument printDoc = new PrintDocument();
        private PrintPreviewDialog printPreview = new PrintPreviewDialog();
        public frmChiTietPN(string maPN)
        {
            InitializeComponent();
            mapn = maPN;
            txtMaPN.Text = maPN;
            txtMaPN.Enabled = false;
            LoadDSSach();
            LoadData();
            SetupDataGridView();
            dgvCTPN.CellClick += dgvCTPN_CellClick;

        }
        void LoadDSSach()
        {
            cbo_sach.DataSource = model.LayDSSach();
            cbo_sach.DisplayMember = "TENSH";
            cbo_sach.ValueMember = "MASH";
            cbo_sach.SelectedIndex = -1;
        }
        private void SetupDataGridView()
        {
            dgvCTPN.AutoGenerateColumns = false;
            dgvCTPN.Columns.Clear();
            dgvCTPN.Columns.Add(new DataGridViewTextBoxColumn { Name = "mapn", DataPropertyName = "mapn", HeaderText = "Mã PN" });
            dgvCTPN.Columns.Add(new DataGridViewTextBoxColumn { Name = "mash", DataPropertyName = "mash", HeaderText = "Mã Sách" });
            dgvCTPN.Columns.Add(new DataGridViewTextBoxColumn { Name = "tensh", DataPropertyName = "tensh", HeaderText = "Tên Sách", Width = 200 });
            dgvCTPN.Columns.Add(new DataGridViewTextBoxColumn { Name = "soluong", DataPropertyName = "soluong", HeaderText = "SL" });
            dgvCTPN.Columns.Add(new DataGridViewTextBoxColumn { Name = "dongia", DataPropertyName = "dongia", HeaderText = "Đơn Giá", DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
            dgvCTPN.Columns.Add(new DataGridViewTextBoxColumn { Name = "thanhtien", DataPropertyName = "thanhtien", HeaderText = "Thành Tiền", DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
        }
        private void LoadData() => dgvCTPN.DataSource = model.LayChiTiet(mapn);
     
 

      

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow == null) return;
            if (MessageBox.Show("Xóa sách này khỏi phiếu nhập", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mash = dgvCTPN.CurrentRow.Cells["mash"].Value.ToString();
                if (model.Xoa(mapn, mash))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow == null) return;
            isEditing = true; isAdding = false;
            var r = dgvCTPN.CurrentRow;
            cbo_sach.SelectedValue = r.Cells["mash"].Value.ToString();
            txtSLnhap.Text = r.Cells["soluong"].Value.ToString();
            txtDonGia.Text = r.Cells["dongia"].Value.ToString();
            EnableInput(true);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (cbo_sach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sách!");
                cbo_sach.Focus();
                return;
            }

            string mash = cbo_sach.SelectedValue.ToString();
            int sl = int.Parse(txtSLnhap.Text);
            float dg = float.Parse(txtDonGia.Text);
            float thanhtien = sl * dg;

            bool luuChiTietOK = false;

            // BƯỚC 1: Chỉ thêm/sửa CHI TIẾT (không đụng tới tồn kho)
            if (isAdding)
            {
                string sqlInsert = @"
            INSERT INTO ChiTietPhieuNhap(mapn, mash, soluong, dongia, thanhtien)
            VALUES(@mapn, @mash, @sl, @dg, @tt)";

                luuChiTietOK = model.ExecuteNonQuery(sqlInsert, mapn, mash, sl, dg, thanhtien);
            }
            else // isEditing
            {
                string sqlUpdate = @"
            UPDATE ChiTietPhieuNhap
            SET soluong = @sl, dongia = @dg, thanhtien = @tt
            WHERE mapn = @mapn AND mash = @mash";

                luuChiTietOK = model.ExecuteNonQuery(sqlUpdate, mapn, mash, sl, dg, thanhtien);
            }

            // BƯỚC 2: Nếu lưu chi tiết thành công → CẬP NHẬT TỒN KHO 1 LẦN DUY NHẤT
            if (luuChiTietOK)
            {
                if (model.CapNhatTonKhoKhiNhap(mapn))
                {
                    MessageBox.Show("Lưu thành công! Tồn kho đã được cập nhật toàn bộ phiếu nhập.",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    ClearInput();
                    EnableInput(false);
                    ResetButtons();
                    isAdding = isEditing = false;
                }
            }
            else
            {
                MessageBox.Show("Lưu chi tiết thất bại! Tồn kho chưa được cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearInput(); EnableInput(false); ResetButtons();
            isAdding = isEditing = false;

        }
        private void ClearInput()
        {
            cbo_sach.SelectedIndex = -1;
            txtSLnhap.Text = "1";
            txtDonGia.Text = "0";
        }

        private bool ValidateInput()
        {
            if (cbo_sach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sách!");
                cbo_sach.Focus();
                return false;
            }
            if (!int.TryParse(txtSLnhap.Text, out int sl) || sl <= 0)
            {
                MessageBox.Show("Số lượng phải > 0!");
                txtSLnhap.Focus();
                return false;
            }
            if (!float.TryParse(txtDonGia.Text, out float dg) || dg < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                txtDonGia.Focus();
                return false;
            }
            return true;
        }

        private void EnableInput(bool e)
        {
            cbo_sach.Enabled = txtSLnhap.Enabled = txtDonGia.Enabled = e;
        }

        private void ResetButtons()
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;
            ClearInput();
            EnableInput(true);
            cbo_sach.Focus(); 
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            InPhieuNhapTrucTiep();
        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvCTPN.Rows.Count) return;

            var row = dgvCTPN.Rows[e.RowIndex];

           
            cbo_sach.SelectedValue = row.Cells["mash"].Value?.ToString() ?? "";
            txtSLnhap.Text = row.Cells["soluong"].Value?.ToString() ?? "1";
            txtDonGia.Text = row.Cells["dongia"].Value?.ToString() ?? "0";

            
            isEditing = true;
            isAdding = false;
            EnableInput(true);
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
        }
        private void InPhieuNhapTrucTiep()
        {
            try
            {
                // Lấy thông tin phiếu nhập + nhà cung cấp + nhân viên
                DataTable dtPN = model.LayThongTinPhieuNhap(mapn);
                DataTable dtCT = model.LayChiTiet(mapn);

                if (dtPN.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập!");
                    return;
                }

                DataRow pn = dtPN.Rows[0];
                string tenNCC = pn["TenNCC"].ToString();
                string tenNV = pn["TenNV"].ToString();
                string ngayNhap = Convert.ToDateTime(pn["NGAYNHAP"]).ToString("dd/MM/yyyy");

                printDoc.DocumentName = $"Phiếu nhập {mapn}";
                printDoc.PrintPage += (s, ev) => PrintPhieuNhapHandler(ev, dtPN, dtCT, tenNCC, tenNV, ngayNhap);

                printPreview.Document = printDoc;
                printPreview.Text = "Xem trước - Phiếu nhập " + mapn;

                if (printPreview.ShowDialog() == DialogResult.OK)
                {
                    PrintDialog pd = new PrintDialog();
                    pd.Document = printDoc;
                    if (pd.ShowDialog() == DialogResult.OK)
                    {
                        printDoc.Print();
                        MessageBox.Show("In phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in phiếu nhập: " + ex.Message);
            }
        }

        private void PrintPhieuNhapHandler(PrintPageEventArgs e, DataTable dtPN, DataTable dtCT, string tenNCC, string tenNV, string ngayNhap)
        {
            Graphics g = e.Graphics;
            Font fTieuDe = new Font("Arial", 18, FontStyle.Bold);
            Font fNormal = new Font("Arial", 11);
            Font fNho = new Font("Arial", 9);
            Brush b = Brushes.Black;
            Pen p = Pens.Gray;
            float y = 40;
            float left = e.MarginBounds.Left;
            float center = e.MarginBounds.Width / 2 + left;

            // Tiêu đề
            g.DrawString("PHIẾU NHẬP KHO SÁCH", fTieuDe, b, center, y, new StringFormat { Alignment = StringAlignment.Center });
            y += 50;

            // Thông tin cửa hàng
            g.DrawString("CỬA HÀNG SÁCH ABC", new Font("Arial", 12, FontStyle.Bold), b, left, y); y += 20;
            g.DrawString("Địa chỉ: 123 Đường Sách, Q.1, TP.HCM", fNho, b, left, y); y += 15;
            g.DrawString("Điện thoại: 0123.456.789", fNho, b, left, y); y += 30;

            // Thông tin phiếu nhập
            g.DrawString($"Mã phiếu nhập: {mapn}", fNormal, b, left, y); y += 20;
            g.DrawString($"Nhà cung cấp: {tenNCC}", fNormal, b, left, y); y += 20;
            g.DrawString($"Nhân viên nhập: {tenNV}", fNormal, b, left, y); y += 20;
            g.DrawString($"Ngày nhập: {ngayNhap}", fNormal, b, left, y); y += 35;

            // Bảng chi tiết
            float[] colX = { left, left + 40, left + 100, left + 350, left + 450, left + 550 };
            int rowH = 28;
            int stt = 1;
            double tongTien = 0;

            // Header bảng
            DrawRow(g, p, b, fNormal, y, rowH, colX, "STT", "Mã sách", "Tên sách", "SL", "Đơn giá", "Thành tiền");
            y += rowH;

            // Dòng dữ liệu
            foreach (DataRow r in dtCT.Rows)
            {
                string ma = r["mash"].ToString();
                string ten = r["tensh"].ToString();
                int sl = Convert.ToInt32(r["soluong"]);
                double dg = Convert.ToDouble(r["dongia"]);
                double tt = Convert.ToDouble(r["thanhtien"]);
                tongTien += tt;

                DrawRow(g, p, b, fNho, y, rowH, colX,
                    stt++.ToString(),
                    ma,
                    ten.Length > 35 ? ten.Substring(0, 32) + "..." : ten,
                    sl.ToString(),
                    dg.ToString("N0"),
                    tt.ToString("N0"));
                y += rowH;
            }

            // Tổng tiền
            y += 15;
            g.DrawString($"TỔNG TIỀN NHẬP: {tongTien:N0} VNĐ",
                new Font("Arial", 12, FontStyle.Bold), Brushes.Red, colX[4], y);

            y += 40;
            g.DrawString("Người lập phiếu", fNormal, b, left + 400, y);
            g.DrawString("(Ký, ghi rõ họ tên)", fNho, b, left + 400, y + 20);

            e.HasMorePages = false;
        }

        private void frmChiTietPN_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        // Hàm vẽ dòng bảng (giữ nguyên bạn đã có)
        private void DrawRow(Graphics g, Pen p, Brush b, Font f, float y, int h, float[] x, params string[] cells)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                float width = (i < x.Length - 1) ? x[i + 1] - x[i] : 150;
                g.DrawRectangle(p, x[i], y, width, h);
                g.DrawString(cells[i], f, b, x[i] + 5, y + 5);
            }
        }
    }
}
