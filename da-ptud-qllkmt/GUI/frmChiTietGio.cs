using BLL;
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
using GUI.UserControls;

namespace GUI
{
    public partial class frmChiTietGio : Form
    {
        Helper hp = new Helper();
        BLLGioHang bllgiohang = new BLLGioHang();
        BLLSeri bllsr = new BLL.BLLSeri();
       
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public static int kq;
        public frmChiTietGio()
        {
            InitializeComponent();
        }
        private void frmChiTietGio_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[1, 0];
                string direct = hp.Directory() + dataGridView1.CurrentRow.Cells[5].Value.ToString();
                pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);

                dataGridView1.Columns[5].Visible = false;
            }
            dataGridView1.Columns[5].Visible = false;
            txtTK.Text = frmDN.taikhoan;

            txtMaKH.Text = bllgiohang.loadMaKH(frmDN.taikhoan);
        }
        public void loaddata(BindingList<ThemSanPham> loadsp)
        {
            //load = loadsp;
            //dt.Columns.Add("Tên sản phẩm");
            //dt.Columns.Add("Loại");
            //dt.Columns.Add("Hãng");
            //dt.Columns.Add("Giá");
            //dt.Columns.Add("Nhập vào số lượng");
            //dt.Columns.Add("Hinh");
            //dt.Columns.Add("Mã sản phẩm");
            //for (int x = 0; x < loadsp.Count; x = x + 7)
            //{
            //    dt.Rows.Add(load[x], load[x + 1], load[x + 2], load[x + 3], load[x + 4], load[x + 5], load[x + 6]);

            //    dataGridView1.DataSource = dt;
            //}
            dataGridView1.DataSource = loadsp;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
        }
        public Image GetImg(string direct, int w, int h)
        {
            Image i = Image.FromFile(direct);
            return (Image)(new Bitmap(i, new Size(w, h)));
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                kq = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) * int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                txtTongTien.Text = kq.ToString();
                string direct = hp.Directory() + dataGridView1.CurrentRow.Cells[5].Value.ToString();
                pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);
                button1.Enabled = true;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thanh toán không!", "Thanh Toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                int a = 0;
                if (dataGridView1.Rows.Count > 0)
                {
                    ThemGioHang cthdsp = new ThemGioHang()
                    {
                        MaKH = int.Parse(txtMaKH.Text),
                        NgayLapHoaDon = dateTimePicker1.Value
                    };

                    if (bllgiohang.postGioHang(cthdsp))
                    {
                        int macuoicung = bllgiohang.loadMaCuoiCung();
                        textBox1.Text = macuoicung.ToString();
                        for (int x = 0; x < dataGridView1.Rows.Count; x++)
                        {
                            ThemCTHD cthd = new ThemCTHD()
                            {
                                MaHoaDon = macuoicung,
                                MaSanPham = int.Parse(dataGridView1.Rows[a].Cells[6].Value.ToString()),
                                giaban = int.Parse(dataGridView1.Rows[a].Cells[3].Value.ToString()),
                                soluong = int.Parse(dataGridView1.Rows[a].Cells[4].Value.ToString()),
                                TongTien = int.Parse(dataGridView1.Rows[a].Cells[3].Value.ToString()) * int.Parse(dataGridView1.Rows[a].Cells[4].Value.ToString()),

                            };
                         
                            if (bllgiohang.postGioHangCTHD(cthd))
                            {
                                for (int i = 0; i < int.Parse(dataGridView1.Rows[a].Cells[4].Value.ToString()); i++)
                                {
                                    SeriHD sr = new SeriHD()
                                    {
                                        Seri = bllsr.loadseritheoma(int.Parse(dataGridView1.Rows[a].Cells[6].Value.ToString())),
                                        MaHoaDon = int.Parse(textBox1.Text),
                                    };
                                    bllsr.postSP(sr);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mua hàng không thành công");
                                break;
                            }
                            a++;
                        }
                        MessageBox.Show("Mua hàng thành công");
                        detailProduct.lstsp.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm");
                    return;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            detailProduct.lstsp.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
                else if (tb == null)
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm");
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allowed only numeric value  ex.10
            //if (!char.IsControl(e.KeyChar)
            //    && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}

            // allowed numeric and one dot  ex. 10.23
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
