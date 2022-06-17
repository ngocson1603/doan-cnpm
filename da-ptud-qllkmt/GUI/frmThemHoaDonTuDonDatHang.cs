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
    public partial class frmThemHoaDonTuDonDatHang : Form
    {
        BLLHoaDon bllhoadon = new BLLHoaDon();
        BLLGioHang bllgio = new BLLGioHang();
        BLLKhachHang bllkh = new BLLKhachHang();
        BLLDangNhap blldn = new BLLDangNhap();
        BLLSeri bllsr = new BLLSeri();
        BLLBaoHanh bllbh = new BLLBaoHanh();
        public frmThemHoaDonTuDonDatHang()
        {
            InitializeComponent();
            dgv_HoaDon.AutoGenerateColumns = false;
            dgv_Chitiethoadon.AutoGenerateColumns = false;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (txt_MaKH.Text == a.ToString())
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
                return;
            }
            QuanLyHoaDon cthdsp = new QuanLyHoaDon()
            {
                MaKH = int.Parse(txt_MaKH.Text),
                NgayLapHoaDon = dateTimePicker1.Value,
                MaNhanVien = int.Parse(txt_MaNV.Text)
            };

            if (bllhoadon.postHD(cthdsp))
            {
                for (int x = 0; x < dgv_Chitiethoadon.Rows.Count; x++)
                {
                    ThemCTHD cthd = new ThemCTHD()
                    {
                        MaHoaDon = bllhoadon.loadmacuoi(int.Parse(txt_MaNV.Text)),
                        MaSanPham = int.Parse(dgv_Chitiethoadon.Rows[a].Cells[1].Value.ToString()),
                        giaban = int.Parse(dgv_Chitiethoadon.Rows[a].Cells[3].Value.ToString()),
                        soluong = int.Parse(dgv_Chitiethoadon.Rows[a].Cells[2].Value.ToString()),
                        TongTien = int.Parse(dgv_Chitiethoadon.Rows[a].Cells[3].Value.ToString()) * int.Parse(dgv_Chitiethoadon.Rows[a].Cells[2].Value.ToString()),

                    };

                    if (bllgio.postGioHangCTHD(cthd))
                    {
                        for (int i = 0; i < int.Parse(dgv_Chitiethoadon.Rows[a].Cells[2].Value.ToString()); i++)
                        {
                            SeriHD sr = new SeriHD()
                            {
                                Seri = bllsr.loadseritheoma(int.Parse(dgv_Chitiethoadon.Rows[a].Cells[1].Value.ToString())),
                                MaHoaDon = bllhoadon.loadmacuoi(int.Parse(txt_MaNV.Text)),
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
            }

            XuatHD();
            xoa();
           
            toolStripButton1.Enabled = false;
        }
        public void xoa()
        {
            if (bllhoadon.xoaCTDH(int.Parse(dgv_HoaDon.CurrentRow.Cells[0].Value.ToString())))
            {
                bllhoadon.xoaDH(int.Parse(dgv_HoaDon.CurrentRow.Cells[0].Value.ToString()));
                dgv_HoaDon.DataSource = bllhoadon.DHOnl();
                dgv_Chitiethoadon.DataSource = null;
            }
            else
            {
                return;
            }
        }
        public static string taikhoan;
        public static int mahd;
        public static int tongtien;
        public static int manv;
        public static string ten;
        public static string tennv;
        public void XuatHD()
        {
            ten = txt_TenKH.Text;
            tennv = blldn.loadtentheoma(txt_MaNV.Text);

            dataExcel.DataSource = bllgio.loadBieuMauGioHangAPI(int.Parse(txt_MaKH.Text), bllhoadon.loadmacuoi(int.Parse(txt_MaNV.Text)));
            taikhoan = txt_MaKH.Text;
            mahd = bllhoadon.loadmacuoionl();
            ExcelExportOnl ex = new ExcelExportOnl();
            if (dgv_HoaDon.Rows.Count == 0)
            {
                MessageBox.Show("khong co du lieu de xuat");
                return;
            }
            int a = 0;
            for (int x = 0; x < dataExcel.Rows.Count; x++)
            {
                tongtien += int.Parse(dataExcel.Rows[a].Cells[5].Value.ToString());
                a++;
            }
            manv = int.Parse(txt_MaNV.Text);
            List<View_BieuMauGio> pListKhoa = new List<View_BieuMauGio>();

            foreach (DataGridViewRow item in dataExcel.Rows)
            {
                View_BieuMauGio i = new View_BieuMauGio();
                i.TenSanPham = item.Cells[0].Value.ToString();
                i.soluong = int.Parse(item.Cells[1].Value.ToString());
                i.giaban = int.Parse(item.Cells[2].Value.ToString());
                i.NgayLapHoaDon = DateTime.Parse(item.Cells[3].Value.ToString());
                i.TongTien = int.Parse(item.Cells[5].Value.ToString());

                pListKhoa.Add(i);
            }


            string path = string.Empty;

            ex.ExportKhoa(pListKhoa, ref path, false);

            if (!string.IsNullOrEmpty(path))
            {
                System.Diagnostics.Process.Start(path);
            }
        }

        private void frmThemHoaDonTuDonDatHang_Load(object sender, EventArgs e)
        {
            txt_MaNV.Text = frmTrangChuNhanVien.manv;
            dgv_HoaDon.DataSource = bllhoadon.DHOnl();
            dgv_HoaDon.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_Chitiethoadon.DataSource = bllhoadon.CTDHOnl(int.Parse(dgv_HoaDon.CurrentRow.Cells[0].Value.ToString()));
                txt_TenKH.Text = dgv_HoaDon.CurrentRow.Cells[1].Value.ToString();
                dgv_Chitiethoadon.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
                toolStripButton1.Enabled = true;

            }
        }
    }
}
