namespace QuanLyNhaSach.GiaoDien
{
    partial class frmBaoCaoTonKho
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
            this.lbtongton = new System.Windows.Forms.Label();
            this.btxuat = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btloc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtheloai = new System.Windows.Forms.ComboBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbtongno = new System.Windows.Forms.Label();
            this.lbsokhach = new System.Windows.Forms.Label();
            this.cbKho = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtongton
            // 
            this.lbtongton.AutoSize = true;
            this.lbtongton.Location = new System.Drawing.Point(154, 293);
            this.lbtongton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtongton.Name = "lbtongton";
            this.lbtongton.Size = new System.Drawing.Size(0, 16);
            this.lbtongton.TabIndex = 15;
            // 
            // btxuat
            // 
            this.btxuat.Location = new System.Drawing.Point(716, 268);
            this.btxuat.Margin = new System.Windows.Forms.Padding(4);
            this.btxuat.Name = "btxuat";
            this.btxuat.Size = new System.Drawing.Size(100, 28);
            this.btxuat.TabIndex = 14;
            this.btxuat.Text = "Xuất";
            this.btxuat.UseVisualStyleBackColor = true;
            this.btxuat.Click += new System.EventHandler(this.btxuat_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(958, 268);
            this.btthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(100, 28);
            this.btthoat.TabIndex = 13;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btloc
            // 
            this.btloc.Location = new System.Drawing.Point(836, 268);
            this.btloc.Margin = new System.Windows.Forms.Padding(4);
            this.btloc.Name = "btloc";
            this.btloc.Size = new System.Drawing.Size(100, 28);
            this.btloc.TabIndex = 12;
            this.btloc.Text = "Lọc lại ";
            this.btloc.UseVisualStyleBackColor = true;
            this.btloc.Click += new System.EventHandler(this.btloc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng tồn kho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(423, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Báo cáo tồn kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbKho);
            this.groupBox1.Controls.Add(this.cbtheloai);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1011, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách theo thông tin";
            // 
            // cbtheloai
            // 
            this.cbtheloai.FormattingEnabled = true;
            this.cbtheloai.Location = new System.Drawing.Point(493, 48);
            this.cbtheloai.Margin = new System.Windows.Forms.Padding(4);
            this.cbtheloai.Name = "cbtheloai";
            this.cbtheloai.Size = new System.Drawing.Size(299, 24);
            this.cbtheloai.TabIndex = 3;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(137, 49);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(233, 22);
            this.txtten.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thể loại: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 335);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 270);
            this.dataGridView1.TabIndex = 8;
            // 
            // lbtongno
            // 
            this.lbtongno.AutoSize = true;
            this.lbtongno.Location = new System.Drawing.Point(195, 293);
            this.lbtongno.Name = "lbtongno";
            this.lbtongno.Size = new System.Drawing.Size(0, 16);
            this.lbtongno.TabIndex = 16;
            // 
            // lbsokhach
            // 
            this.lbsokhach.AutoSize = true;
            this.lbsokhach.Location = new System.Drawing.Point(285, 293);
            this.lbsokhach.Name = "lbsokhach";
            this.lbsokhach.Size = new System.Drawing.Size(0, 16);
            this.lbsokhach.TabIndex = 17;
            // 
            // cbKho
            // 
            this.cbKho.FormattingEnabled = true;
            this.cbKho.Location = new System.Drawing.Point(137, 86);
            this.cbKho.Margin = new System.Windows.Forms.Padding(4);
            this.cbKho.Name = "cbKho";
            this.cbKho.Size = new System.Drawing.Size(233, 24);
            this.cbKho.TabIndex = 4;
            this.cbKho.SelectedIndexChanged += new System.EventHandler(this.cbKho_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kho:";
            // 
            // frmBaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 668);
            this.Controls.Add(this.lbsokhach);
            this.Controls.Add(this.lbtongno);
            this.Controls.Add(this.lbtongton);
            this.Controls.Add(this.btxuat);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btloc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBaoCaoTonKho";
            this.Text = "frmBaoCaoTonKho";
            this.Load += new System.EventHandler(this.frmBaoCaoTonKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtongton;
        private System.Windows.Forms.Button btxuat;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btloc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbtheloai;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbtongno;
        private System.Windows.Forms.Label lbsokhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKho;
    }
}