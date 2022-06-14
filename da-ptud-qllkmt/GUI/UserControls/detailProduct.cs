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

namespace GUI.UserControls
{
    public partial class detailProduct : UserControl
    {
        Helper hp = new Helper();
        public detailProduct()
        {
            InitializeComponent();
        }

        public Image GetImg(string direct, int w, int h)
        {
            Image i = Image.FromFile(direct);
            return (Image)(new Bitmap(i, new Size(w, h)));
        }
        public static string a;
        public static int soluongton;
        public void AddProducts(detailProducts s)
        {
            lblTenSanPham.Text = s.TenSP.ToString();
            lblTenLoai.Text = s.TenLoai.ToString();
            lblTenHang.Text = s.TenHang.ToString();
            lblGiaBan.Text = s.GiaBan.ToString();
            lblTonkho.Text = s.TonKho.ToString();
            lblHSD.Text = s.HSD.ToString();
            soluongton = s.TonKho;
            string direct = hp.Directory() + s.Hinh;
            a = s.Hinh;
            pictureDetailSP.Image = GetImg(direct, pictureDetailSP.Width, pictureDetailSP.Height);       
            label8.Text = s.MaSP.ToString();
        }

        private void gunathoat_Click(object sender, EventArgs e)
        {
                Panel pnl = this.Parent as Panel;
                Form frm1 = pnl.Parent as Form;
                frm1.Close();


                frmProductList frm = new frmProductList();
                hp.motrangcon(frm, frmTrangChu.pnltrang);

        }

        public static string ma = "";
        public static string gia = "";
        public static string loai = "";
        public static string hang = "";
        public static string tensp = "";
        public static int tonkho;
        public static string anh = "";
        public static BindingList<ThemSanPham> lstsp = new BindingList<ThemSanPham>();
        public static BindingList<ThemSanPham> lstspb = new BindingList<ThemSanPham>();

        private void gunaMua_Click(object sender, EventArgs e)
        {
            ma = label8.Text;
            gia = lblGiaBan.Text;
            loai = lblTenLoai.Text;
            hang = lblTenHang.Text;
            tensp = lblTenSanPham.Text;
            tonkho = 1;
            anh = a;

            if (frmBanSanPham.laygiatri == true)
            {
                if (lstspb.Any(n => n.ma == ma))
                {
                    MessageBox.Show("Đã thêm vào Đơn Hàng");
                    var item = lstspb.SingleOrDefault(x => x.ma == ma);

                    if (item.soluong == soluongton - 1)
                    {
                        MessageBox.Show("Hiện tại số lượng sản phẩm tại cửa hàng không còn đủ");
                        return;
                    }
                    else
                    {
                        item.soluong++;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra");

                    ThemSanPham sp = new ThemSanPham(tensp, loai, hang, gia, tonkho, anh, ma);
                    lstspb.Add(sp);
                }
            }
            else
            {
                if (lstsp.Any(n => n.ma == ma))
                {
                    MessageBox.Show("Vui lòng kiểm tra trong phần giỏ hàng");
                    var item = lstsp.SingleOrDefault(x => x.ma == ma);

                    if (item.soluong == soluongton - 1)
                    {
                        MessageBox.Show("Hiện tại số lượng sản phẩm tại cửa hàng không còn đủ");
                        return;
                    }
                    else
                    {
                        item.soluong++;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra trong phần giỏ hàng");

                    ThemSanPham sp = new ThemSanPham(tensp, loai, hang, gia, tonkho, anh, ma);
                    lstsp.Add(sp);
                }
            }
        }

        private void lblGiaBan_Click(object sender, EventArgs e)
        {

        }

        private void lblTenHang_Click(object sender, EventArgs e)
        {

        }

        private void lblTenLoai_Click(object sender, EventArgs e)
        {

        }

        private void lblTenSanPham_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureDetailSP_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblTonkho_Click(object sender, EventArgs e)
        {

        }

        private void detailProduct_Load(object sender, EventArgs e)
        {
            if (frmBanSanPham.laygiatri == true)
            {
                gunathoat.Visible = false;
            }
            else
            {
                gunathoat.Visible = true;
            }
        }
    }
}
