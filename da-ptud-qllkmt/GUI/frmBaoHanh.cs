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
    public partial class frmBaoHanh : Form
    {
        BLLBaoHanh bllbh = new BLLBaoHanh();
        public frmBaoHanh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bllbh.getlist(int.Parse(comboBox1.Text));
            lstspbh.Clear();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loaddata(BindingList<ThemBH> loadsp)
        {
            dataGridView1.DataSource = loadsp;

        }
        private void frmBaoHanh_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bllbh.getmahd();
            comboBox1.DisplayMember = "MaHoaDon";
            comboBox1.ValueMember = "MaHoaDon";
            comboBox1.SelectedIndex = 0;

            comboBox2.DataSource = bllbh.getmabh();
            comboBox2.DisplayMember = "MaBH";
            comboBox2.ValueMember = "MaBH";
            //comboBox2.SelectedIndex = 0;

            txtManv.Text = frmTrangChuNhanVien.manv;
            loaddata(frmBaoHanh.lstspbh);

            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSP.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                toolStripButton3.Enabled = true;
            }
        }
        public static BindingList<ThemBH> lstspbh = new BindingList<ThemBH>();

        public int thang(DateTime compareTo, DateTime now)
        {
            int nMonths = 0;
            if (now.Year == compareTo.Year)
                nMonths = now.Month - compareTo.Month;
            else
                nMonths = (12 - compareTo.Month) + now.Month;
            return nMonths;
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            

            DateTime compareTo = DateTime.Parse(bllbh.getngay(int.Parse(comboBox1.Text)));
            DateTime now = DateTime.Now;
            int so = thang(compareTo, now);
            int hsd = int.Parse(bllbh.loadhsd(int.Parse(txtMaSP.Text)));

            if (so > hsd)
            {
                MessageBox.Show("Sản phẩm đã hết bảo hành");
                return;
            }
            else
            {
                string ma = txtMaSP.Text;
                int tonkho = 1;
                string lydo = richTextBox1.Text;
                string ten = bllbh.getten(int.Parse(ma));

                if (lstspbh.Any(n => n.ma == ma))
                {
                    MessageBox.Show("Đã thêm");
                    var item = lstspbh.SingleOrDefault(x => x.ma == ma);

                    if (item.soluong == int.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString()) - 1)
                    {
                        MessageBox.Show("Hiện tại số lượng sản phẩm của khách đã hết");
                        return;
                    }
                    else
                    {
                        item.soluong++;
                    }
                }
                else
                {
                    MessageBox.Show("Xong");

                    ThemBH sp = new ThemBH(ten, tonkho, ma, lydo);
                    lstspbh.Add(sp);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstspbh.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            loaddata(frmBaoHanh.lstspbh);
            if (MessageBox.Show("Bạn có muốn bảo hành không!", "Bảo Hành", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {

                int a = 0;
                ThemBaoHanh cthdsp = new ThemBaoHanh()
                {
                    NgayLap = dateTimePicker1.Value,
                    MaNhanVien = int.Parse(txtManv.Text),
                    MaHoaDon = int.Parse(comboBox1.Text),
                };

                if (bllbh.thembh(cthdsp))
                {
                    int macuoicung = bllbh.laodmacuoicung();
                    for (int x = 0; x < dataGridView1.Rows.Count; x++)
                    {
                        ThemCTBH cthd = new ThemCTBH()
                        {
                            MaBH = macuoicung,
                            MaSanPham = int.Parse(dataGridView1.Rows[a].Cells[1].Value.ToString()),
                            SoLuong = int.Parse(dataGridView1.Rows[a].Cells[2].Value.ToString()),
                            LyDo = dataGridView1.Rows[a].Cells[3].Value.ToString(),
                        };
                        a++;
                        if (bllbh.thembhct(cthd))
                        {
                            lstspbh.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công");
                            break;
                        }
                    }
                    MessageBox.Show("Thêm thành công");
                }
            }
            comboBox2.DataSource = bllbh.getmabh();
            comboBox2.DisplayMember = "MaBH";
            comboBox2.ValueMember = "MaBH";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (bllbh.xoabhct(int.Parse(comboBox2.Text)))
            {
                bllbh.xoabh(int.Parse(comboBox2.Text));
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }
            comboBox2.DataSource = bllbh.getmabh();
            comboBox2.DisplayMember = "MaBH";
            comboBox2.ValueMember = "MaBH";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = bllbh.getctbh(int.Parse(comboBox2.Text));
        }
    }
}