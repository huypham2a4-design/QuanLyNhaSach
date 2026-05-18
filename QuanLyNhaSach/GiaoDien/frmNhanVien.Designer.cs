namespace QuanLyNhaSach.GiaoDien
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_Cmnd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_GioiTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TenMaNV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbo_TinhTP = new System.Windows.Forms.ComboBox();
            this.btn_Them_Moi = new System.Windows.Forms.Button();
            this.btn_Moi_NV = new System.Windows.Forms.Button();
            this.btn_SuaNV = new System.Windows.Forms.Button();
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_Xong = new System.Windows.Forms.Button();
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_XemNV = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(204, 497);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(221, 27);
            this.txt_SDT.TabIndex = 11;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // txt_Cmnd
            // 
            this.txt_Cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cmnd.Location = new System.Drawing.Point(204, 282);
            this.txt_Cmnd.Multiline = true;
            this.txt_Cmnd.Name = "txt_Cmnd";
            this.txt_Cmnd.Size = new System.Drawing.Size(221, 27);
            this.txt_Cmnd.TabIndex = 9;
            this.txt_Cmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cmnd_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(160, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 20);
            this.label13.TabIndex = 63;
            this.label13.Text = "(*)";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(204, 164);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(221, 30);
            this.dtp_NgaySinh.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(201, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 18);
            this.label12.TabIndex = 62;
            this.label12.Text = "(Lưu ý: Mục này chỉ chứa số)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 728);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "là thông tin bắt buộc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 284);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 25);
            this.label11.TabIndex = 56;
            this.label11.Text = "CMND/CCCD:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 18);
            this.label10.TabIndex = 61;
            this.label10.Text = "(Lưu ý: Mục này chỉ chứa số)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 728);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Ghi chú:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(99, 728);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "(*) ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(160, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(683, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 31);
            this.label1.TabIndex = 63;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(160, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(160, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(160, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "(*)";
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_GioiTinh.FormattingEnabled = true;
            this.cbo_GioiTinh.Location = new System.Drawing.Point(204, 223);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(221, 28);
            this.cbo_GioiTinh.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 497);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Điện thoại:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.txt_TenMaNV);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(517, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(639, 107);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu nhân viên";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Khaki;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(471, 41);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(149, 50);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TenMaNV
            // 
            this.txt_TenMaNV.Location = new System.Drawing.Point(195, 49);
            this.txt_TenMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenMaNV.Name = "txt_TenMaNV";
            this.txt_TenMaNV.Size = new System.Drawing.Size(237, 30);
            this.txt_TenMaNV.TabIndex = 3;
            this.txt_TenMaNV.TextChanged += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 53);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên NV/ Mã NV:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(26, 449);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(399, 30);
            this.txt_DiaChi.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 347);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 25);
            this.label22.TabIndex = 16;
            this.label22.Text = "Đia chỉ:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 222);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 25);
            this.label21.TabIndex = 15;
            this.label21.Text = "Giới tính:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(204, 40);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(221, 30);
            this.txt_MaNV.TabIndex = 10;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(204, 102);
            this.txt_TenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(221, 30);
            this.txt_TenNV.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 164);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 25);
            this.label20.TabIndex = 13;
            this.label20.Text = "Ngày sinh:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 105);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 25);
            this.label19.TabIndex = 11;
            this.label19.Text = "Họ Tên NV:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 43);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 25);
            this.label18.TabIndex = 9;
            this.label18.Text = "Mã NV:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbo_TinhTP);
            this.groupBox5.Controls.Add(this.txt_SDT);
            this.groupBox5.Controls.Add(this.txt_Cmnd);
            this.groupBox5.Controls.Add(this.btn_Them_Moi);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.dtp_NgaySinh);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.btn_Moi_NV);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cbo_GioiTinh);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.btn_SuaNV);
            this.groupBox5.Controls.Add(this.btn_XoaNV);
            this.groupBox5.Controls.Add(this.btn_ThemNV);
            this.groupBox5.Controls.Add(this.txt_DiaChi);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.txt_MaNV);
            this.groupBox5.Controls.Add(this.txt_TenNV);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox5.Location = new System.Drawing.Point(27, 13);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(458, 772);
            this.groupBox5.TabIndex = 64;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin";
            // 
            // cbo_TinhTP
            // 
            this.cbo_TinhTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TinhTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TinhTP.FormattingEnabled = true;
            this.cbo_TinhTP.IntegralHeight = false;
            this.cbo_TinhTP.Location = new System.Drawing.Point(204, 347);
            this.cbo_TinhTP.Name = "cbo_TinhTP";
            this.cbo_TinhTP.Size = new System.Drawing.Size(221, 28);
            this.cbo_TinhTP.TabIndex = 64;
            this.cbo_TinhTP.SelectedIndexChanged += new System.EventHandler(this.cbo_TinhTP_SelectedIndexChanged);
            // 
            // btn_Them_Moi
            // 
            this.btn_Them_Moi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_Moi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them_Moi.Image")));
            this.btn_Them_Moi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them_Moi.Location = new System.Drawing.Point(204, 572);
            this.btn_Them_Moi.Name = "btn_Them_Moi";
            this.btn_Them_Moi.Size = new System.Drawing.Size(213, 49);
            this.btn_Them_Moi.TabIndex = 5;
            this.btn_Them_Moi.Text = "Thêm Nhân Viên";
            this.btn_Them_Moi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them_Moi.UseVisualStyleBackColor = true;
            this.btn_Them_Moi.Click += new System.EventHandler(this.btn_Them_Moi_Click);
            // 
            // btn_Moi_NV
            // 
            this.btn_Moi_NV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Moi_NV.Image = ((System.Drawing.Image)(resources.GetObject("btn_Moi_NV.Image")));
            this.btn_Moi_NV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Moi_NV.Location = new System.Drawing.Point(350, 657);
            this.btn_Moi_NV.Name = "btn_Moi_NV";
            this.btn_Moi_NV.Size = new System.Drawing.Size(101, 42);
            this.btn_Moi_NV.TabIndex = 15;
            this.btn_Moi_NV.Text = "MỚI";
            this.btn_Moi_NV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Moi_NV.UseVisualStyleBackColor = true;
            this.btn_Moi_NV.Click += new System.EventHandler(this.btn_Moi_NV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaNV.Image")));
            this.btn_SuaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaNV.Location = new System.Drawing.Point(133, 655);
            this.btn_SuaNV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(92, 44);
            this.btn_SuaNV.TabIndex = 13;
            this.btn_SuaNV.Text = "  SỬA";
            this.btn_SuaNV.UseVisualStyleBackColor = true;
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaNV.Image")));
            this.btn_XoaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaNV.Location = new System.Drawing.Point(233, 654);
            this.btn_XoaNV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(101, 44);
            this.btn_XoaNV.TabIndex = 14;
            this.btn_XoaNV.Text = "  XÓA";
            this.btn_XoaNV.UseVisualStyleBackColor = true;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNV.Image")));
            this.btn_ThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemNV.Location = new System.Drawing.Point(8, 655);
            this.btn_ThemNV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(108, 43);
            this.btn_ThemNV.TabIndex = 12;
            this.btn_ThemNV.Text = "  THÊM";
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_Xong
            // 
            this.btn_Xong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Xong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xong.Location = new System.Drawing.Point(689, 499);
            this.btn_Xong.Name = "btn_Xong";
            this.btn_Xong.Size = new System.Drawing.Size(94, 50);
            this.btn_Xong.TabIndex = 67;
            this.btn_Xong.Text = "Xong";
            this.btn_Xong.UseVisualStyleBackColor = false;
            this.btn_Xong.Click += new System.EventHandler(this.btn_Xong_Click);
            // 
            // dgv_NV
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgaySinh,
            this.Gioitinh,
            this.CMND,
            this.DiaChi,
            this.SDT});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NV.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_NV.Location = new System.Drawing.Point(517, 184);
            this.dgv_NV.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_NV.Name = "dgv_NV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_NV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NV.Size = new System.Drawing.Size(960, 295);
            this.dgv_NV.TabIndex = 68;
            this.dgv_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NV_CellClick);
            this.dgv_NV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NV_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 90;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Họ Tên NV";
            this.TenNV.Name = "TenNV";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới Tính";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND/CCCD";
            this.CMND.Name = "CMND";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.Location = new System.Drawing.Point(517, 499);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(152, 50);
            this.btn_CapNhat.TabIndex = 66;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_XemNV
            // 
            this.btn_XemNV.BackColor = System.Drawing.Color.Linen;
            this.btn_XemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_XemNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_XemNV.Image")));
            this.btn_XemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemNV.Location = new System.Drawing.Point(1242, 499);
            this.btn_XemNV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XemNV.Name = "btn_XemNV";
            this.btn_XemNV.Size = new System.Drawing.Size(130, 50);
            this.btn_XemNV.TabIndex = 61;
            this.btn_XemNV.Text = "Xem DS";
            this.btn_XemNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XemNV.UseVisualStyleBackColor = false;
            this.btn_XemNV.Click += new System.EventHandler(this.btn_XemNV_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.BackgroundImage")));
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(1380, 499);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 50);
            this.btn_Thoat.TabIndex = 62;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 811);
            this.Controls.Add(this.dgv_NV);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_XemNV);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_Xong);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_Cmnd;
        private System.Windows.Forms.Button btn_Them_Moi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_XemNV;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Moi_NV;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_GioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SuaNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenMaNV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_XoaNV;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Xong;
        private System.Windows.Forms.DataGridView dgv_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.ComboBox cbo_TinhTP;
    }
}