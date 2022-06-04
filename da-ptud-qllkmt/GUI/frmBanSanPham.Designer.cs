namespace GUI
{
    partial class frmBanSanPham
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
            this.dataExcel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaHoaDon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Chitiethoadon = new System.Windows.Forms.DataGridView();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btn_ThemHD = new System.Windows.Forms.ToolStripButton();
            this.btn_XoaHD = new System.Windows.Forms.ToolStripButton();
            this.btn_SuaHD = new System.Windows.Forms.ToolStripButton();
            this.btn_Xuat = new System.Windows.Forms.ToolStripButton();
            this.dgv_chitiet = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataExcel)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chitiethoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataExcel
            // 
            this.dataExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExcel.Location = new System.Drawing.Point(431, 56);
            this.dataExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataExcel.Name = "dataExcel";
            this.dataExcel.RowTemplate.Height = 24;
            this.dataExcel.Size = new System.Drawing.Size(10, 10);
            this.dataExcel.TabIndex = 101;
            this.dataExcel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2Button3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_MaHoaDon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(427, 173);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 19;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Enabled = false;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::GUI.Properties.Resources.sell;
            this.guna2Button3.Location = new System.Drawing.Point(190, 106);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.BorderRadius = 26;
            this.guna2Button3.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button3.ShadowDecoration.Enabled = true;
            this.guna2Button3.Size = new System.Drawing.Size(104, 40);
            this.guna2Button3.TabIndex = 103;
            this.guna2Button3.Text = "Chọn Sản Phẩm";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 102;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 101;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(84, 103);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(87, 20);
            this.txt_TongTien.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "Tổng tiền";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(323, 23);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 97;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Location = new System.Drawing.Point(323, 73);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(100, 20);
            this.txt_MaNV.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Mã Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Ngày lập hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Mã KH";
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.Location = new System.Drawing.Point(84, 20);
            this.txt_MaHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.Size = new System.Drawing.Size(87, 20);
            this.txt_MaHoaDon.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Mã Hóa Đơn";
            // 
            // dgv_Chitiethoadon
            // 
            this.dgv_Chitiethoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Chitiethoadon.Location = new System.Drawing.Point(4, 404);
            this.dgv_Chitiethoadon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Chitiethoadon.Name = "dgv_Chitiethoadon";
            this.dgv_Chitiethoadon.Size = new System.Drawing.Size(861, 150);
            this.dgv_Chitiethoadon.TabIndex = 96;
            this.dgv_Chitiethoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Chitiethoadon_CellClick);
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Location = new System.Drawing.Point(4, 232);
            this.dgv_HoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.Size = new System.Drawing.Size(459, 158);
            this.dgv_HoaDon.TabIndex = 95;
            this.dgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(330, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 33);
            this.label2.TabIndex = 94;
            this.label2.Text = "Thông tin linh kiện bán ra\r\n";
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ThemHD,
            this.btn_XoaHD,
            this.btn_SuaHD,
            this.btn_Xuat});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(874, 27);
            this.toolStrip3.TabIndex = 98;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btn_ThemHD
            // 
            this.btn_ThemHD.Image = global::GUI.Properties.Resources.themhd;
            this.btn_ThemHD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ThemHD.Name = "btn_ThemHD";
            this.btn_ThemHD.Size = new System.Drawing.Size(111, 24);
            this.btn_ThemHD.Text = "Thêm Hóa Đơn";
            this.btn_ThemHD.Click += new System.EventHandler(this.btn_ThemHD_Click);
            // 
            // btn_XoaHD
            // 
            this.btn_XoaHD.Image = global::GUI.Properties.Resources.trash_can_115312;
            this.btn_XoaHD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XoaHD.Name = "btn_XoaHD";
            this.btn_XoaHD.Size = new System.Drawing.Size(101, 24);
            this.btn_XoaHD.Text = "Xóa Hóa Đơn";
            this.btn_XoaHD.Click += new System.EventHandler(this.btn_XoaHD_Click);
            // 
            // btn_SuaHD
            // 
            this.btn_SuaHD.Image = global::GUI.Properties.Resources.edithd;
            this.btn_SuaHD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SuaHD.Name = "btn_SuaHD";
            this.btn_SuaHD.Size = new System.Drawing.Size(100, 24);
            this.btn_SuaHD.Text = "Sửa Hóa Đơn";
            this.btn_SuaHD.Click += new System.EventHandler(this.btn_SuaHD_Click);
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.Enabled = false;
            this.btn_Xuat.Image = global::GUI.Properties.Resources.export_icon_icons_com_52383;
            this.btn_Xuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(105, 24);
            this.btn_Xuat.Text = "Xuất Hóa Đơn";
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // dgv_chitiet
            // 
            this.dgv_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitiet.Location = new System.Drawing.Point(467, 232);
            this.dgv_chitiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_chitiet.Name = "dgv_chitiet";
            this.dgv_chitiet.RowTemplate.Height = 24;
            this.dgv_chitiet.Size = new System.Drawing.Size(390, 158);
            this.dgv_chitiet.TabIndex = 103;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(446, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 171);
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // frmBanSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(874, 549);
            this.Controls.Add(this.dgv_chitiet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Chitiethoadon);
            this.Controls.Add(this.dgv_HoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBanSanPham";
            this.Text = "frmBanSanPham";
            this.Load += new System.EventHandler(this.frmBanSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataExcel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chitiethoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btn_ThemHD;
        private System.Windows.Forms.ToolStripButton btn_XoaHD;
        private System.Windows.Forms.ToolStripButton btn_SuaHD;
        private System.Windows.Forms.ToolStripButton btn_Xuat;
        private System.Windows.Forms.DataGridView dataExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Chitiethoadon;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgv_chitiet;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;

    }
}