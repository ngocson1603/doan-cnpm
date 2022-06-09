namespace GUI
{
    partial class frmDonDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonDatHang));
            this.grbChiTietDonDatHang = new System.Windows.Forms.GroupBox();
            this.dgvChiTietDonDatHang = new System.Windows.Forms.DataGridView();
            this.MaDDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.grbDonDatHan = new System.Windows.Forms.GroupBox();
            this.dgvDonDatHang = new System.Windows.Forms.DataGridView();
            this.MaDonDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhaPhanPhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbbSanPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNhaPhanPhoi = new System.Windows.Forms.ComboBox();
            this.cbbNhanVienLap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnTaoDonDatHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDonDatHang = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbChiTietDonDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonDatHang)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grbDonDatHan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.grbDonDatHang.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChiTietDonDatHang
            // 
            this.grbChiTietDonDatHang.Controls.Add(this.dgvChiTietDonDatHang);
            this.grbChiTietDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChiTietDonDatHang.Location = new System.Drawing.Point(728, 335);
            this.grbChiTietDonDatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbChiTietDonDatHang.Name = "grbChiTietDonDatHang";
            this.grbChiTietDonDatHang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbChiTietDonDatHang.Size = new System.Drawing.Size(720, 329);
            this.grbChiTietDonDatHang.TabIndex = 7;
            this.grbChiTietDonDatHang.TabStop = false;
            this.grbChiTietDonDatHang.Text = "Chi tiết đơn đặt hàng";
            // 
            // dgvChiTietDonDatHang
            // 
            this.dgvChiTietDonDatHang.AllowUserToAddRows = false;
            this.dgvChiTietDonDatHang.AllowUserToDeleteRows = false;
            this.dgvChiTietDonDatHang.AllowUserToResizeColumns = false;
            this.dgvChiTietDonDatHang.AllowUserToResizeRows = false;
            this.dgvChiTietDonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDDH,
            this.MaSanPham,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvChiTietDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietDonDatHang.Location = new System.Drawing.Point(3, 17);
            this.dgvChiTietDonDatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTietDonDatHang.Name = "dgvChiTietDonDatHang";
            this.dgvChiTietDonDatHang.RowTemplate.Height = 28;
            this.dgvChiTietDonDatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDonDatHang.Size = new System.Drawing.Size(714, 310);
            this.dgvChiTietDonDatHang.TabIndex = 0;
            // 
            // MaDDH
            // 
            this.MaDDH.DataPropertyName = "MaDDH";
            this.MaDDH.HeaderText = "Mã đơn đặt hàng";
            this.MaDDH.Name = "MaDDH";
            this.MaDDH.ReadOnly = true;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(714, 31);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 28);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbDonDatHan
            // 
            this.grbDonDatHan.Controls.Add(this.dgvDonDatHang);
            this.grbDonDatHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDonDatHan.Location = new System.Drawing.Point(3, 335);
            this.grbDonDatHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDonDatHan.Name = "grbDonDatHan";
            this.grbDonDatHan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDonDatHan.Size = new System.Drawing.Size(719, 329);
            this.grbDonDatHan.TabIndex = 9;
            this.grbDonDatHan.TabStop = false;
            this.grbDonDatHan.Text = "Đơn đặt hàng";
            // 
            // dgvDonDatHang
            // 
            this.dgvDonDatHang.AllowUserToAddRows = false;
            this.dgvDonDatHang.AllowUserToDeleteRows = false;
            this.dgvDonDatHang.AllowUserToResizeColumns = false;
            this.dgvDonDatHang.AllowUserToResizeRows = false;
            this.dgvDonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonDatHang,
            this.NgayLap,
            this.MaNhanVien,
            this.MaNhaPhanPhoi});
            this.dgvDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonDatHang.Location = new System.Drawing.Point(3, 17);
            this.dgvDonDatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDonDatHang.Name = "dgvDonDatHang";
            this.dgvDonDatHang.RowTemplate.Height = 28;
            this.dgvDonDatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonDatHang.Size = new System.Drawing.Size(713, 310);
            this.dgvDonDatHang.TabIndex = 0;
            // 
            // MaDonDatHang
            // 
            this.MaDonDatHang.DataPropertyName = "MaDDH";
            this.MaDonDatHang.HeaderText = "Mã đơn đặt hàng";
            this.MaDonDatHang.Name = "MaDonDatHang";
            this.MaDonDatHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // MaNhaPhanPhoi
            // 
            this.MaNhaPhanPhoi.DataPropertyName = "MaNhaPhanPhoi";
            this.MaNhaPhanPhoi.HeaderText = "Mã nhà phân phối";
            this.MaNhaPhanPhoi.Name = "MaNhaPhanPhoi";
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(728, 668);
            this.btnHoanTat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(92, 41);
            this.btnHoanTat.TabIndex = 8;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(147, 170);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(181, 22);
            this.txtThanhTien.TabIndex = 11;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(147, 130);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(181, 22);
            this.txtDonGia.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đơn giá";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(499, 130);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(89, 22);
            this.txtSoLuong.TabIndex = 8;
            // 
            // cbbSanPham
            // 
            this.cbbSanPham.FormattingEnabled = true;
            this.cbbSanPham.Location = new System.Drawing.Point(147, 95);
            this.cbbSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Size = new System.Drawing.Size(307, 24);
            this.cbbSanPham.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thành Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.toolStrip1);
            this.grbThongTin.Controls.Add(this.txtThanhTien);
            this.grbThongTin.Controls.Add(this.txtDonGia);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.txtSoLuong);
            this.grbThongTin.Controls.Add(this.cbbSanPham);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTin.Location = new System.Drawing.Point(728, 2);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Size = new System.Drawing.Size(720, 329);
            this.grbThongTin.TabIndex = 6;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin đơn đặt hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sản phẩm";
            // 
            // cbbNhaPhanPhoi
            // 
            this.cbbNhaPhanPhoi.FormattingEnabled = true;
            this.cbbNhaPhanPhoi.Location = new System.Drawing.Point(143, 97);
            this.cbbNhaPhanPhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNhaPhanPhoi.Name = "cbbNhaPhanPhoi";
            this.cbbNhaPhanPhoi.Size = new System.Drawing.Size(375, 24);
            this.cbbNhaPhanPhoi.TabIndex = 7;
            // 
            // cbbNhanVienLap
            // 
            this.cbbNhanVienLap.FormattingEnabled = true;
            this.cbbNhanVienLap.Location = new System.Drawing.Point(143, 66);
            this.cbbNhanVienLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNhanVienLap.Name = "cbbNhanVienLap";
            this.cbbNhanVienLap.Size = new System.Drawing.Size(375, 24);
            this.cbbNhanVienLap.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhà phân phối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhân viên lập";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(143, 31);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(374, 22);
            this.dtpNgayLap.TabIndex = 3;
            // 
            // btnTaoDonDatHang
            // 
            this.btnTaoDonDatHang.Location = new System.Drawing.Point(189, 148);
            this.btnTaoDonDatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoDonDatHang.Name = "btnTaoDonDatHang";
            this.btnTaoDonDatHang.Size = new System.Drawing.Size(327, 49);
            this.btnTaoDonDatHang.TabIndex = 2;
            this.btnTaoDonDatHang.Text = "Tạo đơn đặt hàng";
            this.btnTaoDonDatHang.UseVisualStyleBackColor = true;
            this.btnTaoDonDatHang.Click += new System.EventHandler(this.btnTaoDonDatHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày lập";
            // 
            // grbDonDatHang
            // 
            this.grbDonDatHang.Controls.Add(this.cbbNhaPhanPhoi);
            this.grbDonDatHang.Controls.Add(this.cbbNhanVienLap);
            this.grbDonDatHang.Controls.Add(this.label3);
            this.grbDonDatHang.Controls.Add(this.label2);
            this.grbDonDatHang.Controls.Add(this.dtpNgayLap);
            this.grbDonDatHang.Controls.Add(this.btnTaoDonDatHang);
            this.grbDonDatHang.Controls.Add(this.label1);
            this.grbDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDonDatHang.Location = new System.Drawing.Point(3, 2);
            this.grbDonDatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDonDatHang.Name = "grbDonDatHang";
            this.grbDonDatHang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDonDatHang.Size = new System.Drawing.Size(719, 329);
            this.grbDonDatHang.TabIndex = 5;
            this.grbDonDatHang.TabStop = false;
            this.grbDonDatHang.Text = "Đơn đặt hàng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grbDonDatHan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbThongTin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHoanTat, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.grbDonDatHang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbChiTietDonDatHang, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1451, 716);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 716);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDonDatHang";
            this.Text = "frmDonDatHang";
            this.Load += new System.EventHandler(this.frmDonDatHang_Load);
            this.grbChiTietDonDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonDatHang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbDonDatHan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbDonDatHang.ResumeLayout(false);
            this.grbDonDatHang.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChiTietDonDatHang;
        private System.Windows.Forms.DataGridView dgvChiTietDonDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.GroupBox grbDonDatHan;
        private System.Windows.Forms.DataGridView dgvDonDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaPhanPhoi;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbbSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbNhaPhanPhoi;
        private System.Windows.Forms.ComboBox cbbNhanVienLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Button btnTaoDonDatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDonDatHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}