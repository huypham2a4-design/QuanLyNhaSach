namespace QuanLyNhaSach.GiaoDien
{
    partial class frmBaoCaoNo
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btxem = new System.Windows.Forms.Button();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btthoat = new System.Windows.Forms.Button();
            this.btloc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btxuat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbsokhach = new System.Windows.Forms.Label();
            this.lbtongno = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(289, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "BÁO CÁO NỢ KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.btxem);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.btloc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btxuat);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(11, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1034, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khu vực lọc";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(531, 62);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // btxem
            // 
            this.btxem.Location = new System.Drawing.Point(573, 103);
            this.btxem.Margin = new System.Windows.Forms.Padding(4);
            this.btxem.Name = "btxem";
            this.btxem.Size = new System.Drawing.Size(100, 28);
            this.btxem.TabIndex = 12;
            this.btxem.Text = "Xem tất cả";
            this.btxem.UseVisualStyleBackColor = true;
            this.btxem.Click += new System.EventHandler(this.btxem_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(140, 28);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(197, 22);
            this.txtten.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thời gian:";
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(909, 103);
            this.btthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(100, 28);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btloc
            // 
            this.btloc.Location = new System.Drawing.Point(789, 103);
            this.btloc.Margin = new System.Windows.Forms.Padding(4);
            this.btloc.Name = "btloc";
            this.btloc.Size = new System.Drawing.Size(100, 28);
            this.btloc.TabIndex = 2;
            this.btloc.Text = "Lọc";
            this.btloc.UseVisualStyleBackColor = true;
            this.btloc.Click += new System.EventHandler(this.btloc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên khách hàng:";
            // 
            // btxuat
            // 
            this.btxuat.Location = new System.Drawing.Point(681, 103);
            this.btxuat.Margin = new System.Windows.Forms.Padding(4);
            this.btxuat.Name = "btxuat";
            this.btxuat.Size = new System.Drawing.Size(100, 28);
            this.btxuat.TabIndex = 1;
            this.btxuat.Text = "Xuất";
            this.btxuat.UseVisualStyleBackColor = true;
            this.btxuat.Click += new System.EventHandler(this.btxuat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 28);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-48, 189);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 273);
            this.dataGridView1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbsokhach);
            this.groupBox2.Controls.Add(this.lbtongno);
            this.groupBox2.Location = new System.Drawing.Point(11, 470);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1009, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê tổng cộng";
            // 
            // lbsokhach
            // 
            this.lbsokhach.AutoSize = true;
            this.lbsokhach.Location = new System.Drawing.Point(8, 47);
            this.lbsokhach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsokhach.Name = "lbsokhach";
            this.lbsokhach.Size = new System.Drawing.Size(118, 16);
            this.lbsokhach.TabIndex = 8;
            this.lbsokhach.Text = "Số khách đang nợ:";
            // 
            // lbtongno
            // 
            this.lbtongno.AutoSize = true;
            this.lbtongno.Location = new System.Drawing.Point(8, 20);
            this.lbtongno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtongno.Name = "lbtongno";
            this.lbtongno.Size = new System.Drawing.Size(195, 16);
            this.lbtongno.TabIndex = 7;
            this.lbtongno.Text = "Tổng nợ của tất cả khách hàng: ";
            // 
            // frmBaoCaoNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 624);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBaoCaoNo";
            this.Text = "frmBaoCaoNo";
            this.Load += new System.EventHandler(this.frmBaoCaoNo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btxem;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btloc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btxuat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbsokhach;
        private System.Windows.Forms.Label lbtongno;
    }
}