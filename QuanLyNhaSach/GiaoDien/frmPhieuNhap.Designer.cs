namespace QuanLyNhaSach.GiaoDien
{
    partial class frmPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_mancc = new System.Windows.Forms.ComboBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnbsct = new System.Windows.Forms.Button();
            this.btn_Moi_PN = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txt_MaNhap = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DSPN = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPN)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 371);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 20);
            this.label12.TabIndex = 57;
            this.label12.Text = "Danh sách phiếu nhập:";
            // 
            // cbo_mancc
            // 
            this.cbo_mancc.DisplayMember = "MANCC";
            this.cbo_mancc.FormattingEnabled = true;
            this.cbo_mancc.Location = new System.Drawing.Point(255, 143);
            this.cbo_mancc.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_mancc.Name = "cbo_mancc";
            this.cbo_mancc.Size = new System.Drawing.Size(336, 24);
            this.cbo_mancc.TabIndex = 67;
            this.cbo_mancc.ValueMember = "MANCC";
            // 
            // txt_manv
            // 
            this.txt_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_manv.Location = new System.Drawing.Point(255, 84);
            this.txt_manv.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(336, 30);
            this.txt_manv.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Mã Nhà Cung Cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnbsct);
            this.groupBox3.Controls.Add(this.btn_Moi_PN);
            this.groupBox3.Controls.Add(this.cbo_mancc);
            this.groupBox3.Controls.Add(this.txt_manv);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnHuy);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.txt_MaNhap);
            this.groupBox3.Controls.Add(this.dtpNgay);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(29, 50);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1041, 324);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin nhập sách";
            // 
            // btnbsct
            // 
            this.btnbsct.Location = new System.Drawing.Point(789, 272);
            this.btnbsct.Name = "btnbsct";
            this.btnbsct.Size = new System.Drawing.Size(130, 46);
            this.btnbsct.TabIndex = 69;
            this.btnbsct.Text = "Chi Tiet";
            this.btnbsct.UseVisualStyleBackColor = true;
            this.btnbsct.Click += new System.EventHandler(this.btnbsct_Click_1);
            // 
            // btn_Moi_PN
            // 
            this.btn_Moi_PN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Moi_PN.Image = ((System.Drawing.Image)(resources.GetObject("btn_Moi_PN.Image")));
            this.btn_Moi_PN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Moi_PN.Location = new System.Drawing.Point(425, 272);
            this.btn_Moi_PN.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Moi_PN.Name = "btn_Moi_PN";
            this.btn_Moi_PN.Size = new System.Drawing.Size(151, 44);
            this.btn_Moi_PN.TabIndex = 68;
            this.btn_Moi_PN.Text = "Làm Mới";
            this.btn_Moi_PN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Moi_PN.UseVisualStyleBackColor = true;
            this.btn_Moi_PN.Click += new System.EventHandler(this.btn_Moi_PN_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(280, 272);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 44);
            this.btnXoa.TabIndex = 63;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(623, 268);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(143, 52);
            this.btnHuy.TabIndex = 60;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(147, 273);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 44);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "  SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(13, 272);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 46);
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "  THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txt_MaNhap
            // 
            this.txt_MaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_MaNhap.Location = new System.Drawing.Point(255, 30);
            this.txt_MaNhap.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_MaNhap.Name = "txt_MaNhap";
            this.txt_MaNhap.Size = new System.Drawing.Size(336, 30);
            this.txt_MaNhap.TabIndex = 29;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "\'Ngày\' dd \'Tháng\' MM \'Năm\' yyyy";
            this.dtpNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(255, 191);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(336, 30);
            this.dtpNgay.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ngày nhập:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Mã phiếu nhập:";
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "ngaynhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            this.NgayNhap.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "manv";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 125;
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "MaPN";
            this.MaPN.HeaderText = "Mã Phiếu Nhập";
            this.MaPN.MinimumWidth = 6;
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            this.MaPN.Width = 125;
            // 
            // Mancc
            // 
            this.Mancc.DataPropertyName = "mancc";
            this.Mancc.HeaderText = "Mã nhà cung cấp ";
            this.Mancc.MinimumWidth = 6;
            this.Mancc.Name = "Mancc";
            this.Mancc.ReadOnly = true;
            this.Mancc.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(423, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 55;
            this.label1.Text = "PHIẾU NHẬP SÁCH";
            // 
            // dgv_DSPN
            // 
            this.dgv_DSPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.MaNV,
            this.Mancc,
            this.NgayNhap});
            this.dgv_DSPN.Location = new System.Drawing.Point(29, 395);
            this.dgv_DSPN.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DSPN.Name = "dgv_DSPN";
            this.dgv_DSPN.RowHeadersWidth = 51;
            this.dgv_DSPN.Size = new System.Drawing.Size(1041, 229);
            this.dgv_DSPN.TabIndex = 58;
            this.dgv_DSPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSPN_CellClick);
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 728);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DSPN);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhapcs";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load_1);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_mancc;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Moi_PN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txt_MaNhap;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mancc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DSPN;
        private System.Windows.Forms.Button btnbsct;
    }
}