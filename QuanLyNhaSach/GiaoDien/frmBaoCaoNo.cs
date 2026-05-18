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
using Excel = Microsoft.Office.Interop.Excel;


namespace QuanLyNhaSach.GiaoDien
{
    public partial class frmBaoCaoNo     : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP;Initial Catalog=QUANLY_NHASACH;Integrated Security=True");
        public frmBaoCaoNo()
        {
            InitializeComponent();
        }

        private void frmBaoCaoNo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btxem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btloc_Click(object sender, EventArgs e)
        {
            string tenKH = txtten.Text.Trim();
            DateTime? tuNgay = dateTimePicker1.Value.Date;
            DateTime? denNgay = dateTimePicker2.Value.Date;
            LoadData(tenKH, tuNgay, denNgay);
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btxuat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            // Tạo ứng dụng Excel
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;

            // Ghi tiêu đề cột
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            // Ghi dữ liệu
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                }
            }

            // Định dạng cơ bản
            worksheet.Columns.AutoFit();
            worksheet.Cells[1, 1].EntireRow.Font.Bold = true;

            // Hiển thị Excel
            excelApp.Visible = true;
        }
        private void LoadData(string tenKH = "", DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            try
            {
                conn.Open();
                string sql = @"SELECT KH.MAKH AS [Mã KH], KH.TENKH AS [Tên khách hàng],
                                      SUM(CTHD.SOLUONG * CTHD.DONGIA) AS [Tổng nợ]
                               FROM HOADON HD
                               JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH
                               JOIN CHITIET_HOADON CTHD ON HD.MAHD = CTHD.MAHD
                               WHERE (@TenKH = '' OR KH.TENKH LIKE '%' + @TenKH + '%')
                               AND (@TuNgay IS NULL OR HD.NGAYXUATHD >= @TuNgay)
                               AND (@DenNgay IS NULL OR HD.NGAYXUATHD <= @DenNgay)
                               GROUP BY KH.MAKH, KH.TENKH
                               ORDER BY [Tổng nợ] DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenKH", tenKH);
                cmd.Parameters.AddWithValue("@TuNgay", (object)tuNgay ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DenNgay", (object)denNgay ?? DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // Tính tổng nợ và số khách đang nợ
                decimal tongNo = 0;
                int soKhach = dt.Rows.Count;
                foreach (DataRow row in dt.Rows)
                {
                    tongNo += Convert.ToDecimal(row["Tổng nợ"]);
                }
                lbtongno.Text = $"Tổng nợ: {tongNo:N0} VND";
                lbsokhach.Text = $"Số khách đang nợ: {soKhach}";
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
    }
}
