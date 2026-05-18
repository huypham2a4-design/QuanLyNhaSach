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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTimTheLoai = new System.Windows.Forms.ComboBox();
            this.radTenSach = new System.Windows.Forms.RadioButton();
            this.radTacGia = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txt_TheLoai = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_TacGia = new System.Windows.Forms.TextBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_NXB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.btnchon = new System.Windows.Forms.Button();
            this.dgv_Sach = new System.Windows.Forms.DataGridView();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(759, 162);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 42);
            this.btnLuu.TabIndex = 54;
            this.btnLuu.Text = " LƯU    ";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(759, 79);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 36);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "  XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Thể loại:";
            // 
            // cbTimTheLoai
            // 
            this.cbTimTheLoai.FormattingEnabled = true;
            this.cbTimTheLoai.Location = new System.Drawing.Point(436, 36);
            this.cbTimTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbTimTheLoai.Name = "cbTimTheLoai";
            this.cbTimTheLoai.Size = new System.Drawing.Size(188, 28);
            this.cbTimTheLoai.TabIndex = 15;
            // 
            // radTenSach
            // 
            this.radTenSach.AutoSize = true;
            this.radTenSach.Location = new System.Drawing.Point(727, 41);
            this.radTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.radTenSach.Name = "radTenSach";
            this.radTenSach.Size = new System.Drawing.Size(99, 24);
            this.radTenSach.TabIndex = 13;
            this.radTenSach.TabStop = true;
            this.radTenSach.Text = "Tên sách";
            this.radTenSach.UseVisualStyleBackColor = true;
            // 
            // radTacGia
            // 
            this.radTacGia.AutoSize = true;
            this.radTacGia.Location = new System.Drawing.Point(844, 41);
            this.radTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.radTacGia.Name = "radTacGia";
            this.radTacGia.Size = new System.Drawing.Size(85, 24);
            this.radTacGia.TabIndex = 12;
            this.radTacGia.TabStop = true;
            this.radTacGia.Text = "Tác giả";
            this.radTacGia.UseVisualStyleBackColor = true;
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Location = new System.Drawing.Point(633, 41);
            this.radTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(77, 24);
            this.radTatCa.TabIndex = 11;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(117, 36);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(200, 29);
            this.txt_TimKiem.TabIndex = 10;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(759, 122);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 33);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "  SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(759, 36);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 34);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "  THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txt_TheLoai
            // 
            this.txt_TheLoai.Location = new System.Drawing.Point(151, 122);
            this.txt_TheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TheLoai.Name = "txt_TheLoai";
            this.txt_TheLoai.Size = new System.Drawing.Size(207, 30);
            this.txt_TheLoai.TabIndex = 11;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Location = new System.Drawing.Point(151, 84);
            this.txt_TenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(207, 30);
            this.txt_TenSach.TabIndex = 10;
            // 
            // txt_TacGia
            // 
            this.txt_TacGia.Location = new System.Drawing.Point(511, 43);
            this.txt_TacGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TacGia.Name = "txt_TacGia";
            this.txt_TacGia.Size = new System.Drawing.Size(208, 30);
            this.txt_TacGia.TabIndex = 9;
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Location = new System.Drawing.Point(151, 46);
            this.txt_MaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(207, 30);
            this.txt_MaSach.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 47);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Danh sách Sách:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.PeachPuff;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(835, 151);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 47);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTimTheLoai);
            this.groupBox1.Controls.Add(this.radTenSach);
            this.groupBox1.Controls.Add(this.radTacGia);
            this.groupBox1.Controls.Add(this.radTatCa);
            this.groupBox1.Controls.Add(this.txt_TimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(932, 90);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Sách theo thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_NXB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_DonGia);
            this.groupBox2.Controls.Add(this.txt_SoLuong);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txt_TheLoai);
            this.groupBox2.Controls.Add(this.txt_TenSach);
            this.groupBox2.Controls.Add(this.txt_TacGia);
            this.groupBox2.Controls.Add(this.txt_MaSach);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(34, 420);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(960, 212);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Sách";
            // 
            // txt_NXB
            // 
            this.txt_NXB.Location = new System.Drawing.Point(187, 166);
            this.txt_NXB.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NXB.Name = "txt_NXB";
            this.txt_NXB.Size = new System.Drawing.Size(207, 30);
            this.txt_NXB.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 56;
            this.label11.Text = "Nhà Xuất bản:";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(509, 83);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(208, 30);
            this.txt_DonGia.TabIndex = 45;
            this.txt_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonGia_KeyPress);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(509, 127);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(208, 30);
            this.txt_SoLuong.TabIndex = 55;
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // btnchon
            // 
            this.btnchon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnchon.BackgroundImage")));
            this.btnchon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.ForeColor = System.Drawing.Color.White;
            this.btnchon.Location = new System.Drawing.Point(554, 154);
            this.btnchon.Margin = new System.Windows.Forms.Padding(4);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(100, 41);
            this.btnchon.TabIndex = 43;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            // 
            // dgv_Sach
            // 
            this.dgv_Sach.AllowUserToOrderColumns = true;
            this.dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sach.Location = new System.Drawing.Point(34, 205);
            this.dgv_Sach.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Sach.Name = "dgv_Sach";
            this.dgv_Sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Sach.Size = new System.Drawing.Size(960, 191);
            this.dgv_Sach.TabIndex = 39;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.LightGreen;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(683, 151);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(144, 47);
            this.btnLoc.TabIndex = 38;
            this.btnLoc.Text = "LỌC LẠI";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "DANH SÁCH SÁCH";
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1017, 656);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.dgv_Sach);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTimTheLoai;
        private System.Windows.Forms.RadioButton radTenSach;
        private System.Windows.Forms.RadioButton radTacGia;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txt_TheLoai;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.TextBox txt_TacGia;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.DataGridView dgv_Sach;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_NXB;
        private System.Windows.Forms.Label label11;

    }
}