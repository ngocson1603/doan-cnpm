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

namespace GUI
{
    public partial class frmDetailProduct : Form
    {
        XuLy.loadProduct lsp = new XuLy.loadProduct();
        List<detailProducts> dsSP = new List<detailProducts>();
        public frmDetailProduct()
        {
            InitializeComponent();
        }

        void initdb()
        {
            DataTable tablesv = lsp.LoadDLSPDetail();
            foreach (DataRow dr in tablesv.Rows)
            {

                string tensp = dr.ItemArray[0].ToString();
                string tenloai = dr.ItemArray[1].ToString();
                string tenhang = dr.ItemArray[2].ToString();
                int giaban = Convert.ToInt32(dr.ItemArray[3]);
                int tonkho = Convert.ToInt32(dr.ItemArray[4]);
                int hsd = Convert.ToInt32(dr.ItemArray[5]);
                string anh = dr.ItemArray[6].ToString();
                int ma = Convert.ToInt32(dr.ItemArray[7]);
                detailProducts s = new detailProducts();
                {
                    s.TenSP = tensp;
                    s.TenLoai = tenloai;
                    s.TenHang = tenhang;
                    s.GiaBan = giaban;
                    s.TonKho = tonkho;
                    s.HSD = hsd;
                    s.Hinh = anh;
                    s.MaSP = ma;
                };
                dsSP.Add(s);
            }
        }

        public void AddProDuct(List<detailProducts> list)
        {
            int y = 0;
            int i = 0;
            foreach (detailProducts s in list)
            {

                UserControls.detailProduct u = new UserControls.detailProduct();
                u.BackColor = System.Drawing.Color.Khaki;
                u.Location = new System.Drawing.Point(1, -1 + y);
                u.Name = "userControlDb " + u;
                u.Size = new System.Drawing.Size(1032, 661);
                u.TabIndex = i++;
                u.AddProducts(s);
                u.Dock = DockStyle.Fill;
                panel1.Controls.Add(u);
                y += u.Height;
            }
            //panel1.Height = y;
            //this.Height = y + 80;
        }

        private void frmDetailProduct_Load(object sender, EventArgs e)
        {
            initdb();
            AddProDuct(dsSP);
        }
    }
}
