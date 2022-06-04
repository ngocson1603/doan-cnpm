using GUI.XuLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmDN : Form
    {
        DangNhap dn = new DangNhap();
        BLLDangNhap blldn = new BLLDangNhap();
        public frmDN()
        {
            InitializeComponent();
        }

        public static string taikhoan = "";
        public static string pass = "";
        
        private void gunardangnhap_Click(object sender, EventArgs e)
        {
            int dem = 0;
            
            int a = dn.dangNhap(txtUserName.Text,txtPassWord.Text);
            taikhoan = txtUserName.Text;
            pass = txtPassWord.Text;
            if (txtUserName.Text.Length == 0 || txtPassWord.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (a == 3)
            {
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(1000);
                splashScreenManager1.CloseWaitForm();
                frmTrangChu frm = new frmTrangChu();
                frm.Show();
                this.Hide();
            }
            else if (a == 2)
            {
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(1000);
                splashScreenManager1.CloseWaitForm();
                frmTrangChuNhanVien frm = new frmTrangChuNhanVien();
                frm.Show();
                this.Hide();
            }
            else if (a == 1)
            {
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(1000);
                splashScreenManager1.CloseWaitForm();
                frmTrangChuNhanVien frm = new frmTrangChuNhanVien();
                frm.Show();
                this.Hide();
            }
            else
            {
                dem++;
                MessageBox.Show("Đăng nhập thất bại,mời bạn nhập lại");
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần");
                    Application.Exit();
                }
            }

            //else if (blldn.kiemtrakh(txtUserName.Text, txtPassWord.Text))
            //{
            //    splashScreenManager1.ShowWaitForm();
            //    Thread.Sleep(1000);
            //    splashScreenManager1.CloseWaitForm();
            //    frmTrangChu frm = new frmTrangChu();
            //    frm.Show();
            //    this.Hide();
            //}
            //else if (blldn.kiemtranv(txtUserName.Text, txtPassWord.Text))
            //{
            //    splashScreenManager1.ShowWaitForm();
            //    Thread.Sleep(1000);
            //    splashScreenManager1.CloseWaitForm();
            //    frmTrangChuDanhChoNhanVien frm = new frmTrangChuDanhChoNhanVien();
            //    frm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    dem++;
            //    MessageBox.Show("Đăng nhập thất bại,mời bạn nhập lại");
            //    if (dem == 3)
            //    {
            //        MessageBox.Show("Bạn đã nhập sai 3 lần");
            //        Application.Exit();
            //    }
            //}
        }

        private void gunathoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (a == DialogResult.Yes)
            {

                Close();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.Show();
            this.Hide();
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void check_DangNhap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
