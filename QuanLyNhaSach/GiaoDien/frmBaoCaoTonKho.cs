using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyNhaSach.GiaoDien
{
    public partial class frmBaoCaoTonKho : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP;Initial Catalog=QUANLY_NHASACH;Integrated Security=True");
        public frmBaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void btxuat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Workbooks.Add();
                Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;

                // Header
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }

                // Data
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                    }
                }
                worksheet.Columns.AutoFit(); // Tự động căn chỉnh độ rộng cột
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }

        }

        private void btloc_Click(object sender, EventArgs e)
        {
            string tensach = txtten.Text.Trim();
            string theloai = cbtheloai.SelectedItem != null ? cbtheloai.SelectedItem.ToString() : "";

            // Lấy MaKho từ SelectedValue (vì ta đã gán ValueMember = "MAKHO")
            string makho = "";
            if (cbKho.SelectedValue != null)
            {
                // Kiểm tra nếu là DataRowView (trường hợp binding) thì lấy row ra
                if (cbKho.SelectedValue is DataRowView row)
                    makho = row["MAKHO"].ToString();
                else
                    makho = cbKho.SelectedValue.ToString();
            }

            // Gọi hàm lọc
            LoadData(tensach, theloai, makho);

            // YÊU CẦU CỦA BẠN: Reset các lựa chọn về trống sau khi lọc xong
            ResetFilterControls();

        }
        private void ResetFilterControls()
        {
            txtten.Text = "";
            cbtheloai.SelectedIndex = -1;
            cbtheloai.Text = ""; // Đôi khi SelectedIndex = -1 không xóa text hiển thị nếu DropDownStyle = DropDown
            cbKho.SelectedIndex = -1;
        }


        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData(string tensach = "", string theloai = "", string makho = "")
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // LƯU Ý QUAN TRỌNG: 
                // Câu lệnh SQL này giả định bảng SACH có cột MAKHO để liên kết.
                // Nếu bạn dùng bảng trung gian (ví dụ KHO_SACH), bạn cần sửa lại câu JOIN.
                string sql = @"SELECT S.MASH AS [Mã sách], S.TENSH AS [Tên sách], S.THELOAI AS [Thể loại],
                                      S.GIA AS [Đơn giá], S.SLTONKHO AS [Số lượng tồn],
                                      (S.GIA * S.SLTONKHO) AS [Giá trị tồn], 
                                      NXB.TENNXB AS [Nhà xuất bản],
                                      K.TENKHO AS [Kho Hàng]
                               FROM SACH S
                               JOIN NHAXUATBAN NXB ON S.MANXB = NXB.MANXB
                               LEFT JOIN KHOHANG K ON S.MAKHO = K.MAKHO 
                               WHERE (S.TENSH LIKE @TenSach OR @TenSach = '')
                               AND (S.THELOAI = @TheLoai OR @TheLoai = '')
                               AND (S.MAKHO = @MaKho OR @MaKho = '')
                               ORDER BY S.SLTONKHO DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                // Thêm ký tự % cho tìm kiếm gần đúng tên sách
                cmd.Parameters.AddWithValue("@TenSach", string.IsNullOrEmpty(tensach) ? "" : "%" + tensach + "%");
                cmd.Parameters.AddWithValue("@TheLoai", theloai);
                cmd.Parameters.AddWithValue("@MaKho", makho);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // Tính tổng tồn kho
                decimal tongSoLuong = 0;
                decimal tongGiaTri = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Số lượng tồn"] != DBNull.Value)
                        tongSoLuong += Convert.ToDecimal(row["Số lượng tồn"]);

                    if (row["Giá trị tồn"] != DBNull.Value)
                        tongGiaTri += Convert.ToDecimal(row["Giá trị tồn"]);
                }
                lbtongton.Text = $"Tổng số lượng: {tongSoLuong} | Tổng giá trị: {tongGiaTri:N0} VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }


        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadTheLoai();
            LoadKho();
        }
        private void LoadKho()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAKHO, TENKHO FROM KHOHANG", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Thêm một dòng chọn mặc định (Tất cả) nếu cần, hoặc để trống
                // Ở đây ta gán trực tiếp
                cbKho.DataSource = dt;
                cbKho.DisplayMember = "TENKHO"; // Hiển thị tên kho
                cbKho.ValueMember = "MAKHO";    // Giá trị ngầm là mã kho
                cbKho.SelectedIndex = -1;       // Mặc định không chọn gì
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách kho: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void LoadTheLoai()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT THELOAI FROM SACH", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbtheloai.Items.Add(dr["THELOAI"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cbKho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
