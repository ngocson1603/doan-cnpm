using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLL;
using GUI.XuLy;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BLLDangKy blldangky = new BLLDangKy();
        Helper hp = new Helper();
        loadProduct xl = new loadProduct();
        public static string tenkhach;
        public frmTrangChu()
        {
            xl.load();
            InitializeComponent();
            pnltrang = panel1;

            txtChao.Caption = tenkhach;
        }

        public static Panel pnltrang;

        public Form currentchildform;

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (a == DialogResult.Yes)
            {
                Close();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (a == DialogResult.Yes)
            {
                Close();
                frmDN f = new frmDN();
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmProductList(),panel1);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmGioHang(), panel1);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmGiaoDien(), panel1);
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmGiaoDien(),panel1);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmThongTinKH(), panel1);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmThongKeMuaHang(), panel1);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmTuVanSuaChua(), panel1);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            frmChiTietGio frm = new frmChiTietGio();
            frm.loaddata(UserControls.detailProduct.lstsp);
            hp.motrangcon(frm, panel1);
        }
    }
}