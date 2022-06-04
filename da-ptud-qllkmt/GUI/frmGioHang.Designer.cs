namespace GUI
{
    partial class frmGioHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.dateTimeNgay = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataExcel = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 66);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 66);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(361, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 66);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(361, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 66);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(719, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 66);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày lập hóa đơn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(407, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Giỏ hàng của bạn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 198);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Button4, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeNgay, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTongTien, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMaSP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtGiaTien, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTK, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2Button2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2Button3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSL, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1080, 198);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // guna2Button4
            // 
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 21;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button4.Location = new System.Drawing.Point(898, 69);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.BorderRadius = 26;
            this.guna2Button4.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button4.ShadowDecoration.Enabled = true;
            this.guna2Button4.Size = new System.Drawing.Size(111, 45);
            this.guna2Button4.TabIndex = 20;
            this.guna2Button4.Text = "Xuất Excel";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // dateTimeNgay
            // 
            this.dateTimeNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgay.Location = new System.Drawing.Point(898, 3);
            this.dateTimeNgay.Name = "dateTimeNgay";
            this.dateTimeNgay.Size = new System.Drawing.Size(179, 20);
            this.dateTimeNgay.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(182, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 9;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(540, 135);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(173, 20);
            this.txtTongTien.TabIndex = 14;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(182, 69);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(173, 20);
            this.txtMaSP.TabIndex = 10;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaTien.Enabled = false;
            this.txtGiaTien.Location = new System.Drawing.Point(540, 69);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(173, 20);
            this.txtGiaTien.TabIndex = 13;
            // 
            // txtTK
            // 
            this.txtTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTK.Enabled = false;
            this.txtTK.Location = new System.Drawing.Point(182, 135);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(173, 20);
            this.txtTK.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(361, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 66);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng tiền";
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Enabled = false;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(898, 135);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.BorderRadius = 26;
            this.guna2Button2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button2.ShadowDecoration.Enabled = true;
            this.guna2Button2.Size = new System.Drawing.Size(111, 45);
            this.guna2Button2.TabIndex = 20;
            this.guna2Button2.Text = "Hủy đơn";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 21;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Enabled = false;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(719, 69);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.BorderRadius = 26;
            this.guna2Button3.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button3.ShadowDecoration.Enabled = true;
            this.guna2Button3.Size = new System.Drawing.Size(111, 45);
            this.guna2Button3.TabIndex = 21;
            this.guna2Button3.Text = "In hóa đơn";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // txtSL
            // 
            this.txtSL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSL.Enabled = false;
            this.txtSL.Location = new System.Drawing.Point(540, 3);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(173, 20);
            this.txtSL.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataExcel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 56);
            this.panel2.TabIndex = 11;
            // 
            // dataExcel
            // 
            this.dataExcel.AllowUserToAddRows = false;
            this.dataExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExcel.GridColor = System.Drawing.SystemColors.Control;
            this.dataExcel.Location = new System.Drawing.Point(34, 29);
            this.dataExcel.Name = "dataExcel";
            this.dataExcel.Size = new System.Drawing.Size(10, 10);
            this.dataExcel.TabIndex = 11;
            this.dataExcel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 425);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(723, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 425);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 679);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGioHang";
            this.Text = "frmGioHang";
            this.Load += new System.EventHandler(this.frmGioHang_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.DateTimePicker dateTimeNgay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.DataGridView dataExcel;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}