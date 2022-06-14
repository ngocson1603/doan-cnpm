using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class frmTrangChuNhanVien : Form
    {
        Helper hp = new Helper();
        BLLDangNhap blldn = new BLLDangNhap();
        public frmTrangChuNhanVien()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (a == DialogResult.Yes)
            {
                frmBanSanPham.laygiatri = false;
                Close();
                frmDN f = new frmDN();
                f.Show();
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmQuanLySP(), panel2);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmNhanVien(), panel2);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmKhachHang(), panel2);
        }

        private void btn_NhapSP_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmNhapLinhKien(), panel2);
        }

        private void btn_BanSP_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmBanSanPham(), panel2);
        }

        private void btn_NhaPhanPhoi_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmNPP(), panel2);
        }

        private void btn_HeThong_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmLSPHSX(), panel2);
        }
        public static Panel pnltrang;
        public static string manv;

        private void frmTrangChuNhanVien_Load(object sender, EventArgs e)
        {

            pnltrang = panel2;

            string ma = blldn.loadmanv(frmDN.taikhoan);
            manv = ma;
            string ten = blldn.loadtentheoma(ma);

            lblxinchao.Text = "Xin Chào : " + ten;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmBaoHanh(), panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmDonDatHang(), panel2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}
