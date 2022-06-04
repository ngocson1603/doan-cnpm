namespace GUI
{
    partial class frmKhachHang
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.lblTP = new System.Windows.Forms.Label();
            this.lblDP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvKhachhang = new System.Windows.Forms.DataGridView();
            this.dateTimeNgaysinhkhachhang = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHotenkh = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Diachi = new System.Windows.Forms.TextBox();
            this.txt_Gmail = new System.Windows.Forms.TextBox();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.btn_ThemKH = new System.Windows.Forms.ToolStripButton();
            this.btn_XoaKH = new System.Windows.Forms.ToolStripButton();
            this.btn_SuaKH = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ThemKH,
            this.btn_XoaKH,
            this.btn_SuaKH});
            this.toolStrip1.Location = new System.Drawing.Point(4, 19);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(490, 27);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.rbtnNu);
            this.groupBox6.Controls.Add(this.rbtnNam);
            this.groupBox6.Location = new System.Drawing.Point(75, 207);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(340, 74);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Giới tính";
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(211, 25);
            this.rbtnNu.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(47, 21);
            this.rbtnNu.TabIndex = 1;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(44, 25);
            this.rbtnNam.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(62, 21);
            this.rbtnNam.TabIndex = 0;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam ";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Location = new System.Drawing.Point(484, 77);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(0, 17);
            this.lblTP.TabIndex = 35;
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Location = new System.Drawing.Point(454, 31);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(0, 17);
            this.lblDP.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_timkiem);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(538, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 74);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(223, 20);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(176, 22);
            this.txt_timkiem.TabIndex = 32;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txtMatimkiem_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label18.Location = new System.Drawing.Point(17, 23);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 17);
            this.label18.TabIndex = 31;
            this.label18.Text = "Tìm kiếm (Mã khách hàng)";
            // 
            // dgvKhachhang
            // 
            this.dgvKhachhang.AllowUserToOrderColumns = true;
            this.dgvKhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachhang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachhang.Location = new System.Drawing.Point(21, 20);
            this.dgvKhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.RowHeadersWidth = 62;
            this.dgvKhachhang.RowTemplate.Height = 28;
            this.dgvKhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachhang.Size = new System.Drawing.Size(1079, 246);
            this.dgvKhachhang.TabIndex = 0;
            this.dgvKhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachhang_CellClick);
            // 
            // dateTimeNgaysinhkhachhang
            // 
            this.dateTimeNgaysinhkhachhang.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgaysinhkhachhang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgaysinhkhachhang.Location = new System.Drawing.Point(172, 154);
            this.dateTimeNgaysinhkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNgaysinhkhachhang.Name = "dateTimeNgaysinhkhachhang";
            this.dateTimeNgaysinhkhachhang.Size = new System.Drawing.Size(240, 22);
            this.dateTimeNgaysinhkhachhang.TabIndex = 30;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox5.Controls.Add(this.dgvKhachhang);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(35, 324);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1100, 272);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin khách hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txt_Sdt);
            this.groupBox4.Controls.Add(this.toolStrip1);
            this.groupBox4.Controls.Add(this.lblTP);
            this.groupBox4.Controls.Add(this.lblDP);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.dateTimeNgaysinhkhachhang);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtHotenkh);
            this.groupBox4.Controls.Add(this.txt_Pass);
            this.groupBox4.Controls.Add(this.txt_Diachi);
            this.groupBox4.Controls.Add(this.txt_Gmail);
            this.groupBox4.Controls.Add(this.txtMakh);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1148, 609);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quản lý khách hàng";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(553, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "SĐT";
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Sdt.Location = new System.Drawing.Point(633, 182);
            this.txt_Sdt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(229, 22);
            this.txt_Sdt.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(554, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Họ tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(82, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Pass";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(82, 154);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ngày sinh";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(553, 144);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Địa chỉ";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(554, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Gmail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(85, 63);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 19);
            this.label14.TabIndex = 8;
            this.label14.Text = "Mã KH";
            // 
            // txtHotenkh
            // 
            this.txtHotenkh.Location = new System.Drawing.Point(633, 95);
            this.txtHotenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txtHotenkh.Name = "txtHotenkh";
            this.txtHotenkh.Size = new System.Drawing.Size(229, 22);
            this.txtHotenkh.TabIndex = 7;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(172, 110);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(240, 22);
            this.txt_Pass.TabIndex = 6;
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Diachi.Location = new System.Drawing.Point(633, 139);
            this.txt_Diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(229, 22);
            this.txt_Diachi.TabIndex = 3;
            // 
            // txt_Gmail
            // 
            this.txt_Gmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Gmail.Location = new System.Drawing.Point(633, 58);
            this.txt_Gmail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Gmail.Name = "txt_Gmail";
            this.txt_Gmail.Size = new System.Drawing.Size(229, 22);
            this.txt_Gmail.TabIndex = 2;
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(172, 63);
            this.txtMakh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.ReadOnly = true;
            this.txtMakh.Size = new System.Drawing.Size(240, 22);
            this.txtMakh.TabIndex = 0;
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ThemKH.Image = global::GUI.Properties.Resources.addusergroup_1251;
            this.btn_ThemKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(154, 24);
            this.btn_ThemKH.Text = "Thêm Khách Hàng";
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_XoaKH.Image = global::GUI.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348;
            this.btn_XoaKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(143, 24);
            this.btn_XoaKH.Text = "Xóa Khách Hàng";
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.ForeColor = System.Drawing.Color.LightPink;
            this.btn_SuaKH.Image = global::GUI.Properties.Resources._3706888_assembly_control_fix_setting_108715;
            this.btn_SuaKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(142, 24);
            this.btn_SuaKH.Text = "Sửa Khách Hàng";
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 609);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_ThemKH;
        private System.Windows.Forms.ToolStripButton btn_XoaKH;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Label lblDP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvKhachhang;
        private System.Windows.Forms.DateTimePicker dateTimeNgaysinhkhachhang;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHotenkh;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_Diachi;
        private System.Windows.Forms.TextBox txt_Gmail;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.ToolStripButton btn_SuaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Sdt;
    }
}