namespace GUI
{
    partial class frmDonDatHang_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonDatHang_v2));
            this.grbDonDatHang = new System.Windows.Forms.GroupBox();
            this.cbbNhaPhanPhoi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNhanVienLap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.dgvChiTietDonDatHang = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbbSanPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.grbDonDatHang.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonDatHang)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDonDatHang
            // 
            this.grbDonDatHang.Controls.Add(this.cbbNhaPhanPhoi);
            this.grbDonDatHang.Controls.Add(this.label3);
            this.grbDonDatHang.Controls.Add(this.cbbNhanVienLap);
            this.grbDonDatHang.Controls.Add(this.label2);
            this.grbDonDatHang.Controls.Add(this.dtpNgayLap);
            this.grbDonDatHang.Controls.Add(this.label1);
            this.grbDonDatHang.Location = new System.Drawing.Point(12, 11);
            this.grbDonDatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDonDatHang.Name = "grbDonDatHang";
            this.grbDonDatHang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDonDatHang.Size = new System.Drawing.Size(331, 127);
            this.grbDonDatHang.TabIndex = 6;
            this.grbDonDatHang.TabStop = false;
            this.grbDonDatHang.Text = "Đơn đặt hàng";
            // 
            // cbbNhaPhanPhoi
            // 
            this.cbbNhaPhanPhoi.FormattingEnabled = true;
            this.cbbNhaPhanPhoi.Location = new System.Drawing.Point(121, 85);
            this.cbbNhaPhanPhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNhaPhanPhoi.Name = "cbbNhaPhanPhoi";
            this.cbbNhaPhanPhoi.Size = new System.Drawing.Size(185, 24);
            this.cbbNhaPhanPhoi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhà phân phối";
            // 
            // cbbNhanVienLap
            // 
            this.cbbNhanVienLap.FormattingEnabled = true;
            this.cbbNhanVienLap.Location = new System.Drawing.Point(121, 57);
            this.cbbNhanVienLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNhanVienLap.Name = "cbbNhanVienLap";
            this.cbbNhanVienLap.Size = new System.Drawing.Size(185, 24);
            this.cbbNhanVienLap.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhân viên lập";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(121, 31);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(185, 22);
            this.dtpNgayLap.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày lập";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.dgvChiTietDonDatHang);
            this.grbThongTin.Controls.Add(this.toolStrip1);
            this.grbThongTin.Controls.Add(this.txtThanhTien);
            this.grbThongTin.Controls.Add(this.txtDonGia);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.txtSoLuong);
            this.grbThongTin.Controls.Add(this.cbbSanPham);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Location = new System.Drawing.Point(349, 11);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTin.Size = new System.Drawing.Size(720, 527);
            this.grbThongTin.TabIndex = 7;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin đơn đặt hàng";
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
            this.MaSanPham,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvChiTietDonDatHang.Location = new System.Drawing.Point(0, 201);
            this.dgvChiTietDonDatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTietDonDatHang.Name = "dgvChiTietDonDatHang";
            this.dgvChiTietDonDatHang.RowTemplate.Height = 28;
            this.dgvChiTietDonDatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDonDatHang.Size = new System.Drawing.Size(708, 322);
            this.dgvChiTietDonDatHang.TabIndex = 13;
            this.dgvChiTietDonDatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietDonDatHang_CellClick);
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
            this.btnThem,
            this.btnXoa});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(714, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 24);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 24);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(544, 110);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(142, 22);
            this.txtThanhTien.TabIndex = 11;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(91, 110);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(142, 22);
            this.txtDonGia.TabIndex = 10;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đơn giá";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(309, 110);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(142, 22);
            this.txtSoLuong.TabIndex = 8;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // cbbSanPham
            // 
            this.cbbSanPham.FormattingEnabled = true;
            this.cbbSanPham.Location = new System.Drawing.Point(91, 53);
            this.cbbSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Size = new System.Drawing.Size(360, 24);
            this.cbbSanPham.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thành Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sản phẩm";
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(352, 582);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(300, 23);
            this.btnDatHang.TabIndex = 8;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // frmDonDatHang_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 716);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grbDonDatHang);
            this.Name = "frmDonDatHang_v2";
            this.Text = "frmDonDatHang_v2";
            this.Load += new System.EventHandler(this.frmDonDatHang_v2_Load);
            this.grbDonDatHang.ResumeLayout(false);
            this.grbDonDatHang.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonDatHang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDonDatHang;
        private System.Windows.Forms.ComboBox cbbNhaPhanPhoi;
        private System.Windows.Forms.ComboBox cbbNhanVienLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbbSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.DataGridView dgvChiTietDonDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnDatHang;

    }
}