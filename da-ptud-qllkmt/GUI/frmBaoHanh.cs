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
        BLLSeri bllsr = new BLLSeri();
        BLLHoaDon bllhd = new BLLHoaDon();

        double soThangSuDung = 0;

        public frmBaoHanh()
        {
            InitializeComponent();
            dataGridView3.AutoGenerateColumns = false;
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
            comboBox2.SelectedIndex = 0;

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
                //toolStripButton3.Enabled = true;
            }
        }
        public static BindingList<ThemBH> lstspbh = new BindingList<ThemBH>();

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            DateTime compareTo = DateTime.Parse(bllbh.getngay(int.Parse(comboBox1.Text)));
            DateTime now = DateTime.Now;
            var diffMonths = (now.Month + now.Year * 12) - (compareTo.Month + compareTo.Year * 12);
            int hsd = int.Parse(bllbh.loadhsd(int.Parse(txtMaSP.Text)));

            if (diffMonths > hsd)
            {
                MessageBox.Show("Sản phẩm đã hết bảo hành");
                return;
            }
            else
            {
                string ma = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                //int tonkho = 1;
                string lydo = richTextBox1.Text;
                //string ten = bllbh.getten(int.Parse(ma));

                //if (lstspbh.Any(n => n.ma == ma))
                //{
                //    MessageBox.Show("Đã thêm");
                //    var item = lstspbh.SingleOrDefault(x => x.ma == ma);

                //    if (item.soluong == int.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString()) && item.ma == dataGridView2.CurrentRow.Cells[1].Value.ToString())
                //    {
                //        MessageBox.Show("Hiện tại số lượng sản phẩm của khách đã hết");
                //        return;
                //    }
                //    else
                //    {
                //        item.soluong++;
                //    }
                //}
                //else
                //{
                MessageBox.Show("Da them");

                ThemBH sp = new ThemBH(ma, lydo);
                lstspbh.Add(sp);

                dataGridView3.Rows.RemoveAt(dataGridView3.CurrentCell.RowIndex);

            }
            dataGridView1.Refresh();
            toolStripButton3.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = comboBox1.Text;
            if (ma.Equals("DTO.HoaDon"))
                return;

            HoaDon hd = bllhd.GetThongTinHoaDon(int.Parse(ma));
            soThangSuDung = DateTime.Now.Subtract(hd.NgayLapHoaDon.Value).Days / (365 / 12);
            dataGridView2.DataSource = bllbh.getlist(int.Parse(ma), soThangSuDung);
            dataGridView3.DataSource = bllsr.loadsr(int.Parse(ma), bllbh.getlist(int.Parse(ma), soThangSuDung));



            List<SeriHD> lst = bllsr.loadsr(int.Parse(ma), bllbh.getlist(int.Parse(ma), soThangSuDung));
            dataGridView3.DataSource = bllsr.ListToDataTable(lst);

            //dataGridView3.DataSource = bllsr.loadsr(int.Parse(ma), bllbh.getlist(int.Parse(ma), soThangSuDung));

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
                            Seri = dataGridView1.Rows[a].Cells[0].Value.ToString(),
                            LyDo = dataGridView1.Rows[a].Cells[1].Value.ToString(),
                        };
                        a++;
                        if (bllbh.thembhct(cthd))
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công");
                            break;
                        }
                        
                    }
                    MessageBox.Show("Thêm thành công");
                    lstspbh.Clear();
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

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView2.CurrentCell = dataGridView2[1, 0];
                string ma = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                int? seritheoma = bllbh.getMaTheoSeri(ma);
                txtMaSP.Text = seritheoma.ToString();
                toolStripButton3.Enabled = true;
            }
        }
    }
}