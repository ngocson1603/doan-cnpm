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
using GUI.XuLy;

namespace GUI
{
    public partial class frmBaoHanh : Form
    {
        BLLBaoHanh bllbh = new BLLBaoHanh();
        BLLSeri bllsr = new BLLSeri();
        BLLHoaDon bllhd = new BLLHoaDon();
        BLLDangNhap blldn = new BLLDangNhap();

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

            dataGridView3.DataSource = bllsr.loadsr(int.Parse(ma), bllbh.getlist(int.Parse(ma), soThangSuDung));

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
                    int macuoicung = bllbh.loadmacuoicung();
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

            XuatPhieu();
        }

        public void XuatPhieu()
        {
            manv = int.Parse(txtManv.Text);

            tennv = blldn.loadtentheoma(txtManv.Text);

            mabh = bllbh.loadmacuoicung();

            ngaytra = DateTime.Parse(dtp_NgayTra.Value.ToString());
            DateTime ngaydau = DateTime.Parse(dateTimePicker1.Value.ToString());
            double thoihan = (ngaytra - ngaydau).TotalDays;

            if (thoihan<1)
            {
                MessageBox.Show("Vui lòng chọn hạn trả");
                return;
            }

            dataExcel.DataSource = bllbh.getmabaohanh(mabh);


            ExcelExportBaoHanh ex = new ExcelExportBaoHanh();

            List<View_BieuMauBH> pListKhoa = new List<View_BieuMauBH>();

            foreach (DataGridViewRow item in dataExcel.Rows)
            {
                View_BieuMauBH i = new View_BieuMauBH();
                i.TenSanPham = item.Cells[0].Value.ToString();
                i.Seri = item.Cells[1].Value.ToString();
                i.LyDo = item.Cells[2].Value.ToString();


                pListKhoa.Add(i);
            }


            string path = string.Empty;

            ex.ExportKhoa(pListKhoa, ref path, false);

            if (!string.IsNullOrEmpty(path))
            {
                System.Diagnostics.Process.Start(path);
            }
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
        public static int mabh;
        public static int manv;
        public static int mahd;
        public static string tennv;
        public static DateTime ngaytra;
        private void btn_Xuat_ButtonClick(object sender, EventArgs e)
        {
            //if (dgv_ChiTietPhieuNhap.Rows.Count == 0)
            //{
            //    MessageBox.Show("khong co du lieu de xuat");
            //    return;
            //}
            //manv = int.Parse(txtManv.Text);

            //tennv = blldn.loadtentheoma(txtManv.Text);

            //mabh = int.Parse(comboBox2.Text);

            //dataExcel.DataSource = bllbh.getmabaohanh(int.Parse(comboBox2.Text));
           

            //ExcelExportBaoHanh ex = new ExcelExportBaoHanh();

            //List<View_BieuMauBH> pListKhoa = new List<View_BieuMauBH>();

            //foreach (DataGridViewRow item in dataExcel.Rows)
            //{
            //    View_BieuMauBH i = new View_BieuMauBH();
            //    i.TenSanPham = item.Cells[0].Value.ToString();
            //    i.Seri = item.Cells[1].Value.ToString();
            //    i.LyDo = item.Cells[2].Value.ToString();


            //    pListKhoa.Add(i);
            //}


            //string path = string.Empty;

            //ex.ExportKhoa(pListKhoa, ref path, false);

            //DialogResult r = MessageBox.Show("ban co muon mo file khong", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if (!string.IsNullOrEmpty(path) && r == DialogResult.Yes)
            //{
            //    System.Diagnostics.Process.Start(path);
            //}

            //btn_Xuat.Enabled = false;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string ma = comboBox1.Text;
            if (ma.Equals("DTO.HoaDon"))
                return;

            if (ma.Length == 0)
            {
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
                return;
            }
            if (bllhd.KTTontai(int.Parse(ma))==false)
            {
                MessageBox.Show("Không tồn tại hóa đơn này");
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
                return;
            }

            HoaDon hd = bllhd.GetThongTinHoaDon(int.Parse(ma));
            soThangSuDung = DateTime.Now.Subtract(hd.NgayLapHoaDon.Value).Days / (365 / 12);
            


            List<SeriHD> lst = bllsr.loadsr(int.Parse(ma), bllbh.getlist(int.Parse(ma), soThangSuDung));
            

            //dataGridView3.DataSource = bllsr.loadsr(int.Parse(ma), bllbh.getlist(int.Parse(ma), soThangSuDung));

            lstspbh.Clear();

            string a = comboBox1.Text;
            if (a.Length > 0)
            {
                dataGridView2.DataSource = bllbh.getlist(int.Parse(ma), soThangSuDung);
                dataGridView3.DataSource = bllsr.loadsr(int.Parse(ma), bllbh.getlist(int.Parse(ma), soThangSuDung));

                dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
            }
            else if (comboBox1.Text.Length == 0)
            {
                dataGridView3.DataSource = null;
            }
            else
            {
                dataGridView3.DataSource = null;
            }
            dataGridView3.DataSource = bllsr.ListToDataTable(lst);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}