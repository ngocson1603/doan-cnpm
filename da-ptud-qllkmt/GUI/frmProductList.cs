using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using DTO;

namespace GUI
{
    public partial class frmProductList : Form
    {
        XuLy.loadProduct lsp = new XuLy.loadProduct();
        List<productList> dsSP = new List<productList>();
        public static string ten;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        public frmProductList()
        {
            InitializeComponent();
        }

        void initdb()
        {
            DataTable tablesv = lsp.LoadDLSP();
            foreach (DataRow dr in tablesv.Rows)
            {

                string anh = dr.ItemArray[0].ToString();
                string tensp = dr.ItemArray[1].ToString();
                productList s = new productList();
                {
                    s.Anh = anh;
                    s.TenSP = tensp;
                };
                dsSP.Add(s);
            }
        }

        public void AddProDuct(List<productList> list)
        {
            int y = 0;
            int i = 0;
            foreach (productList s in list)
            {

                UserControls.listProduct u = new UserControls.listProduct();
                u.BackColor = System.Drawing.Color.White;
                u.Location = new System.Drawing.Point(1, -1 + y);
                u.Name = "userControlDb " + u;
                u.Size = new System.Drawing.Size(374, 250);
                u.TabIndex = i++;
                u.AddProducts(s);
                flowLayoutPanel1.Controls.Add(u);
                y += u.Height;
            }
            //flowLayoutPanel1.Height = y;
            //this.Height = y + 80;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string a = txtTimKiem.Text;
            if (a.Length > 0)
            {
                var orders = (from s in dsSP where s.TenSP.Contains(a.ToString()) select s).ToList();
                flowLayoutPanel1.Controls.Clear();
                AddProDuct(orders);
            }
            else if (txtTimKiem.Text.Length == 0)
            {
                flowLayoutPanel1.Controls.Clear();
                AddProDuct(dsSP);
            }
            else
            {
                AddProDuct(dsSP);
                flowLayoutPanel1.Controls.Clear();
            }
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            
            initdb();
            AddProDuct(dsSP);
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                comboBox1.Items.Add(filterInfo.Name);
            comboBox1.SelectedIndex = 0;

            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += captureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Dispose();
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                var result = barcodeReader.DecodeMultiple((Bitmap)pictureBox1.Image);
                try
                {
                    //string decoded = result.ToString().Trim();
                    //if (!listBox1.Items.Contains(decoded))
                    //{
                    //    listBox1.ResetText();
                    //    listBox1.Items.Insert(0, decoded);
                    //}

                    if (result != null)
                    {
                        foreach (Result results in result)
                        {
                            txtTimKiem.Text = results.ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }
                //if (result != null)
                //{
                //    txtQR.Text = result.ToString();
                //    timer1.Stop();
                //    if (captureDevice.IsRunning)
                //        captureDevice.Stop();
                //}
            }
        }

        private void frmProductList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
            if (frmBanSanPham.laygiatri == true)
            {
                frmBanSanPham.dgv.Refresh();
            }
        }

        private void frmProductList_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
