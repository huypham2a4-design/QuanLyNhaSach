namespace QuanLyNhaSach.GiaoDien
{
    partial class DangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.lbl_QLNS = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_PhanQuyen = new System.Windows.Forms.GroupBox();
            this.rdo_QuanLy = new System.Windows.Forms.RadioButton();
            this.rdo_NhanVien = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat1 = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbGhiNhoTK = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gb_PhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_QLNS
            // 
            this.lbl_QLNS.AutoSize = true;
            this.lbl_QLNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLNS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_QLNS.Location = new System.Drawing.Point(124, 32);
            this.lbl_QLNS.Name = "lbl_QLNS";
            this.lbl_QLNS.Size = new System.Drawing.Size(430, 46);
            this.lbl_QLNS.TabIndex = 73;
            this.lbl_QLNS.Text = "QUẢN LÝ NHÀ SÁCH";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gb_PhanQuyen
            // 
            this.gb_PhanQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gb_PhanQuyen.Controls.Add(this.rdo_QuanLy);
            this.gb_PhanQuyen.Controls.Add(this.rdo_NhanVien);
            this.gb_PhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_PhanQuyen.Location = new System.Drawing.Point(205, 274);
            this.gb_PhanQuyen.Name = "gb_PhanQuyen";
            this.gb_PhanQuyen.Size = new System.Drawing.Size(302, 61);
            this.gb_PhanQuyen.TabIndex = 4;
            this.gb_PhanQuyen.TabStop = false;
            this.gb_PhanQuyen.Text = "Quyền người dùng";
            // 
            // rdo_QuanLy
            // 
            this.rdo_QuanLy.AutoSize = true;
            this.rdo_QuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_QuanLy.Location = new System.Drawing.Point(13, 27);
            this.rdo_QuanLy.Name = "rdo_QuanLy";
            this.rdo_QuanLy.Size = new System.Drawing.Size(110, 24);
            this.rdo_QuanLy.TabIndex = 4;
            this.rdo_QuanLy.TabStop = true;
            this.rdo_QuanLy.Text = "QUẢN LÝ";
            this.rdo_QuanLy.UseVisualStyleBackColor = true;
            // 
            // rdo_NhanVien
            // 
            this.rdo_NhanVien.AutoSize = true;
            this.rdo_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_NhanVien.Location = new System.Drawing.Point(148, 27);
            this.rdo_NhanVien.Name = "rdo_NhanVien";
            this.rdo_NhanVien.Size = new System.Drawing.Size(130, 24);
            this.rdo_NhanVien.TabIndex = 4;
            this.rdo_NhanVien.TabStop = true;
            this.rdo_NhanVien.Text = "NHÂN VIÊN";
            this.rdo_NhanVien.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 35);
            this.label3.TabIndex = 90;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(205, 208);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(302, 31);
            this.txt_MatKhau.TabIndex = 2;
            this.txt_MatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_DangNhap_KeyDown);
            this.txt_MatKhau.Leave += new System.EventHandler(this.txt_MatKhau_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "MẬT KHẨU";
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(205, 152);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(302, 31);
            this.txt_TaiKhoan.TabIndex = 1;
            this.txt_TaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_DangNhap_KeyDown);
            this.txt_TaiKhoan.Leave += new System.EventHandler(this.txt_TaiKhoan_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(87, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 83;
            this.label1.Text = "TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Thoat1
            // 
            this.btn_Thoat1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Thoat1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat1.Location = new System.Drawing.Point(366, 351);
            this.btn_Thoat1.Name = "btn_Thoat1";
            this.btn_Thoat1.Size = new System.Drawing.Size(154, 46);
            this.btn_Thoat1.TabIndex = 6;
            this.btn_Thoat1.Text = "THOÁT";
            this.btn_Thoat1.UseVisualStyleBackColor = false;
            this.btn_Thoat1.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Location = new System.Drawing.Point(180, 351);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(154, 46);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "ĐĂNG NHẬP";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            this.btn_DangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_DangNhap_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // cbGhiNhoTK
            // 
            this.cbGhiNhoTK.AutoSize = true;
            this.cbGhiNhoTK.BackColor = System.Drawing.Color.Transparent;
            this.cbGhiNhoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGhiNhoTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbGhiNhoTK.Location = new System.Drawing.Point(205, 246);
            this.cbGhiNhoTK.Margin = new System.Windows.Forms.Padding(4);
            this.cbGhiNhoTK.Name = "cbGhiNhoTK";
            this.cbGhiNhoTK.Size = new System.Drawing.Size(159, 21);
            this.cbGhiNhoTK.TabIndex = 91;
            this.cbGhiNhoTK.Text = "Ghi nhớ tài khoản";
            this.cbGhiNhoTK.UseVisualStyleBackColor = false;
            this.cbGhiNhoTK.CheckedChanged += new System.EventHandler(this.cbGhiNhoTK_CheckedChanged);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 432);
            this.Controls.Add(this.cbGhiNhoTK);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.gb_PhanQuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat1);
            this.Controls.Add(this.lbl_QLNS);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập Hệ thống";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gb_PhanQuyen.ResumeLayout(false);
            this.gb_PhanQuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QLNS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gb_PhanQuyen;
        private System.Windows.Forms.RadioButton rdo_QuanLy;
        private System.Windows.Forms.RadioButton rdo_NhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat1;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.CheckBox cbGhiNhoTK;

    }
}