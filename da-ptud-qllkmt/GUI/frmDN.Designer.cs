namespace GUI
{
    partial class frmDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDN));
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::GUI.LoadForm), true, true);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunathoat = new Guna.UI2.WinForms.Guna2Button();
            this.gunardangnhap = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.check_DangNhap = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật Khẩu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tài Khoản:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gunathoat
            // 
            this.gunathoat.BackColor = System.Drawing.Color.Transparent;
            this.gunathoat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(194)))));
            this.gunathoat.BorderRadius = 8;
            this.gunathoat.BorderThickness = 2;
            this.gunathoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunathoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunathoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunathoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunathoat.FillColor = System.Drawing.Color.Black;
            this.gunathoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunathoat.ForeColor = System.Drawing.Color.White;
            this.gunathoat.Location = new System.Drawing.Point(267, 418);
            this.gunathoat.Margin = new System.Windows.Forms.Padding(2);
            this.gunathoat.Name = "gunathoat";
            this.gunathoat.Size = new System.Drawing.Size(80, 31);
            this.gunathoat.TabIndex = 7;
            this.gunathoat.Text = "Thoát";
            this.gunathoat.UseTransparentBackground = true;
            this.gunathoat.Click += new System.EventHandler(this.gunathoat_Click);
            // 
            // gunardangnhap
            // 
            this.gunardangnhap.BackColor = System.Drawing.Color.Transparent;
            this.gunardangnhap.BorderRadius = 8;
            this.gunardangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunardangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunardangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunardangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunardangnhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.gunardangnhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunardangnhap.ForeColor = System.Drawing.Color.White;
            this.gunardangnhap.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunardangnhap.Location = new System.Drawing.Point(18, 385);
            this.gunardangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.gunardangnhap.Name = "gunardangnhap";
            this.gunardangnhap.Size = new System.Drawing.Size(105, 31);
            this.gunardangnhap.TabIndex = 6;
            this.gunardangnhap.Text = "Đăng Nhập";
            this.gunardangnhap.UseTransparentBackground = true;
            this.gunardangnhap.Click += new System.EventHandler(this.gunardangnhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ghi nhớ Mật Khẩu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // check_DangNhap
            // 
            this.check_DangNhap.Checked = true;
            this.check_DangNhap.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.check_DangNhap.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.check_DangNhap.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(1)))), ((int)(((byte)(88)))));
            this.check_DangNhap.CheckedState.InnerColor = System.Drawing.Color.White;
            this.check_DangNhap.Location = new System.Drawing.Point(21, 327);
            this.check_DangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.check_DangNhap.Name = "check_DangNhap";
            this.check_DangNhap.Size = new System.Drawing.Size(41, 19);
            this.check_DangNhap.TabIndex = 3;
            this.check_DangNhap.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_DangNhap.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_DangNhap.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.check_DangNhap.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.check_DangNhap.CheckedChanged += new System.EventHandler(this.check_DangNhap_CheckedChanged);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtPassWord.BorderRadius = 6;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.DefaultText = "";
            this.txtPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.Location = new System.Drawing.Point(19, 284);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '●';
            this.txtPassWord.PlaceholderText = "Nhập Mật Khẩu";
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.Size = new System.Drawing.Size(208, 29);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.UseSystemPasswordChar = true;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtUserName.BorderRadius = 6;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(18, 211);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "Nhập Tài Khoản";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(209, 29);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2PictureBox1.Location = new System.Drawing.Point(50, 41);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(230, 133);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Controls.Add(this.btnDangKy);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.gunathoat);
            this.guna2Panel1.Controls.Add(this.gunardangnhap);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.check_DangNhap);
            this.guna2Panel1.Controls.Add(this.txtPassWord);
            this.guna2Panel1.Controls.Add(this.txtUserName);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.ForeColor = System.Drawing.Color.Coral;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(363, 475);
            this.guna2Panel1.TabIndex = 7;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.Transparent;
            this.btnDangKy.BorderRadius = 8;
            this.btnDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKy.Location = new System.Drawing.Point(127, 385);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(105, 31);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseTransparentBackground = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // frmDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 475);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDN";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button gunathoat;
        private Guna.UI2.WinForms.Guna2Button gunardangnhap;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch check_DangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtPassWord;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDangKy;
    }
}