namespace GUI.UserControls
{
    partial class listProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureHinh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureHinh
            // 
            this.pictureHinh.Location = new System.Drawing.Point(41, 18);
            this.pictureHinh.Name = "pictureHinh";
            this.pictureHinh.Size = new System.Drawing.Size(222, 174);
            this.pictureHinh.TabIndex = 0;
            this.pictureHinh.TabStop = false;
            this.pictureHinh.Click += new System.EventHandler(this.pictureHinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sản phẩm :";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTenSanPham.Location = new System.Drawing.Point(142, 213);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(96, 15);
            this.lblTenSanPham.TabIndex = 2;
            this.lblTenSanPham.Text = "lblTenSanPham";
            // 
            // listProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureHinh);
            this.Name = "listProduct";
            this.Size = new System.Drawing.Size(307, 290);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenSanPham;
    }
}
