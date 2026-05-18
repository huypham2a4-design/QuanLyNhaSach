namespace QuanLyNhaSach.GiaoDien
{
    partial class frmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_MaKho = new System.Windows.Forms.ComboBox();
            this.cbo_NXB = new System.Windows.Forms.ComboBox();
            this.cbo_TacGia = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Moi_NV = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TheLoai = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgv_Sach = new System.Windows.Forms.DataGridView();
            this.MaSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATGCHINh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTGChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(751, 90);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Sách theo thông tin";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(117, 36);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(200, 29);
            this.txt_TimKiem.TabIndex = 10;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm sách:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 179);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 24);
            this.label11.TabIndex = 56;
            this.label11.Text = "Nhà Xuất bản:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(509, 82);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(208, 30);
            this.txt_DonGia.TabIndex = 45;
            this.txt_DonGia.Leave += new System.EventHandler(this.txt_DonGia_Leave);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(509, 127);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(208, 30);
            this.txt_SoLuong.TabIndex = 55;
            this.txt_SoLuong.Leave += new System.EventHandler(this.txt_SoLuong_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_MaKho);
            this.groupBox2.Controls.Add(this.cbo_NXB);
            this.groupBox2.Controls.Add(this.cbo_TacGia);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btn_Moi_NV);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_DonGia);
            this.groupBox2.Controls.Add(this.txt_SoLuong);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.txt_TheLoai);
            this.groupBox2.Controls.Add(this.txt_TenSach);
            this.groupBox2.Controls.Add(this.txt_MaSach);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(59, 446);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(995, 252);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Sách";
            // 
            // cbo_MaKho
            // 
            this.cbo_MaKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MaKho.FormattingEnabled = true;
            this.cbo_MaKho.Location = new System.Drawing.Point(510, 175);
            this.cbo_MaKho.Name = "cbo_MaKho";
            this.cbo_MaKho.Size = new System.Drawing.Size(207, 28);
            this.cbo_MaKho.TabIndex = 63;
            // 
            // cbo_NXB
            // 
            this.cbo_NXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_NXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NXB.FormattingEnabled = true;
            this.cbo_NXB.Location = new System.Drawing.Point(151, 175);
            this.cbo_NXB.Name = "cbo_NXB";
            this.cbo_NXB.Size = new System.Drawing.Size(232, 28);
            this.cbo_NXB.TabIndex = 62;
            // 
            // cbo_TacGia
            // 
            this.cbo_TacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TacGia.FormattingEnabled = true;
            this.cbo_TacGia.Location = new System.Drawing.Point(509, 42);
            this.cbo_TacGia.Name = "cbo_TacGia";
            this.cbo_TacGia.Size = new System.Drawing.Size(207, 28);
            this.cbo_TacGia.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(394, 179);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 24);
            this.label12.TabIndex = 59;
            this.label12.Text = "Mã Kho";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Moi_NV
            // 
            this.btn_Moi_NV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Moi_NV.Image = ((System.Drawing.Image)(resources.GetObject("btn_Moi_NV.Image")));
            this.btn_Moi_NV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Moi_NV.Location = new System.Drawing.Point(759, 162);
            this.btn_Moi_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Moi_NV.Name = "btn_Moi_NV";
            this.btn_Moi_NV.Size = new System.Drawing.Size(125, 41);
            this.btn_Moi_NV.TabIndex = 58;
            this.btn_Moi_NV.Text = "MỚI";
            this.btn_Moi_NV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Moi_NV.UseVisualStyleBackColor = true;
            this.btn_Moi_NV.Click += new System.EventHandler(this.btn_Moi_NV_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(759, 122);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(125, 33);
            this.btn_Sua.TabIndex = 30;
            this.btn_Sua.Text = "  SỬA";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(759, 79);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(125, 36);
            this.btn_Xoa.TabIndex = 29;
            this.btn_Xoa.Text = "  XÓA";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(759, 36);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(125, 34);
            this.btn_Them.TabIndex = 28;
            this.btn_Them.Text = "  THÊM";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txt_TheLoai
            // 
            this.txt_TheLoai.Location = new System.Drawing.Point(151, 122);
            this.txt_TheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TheLoai.Name = "txt_TheLoai";
            this.txt_TheLoai.Size = new System.Drawing.Size(232, 30);
            this.txt_TheLoai.TabIndex = 11;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Location = new System.Drawing.Point(151, 84);
            this.txt_TenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(232, 30);
            this.txt_TenSach.TabIndex = 10;
            this.txt_TenSach.TextChanged += new System.EventHandler(this.txt_TenSach_TextChanged);
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Location = new System.Drawing.Point(151, 46);
            this.txt_MaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(233, 30);
            this.txt_MaSach.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tác giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thể loại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên sách:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(474, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 45;
            this.label1.Text = "DANH SÁCH SÁCH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Danh sách Sách:";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.LightGreen;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(869, 176);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(144, 47);
            this.btnLoc.TabIndex = 46;
            this.btnLoc.Text = "LỌC LẠI";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.PeachPuff;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1046, 176);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 47);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgv_Sach
            // 
            this.dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSH,
            this.TenSH,
            this.TheLoai,
            this.Gia,
            this.SLTonKho,
            this.MaNXB,
            this.MATGCHINh,
            this.MAKHo,
            this.TenTGChinh,
            this.tennxb,
            this.tenkho});
            this.dgv_Sach.Location = new System.Drawing.Point(59, 240);
            this.dgv_Sach.Name = "dgv_Sach";
            this.dgv_Sach.RowHeadersWidth = 51;
            this.dgv_Sach.RowTemplate.Height = 24;
            this.dgv_Sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Sach.Size = new System.Drawing.Size(1145, 182);
            this.dgv_Sach.TabIndex = 53;
            this.dgv_Sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sach_CellClick_1);
            this.dgv_Sach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sach_CellDoubleClick);
            // 
            // MaSH
            // 
            this.MaSH.DataPropertyName = "MaSH";
            this.MaSH.HeaderText = "Mã Sách";
            this.MaSH.MinimumWidth = 6;
            this.MaSH.Name = "MaSH";
            this.MaSH.ReadOnly = true;
            this.MaSH.Width = 125;
            // 
            // TenSH
            // 
            this.TenSH.DataPropertyName = "TenSH";
            this.TenSH.HeaderText = "Tên Sách";
            this.TenSH.MinimumWidth = 6;
            this.TenSH.Name = "TenSH";
            this.TenSH.ReadOnly = true;
            this.TenSH.Width = 125;
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "TheLoai";
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            this.TheLoai.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 125;
            // 
            // SLTonKho
            // 
            this.SLTonKho.DataPropertyName = "SLTonKho";
            this.SLTonKho.HeaderText = "Số lượng tồn";
            this.SLTonKho.MinimumWidth = 6;
            this.SLTonKho.Name = "SLTonKho";
            this.SLTonKho.ReadOnly = true;
            this.SLTonKho.Width = 125;
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.MinimumWidth = 6;
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.ReadOnly = true;
            this.MaNXB.Width = 125;
            // 
            // MATGCHINh
            // 
            this.MATGCHINh.DataPropertyName = "MATGCHINh";
            this.MATGCHINh.HeaderText = "Mã TG Chính";
            this.MATGCHINh.MinimumWidth = 6;
            this.MATGCHINh.Name = "MATGCHINh";
            this.MATGCHINh.ReadOnly = true;
            this.MATGCHINh.Width = 125;
            // 
            // MAKHo
            // 
            this.MAKHo.DataPropertyName = "MAKHo";
            this.MAKHo.HeaderText = "Mã Kho";
            this.MAKHo.MinimumWidth = 6;
            this.MAKHo.Name = "MAKHo";
            this.MAKHo.ReadOnly = true;
            this.MAKHo.Width = 125;
            // 
            // TenTGChinh
            // 
            this.TenTGChinh.DataPropertyName = "TenTGChinh";
            this.TenTGChinh.HeaderText = "Tên Tác Giả Chính";
            this.TenTGChinh.MinimumWidth = 6;
            this.TenTGChinh.Name = "TenTGChinh";
            this.TenTGChinh.ReadOnly = true;
            this.TenTGChinh.Width = 125;
            // 
            // tennxb
            // 
            this.tennxb.DataPropertyName = "tennxb";
            this.tennxb.HeaderText = "Tên NXB";
            this.tennxb.MinimumWidth = 6;
            this.tennxb.Name = "tennxb";
            this.tennxb.ReadOnly = true;
            this.tennxb.Width = 125;
            // 
            // tenkho
            // 
            this.tenkho.DataPropertyName = "tenkho";
            this.tenkho.HeaderText = "Tên Kho";
            this.tenkho.MinimumWidth = 6;
            this.tenkho.Name = "tenkho";
            this.tenkho.ReadOnly = true;
            this.tenkho.Width = 125;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1260, 734);
            this.Controls.Add(this.dgv_Sach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnThoat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSach";
            this.Text = "frmSach";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSach_FormClosing);
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_TheLoai;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btn_Moi_NV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_MaKho;
        private System.Windows.Forms.ComboBox cbo_NXB;
        private System.Windows.Forms.ComboBox cbo_TacGia;
        private System.Windows.Forms.DataGridView dgv_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATGCHINh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTGChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkho;


    }
}