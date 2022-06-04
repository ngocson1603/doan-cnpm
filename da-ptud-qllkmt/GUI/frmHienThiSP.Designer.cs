namespace GUI
{
    partial class frmHienThiSP
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnNhapvao = new System.Windows.Forms.Button();
            this.btnBanra = new System.Windows.Forms.Button();
            this.dgv_hienthi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbhienthi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(967, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 47);
            this.button1.TabIndex = 34;
            this.button1.Text = "Đăng xuất";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNhapvao
            // 
            this.btnNhapvao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhapvao.Image = global::GUI.Properties.Resources.nhapvao;
            this.btnNhapvao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapvao.Location = new System.Drawing.Point(759, 103);
            this.btnNhapvao.Name = "btnNhapvao";
            this.btnNhapvao.Size = new System.Drawing.Size(202, 47);
            this.btnNhapvao.TabIndex = 33;
            this.btnNhapvao.Text = "Nhập vào";
            this.btnNhapvao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapvao.UseVisualStyleBackColor = true;
            // 
            // btnBanra
            // 
            this.btnBanra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBanra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanra.Location = new System.Drawing.Point(566, 103);
            this.btnBanra.Name = "btnBanra";
            this.btnBanra.Size = new System.Drawing.Size(187, 47);
            this.btnBanra.TabIndex = 32;
            this.btnBanra.Text = "Bán ra";
            this.btnBanra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanra.UseVisualStyleBackColor = true;
            // 
            // dgv_hienthi
            // 
            this.dgv_hienthi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_hienthi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienthi.Location = new System.Drawing.Point(32, 184);
            this.dgv_hienthi.Name = "dgv_hienthi";
            this.dgv_hienthi.RowTemplate.Height = 24;
            this.dgv_hienthi.Size = new System.Drawing.Size(1171, 448);
            this.dgv_hienthi.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Loại";
            // 
            // cbbhienthi
            // 
            this.cbbhienthi.FormattingEnabled = true;
            this.cbbhienthi.Location = new System.Drawing.Point(29, 126);
            this.cbbhienthi.Name = "cbbhienthi";
            this.cbbhienthi.Size = new System.Drawing.Size(516, 24);
            this.cbbhienthi.TabIndex = 29;
            // 
            // frmHienThiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 719);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNhapvao);
            this.Controls.Add(this.btnBanra);
            this.Controls.Add(this.dgv_hienthi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbhienthi);
            this.Name = "frmHienThiSP";
            this.Text = "frmHienThiSP";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNhapvao;
        private System.Windows.Forms.Button btnBanra;
        private System.Windows.Forms.DataGridView dgv_hienthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbhienthi;

    }
}