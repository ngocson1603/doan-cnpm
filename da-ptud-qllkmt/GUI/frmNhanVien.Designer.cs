namespace GUI
{
    partial class frmNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTime_Ngayvaolam = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtchuvu = new System.Windows.Forms.TextBox();
            this.txtDiachinv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtDienthoainv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHotennv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeNgaysinhnv = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnNunv = new System.Windows.Forms.RadioButton();
            this.rbtnNamnv = new System.Windows.Forms.RadioButton();
            this.btn_ClearNV = new System.Windows.Forms.ToolStripButton();
            this.btn_ThemNV = new System.Windows.Forms.ToolStripButton();
            this.btn_SuaNV = new System.Windows.Forms.ToolStripButton();
            this.btn_XoaNV = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1160, 705);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ClearNV,
            this.btn_ThemNV,
            this.btn_SuaNV,
            this.btn_XoaNV});
            this.toolStrip1.Location = new System.Drawing.Point(4, 19);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1152, 27);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTime_Ngayvaolam);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtchuvu);
            this.groupBox5.Controls.Add(this.txtDiachinv);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtManv);
            this.groupBox5.Controls.Add(this.txtDienthoainv);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtHotennv);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.dateTimeNgaysinhnv);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(89, 130);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(855, 202);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin nhân viên:";
            // 
            // dateTime_Ngayvaolam
            // 
            this.dateTime_Ngayvaolam.CustomFormat = "dd/MM/yyyy";
            this.dateTime_Ngayvaolam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_Ngayvaolam.Location = new System.Drawing.Point(523, 79);
            this.dateTime_Ngayvaolam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_Ngayvaolam.Name = "dateTime_Ngayvaolam";
            this.dateTime_Ngayvaolam.Size = new System.Drawing.Size(251, 22);
            this.dateTime_Ngayvaolam.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(413, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ngày vào làm";
            // 
            // txtchuvu
            // 
            this.txtchuvu.Location = new System.Drawing.Point(93, 116);
            this.txtchuvu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtchuvu.Name = "txtchuvu";
            this.txtchuvu.Size = new System.Drawing.Size(248, 22);
            this.txtchuvu.TabIndex = 12;
            // 
            // txtDiachinv
            // 
            this.txtDiachinv.Location = new System.Drawing.Point(523, 132);
            this.txtDiachinv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiachinv.Name = "txtDiachinv";
            this.txtDiachinv.Size = new System.Drawing.Size(248, 22);
            this.txtDiachinv.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(413, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Họ tên";
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(93, 43);
            this.txtManv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(251, 22);
            this.txtManv.TabIndex = 7;
            // 
            // txtDienthoainv
            // 
            this.txtDienthoainv.Location = new System.Drawing.Point(95, 156);
            this.txtDienthoainv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienthoainv.Name = "txtDienthoainv";
            this.txtDienthoainv.Size = new System.Drawing.Size(249, 22);
            this.txtDienthoainv.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(13, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chức vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(413, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa chỉ";
            // 
            // txtHotennv
            // 
            this.txtHotennv.Location = new System.Drawing.Point(523, 43);
            this.txtHotennv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHotennv.Name = "txtHotennv";
            this.txtHotennv.Size = new System.Drawing.Size(248, 22);
            this.txtHotennv.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // dateTimeNgaysinhnv
            // 
            this.dateTimeNgaysinhnv.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgaysinhnv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgaysinhnv.Location = new System.Drawing.Point(93, 79);
            this.dateTimeNgaysinhnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNgaysinhnv.Name = "dateTimeNgaysinhnv";
            this.dateTimeNgaysinhnv.Size = new System.Drawing.Size(251, 22);
            this.dateTimeNgaysinhnv.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txt_TimKiem);
            this.groupBox4.Location = new System.Drawing.Point(89, 49);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(684, 75);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tim kiếm nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin cần tìm:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(221, 21);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(257, 22);
            this.txt_TimKiem.TabIndex = 0;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.dgv_NhanVien);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox7.Location = new System.Drawing.Point(53, 414);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(1085, 235);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Danh sách nhân viên";
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.GridColor = System.Drawing.Color.Gray;
            this.dgv_NhanVien.Location = new System.Drawing.Point(16, 22);
            this.dgv_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(1063, 206);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbtnNunv);
            this.groupBox2.Controls.Add(this.rbtnNamnv);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(99, 338);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(335, 66);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // rbtnNunv
            // 
            this.rbtnNunv.AutoSize = true;
            this.rbtnNunv.BackColor = System.Drawing.Color.Transparent;
            this.rbtnNunv.Location = new System.Drawing.Point(229, 27);
            this.rbtnNunv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnNunv.Name = "rbtnNunv";
            this.rbtnNunv.Size = new System.Drawing.Size(47, 21);
            this.rbtnNunv.TabIndex = 1;
            this.rbtnNunv.TabStop = true;
            this.rbtnNunv.Text = "Nữ";
            this.rbtnNunv.UseVisualStyleBackColor = false;
            // 
            // rbtnNamnv
            // 
            this.rbtnNamnv.AutoSize = true;
            this.rbtnNamnv.BackColor = System.Drawing.Color.Transparent;
            this.rbtnNamnv.Location = new System.Drawing.Point(40, 27);
            this.rbtnNamnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnNamnv.Name = "rbtnNamnv";
            this.rbtnNamnv.Size = new System.Drawing.Size(58, 21);
            this.rbtnNamnv.TabIndex = 0;
            this.rbtnNamnv.TabStop = true;
            this.rbtnNamnv.Text = "Nam";
            this.rbtnNamnv.UseVisualStyleBackColor = false;
            // 
            // btn_ClearNV
            // 
            this.btn_ClearNV.ForeColor = System.Drawing.Color.Black;
            this.btn_ClearNV.Image = global::GUI.Properties.Resources.actions_edit_clear_15784;
            this.btn_ClearNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ClearNV.Name = "btn_ClearNV";
            this.btn_ClearNV.Size = new System.Drawing.Size(67, 24);
            this.btn_ClearNV.Text = "Clear";
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemNV.Image = global::GUI.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.btn_ThemNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(70, 24);
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.ForeColor = System.Drawing.Color.Black;
            this.btn_SuaNV.Image = global::GUI.Properties.Resources._3709743_assistance_fix_problem_service_trouble_108085;
            this.btn_SuaNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(58, 24);
            this.btn_SuaNV.Text = "Sửa";
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaNV.Image = global::GUI.Properties.Resources.flat_style_circle_delete_trash_icon_icons_com_66945;
            this.btn_XoaNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(59, 24);
            this.btn_XoaNV.Text = "Xóa";
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 705);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_ClearNV;
        private System.Windows.Forms.ToolStripButton btn_ThemNV;
        private System.Windows.Forms.ToolStripButton btn_SuaNV;
        private System.Windows.Forms.ToolStripButton btn_XoaNV;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTime_Ngayvaolam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtchuvu;
        private System.Windows.Forms.TextBox txtDiachinv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtDienthoainv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHotennv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeNgaysinhnv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnNunv;
        private System.Windows.Forms.RadioButton rbtnNamnv;
    }
}