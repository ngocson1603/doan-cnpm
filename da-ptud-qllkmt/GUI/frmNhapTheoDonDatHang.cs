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
    public partial class frmNhapTheoDonDatHang : Form
    {
        Helper hp = new Helper();
        BLLDonDatHang bllddh = new BLLDonDatHang();
        BLLCTDonDatHang bllctddh = new BLLCTDonDatHang();
        BLLPhieuNhap bllpn = new BLLPhieuNhap();
        BLLSanPham bllsanpham = new BLLSanPham();
        DonDatHang dh;
        List<CTDonDatHang> lstCTDH;
        public static int ma;

        public frmNhapTheoDonDatHang()
        {
            InitializeComponent();
            dgv_CTDDH.AutoGenerateColumns = false;
        }

        private void frmNhapTheoDonDatHang_Load(object sender, EventArgs e)
        {
            cbb_MaDDH.DataSource = bllddh.GetDLDonDatHang();
            cbb_MaDDH.DisplayMember = "MaDDH";
            cbb_MaDDH.ValueMember = "MaDDH";

            txt_MaNhanVien.Text = frmTrangChuNhanVien.manv;
            
            dgv_DSSanPham.DataSource = bllsanpham.LoadSanPham();
            dgv_DSSanPham.Columns[7].Visible = false;
            dgv_DSSanPham.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
        }

        public int tinhTongThanhTien()
        {
            int tt = 0;
            lstCTDH.ForEach(t => tt += (int)t.ThanhTien);
            return tt;
        }

        private void cbb_MaDDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = cbb_MaDDH.SelectedValue.ToString();
            if (ma.Equals("DTO.DonDatHang"))
                return;
            int maDDH = int.Parse(ma);
            lstCTDH = new List<CTDonDatHang>();
            lstCTDH = bllctddh.GetDLCTDonDatHangTheoMa(maDDH);
            dgv_CTDDH.DataSource = lstCTDH;
            txtTongThanhTien.Text = tinhTongThanhTien().ToString();
            dh = bllddh.GetThongTinDonDatHang(maDDH);
            cbb_npp.Text = dh.MaNhaPhanPhoi.ToString();
        }

        List<ChiTietPhieuNhap> TaoChiTietPhieuNhap(int maPN)
        {
            List<ChiTietPhieuNhap> lstCTPN = new List<ChiTietPhieuNhap>();

            foreach (CTDonDatHang item in lstCTDH)
            {
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap()
                {
                    MaPhieuNhap = maPN,
                    MaSanPham = item.MaSanPham,
                    SoLuong = item.SoLuong,
                    TienNhap = item.ThanhTien
                };

                lstCTPN.Add(ctpn);
            }

            return lstCTPN;
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
           
        }
        public Image GetImg(string direct, int w, int h)
        {
            Image i = Image.FromFile(direct);
            return (Image)(new Bitmap(i, new Size(w, h)));
        }
        private void dgv_DSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string direct = hp.Directory() + dgv_DSSanPham.CurrentRow.Cells[7].Value.ToString();
            pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ma = int.Parse(dgv_CTDDH.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("Đã thêm");

            frmTrangChuNhanVien.pnltrang.Controls.Clear();
            hp.motrangcon(new frmNhapLinhKien(), frmTrangChuNhanVien.pnltrang);

            this.Close();
        }

        private void btn_LapPN_Click(object sender, EventArgs e)
        {
            ThemPhieuNhap cthdsp = new ThemPhieuNhap()
            {
                MaNhanVien = int.Parse(txt_MaNhanVien.Text),
                MaNhaPhanPhoi = int.Parse(cbb_npp.Text),
                NgayNhap = dateTimePicker1.Value,
                MaDDH = int.Parse(cbb_MaDDH.Text)
            };
            int a = 0;
            if (bllpn.postPN(cthdsp))
            {
                int maPN = bllpn.GetLastPhieuNhap();
                //foreach (var item in TaoChiTietPhieuNhap(maPN))
                //{
                //    ThemCTPN cthd = new ThemCTPN()
                //    {
                //        MaPhieuNhap = item.MaPhieuNhap,
                //        MaSanPham = item.MaSanPham,
                //        SoLuong = (int)item.SoLuong,
                //        TienNhap = (int)item.TienNhap

                //    };
                //    if (bllpn.postCTPN(cthd))
                //        continue;

                for (int x = 0; x < dgv_CTDDH.Rows.Count; x++)
                {
                    ThemCTPN cthd = new ThemCTPN()
                    {
                        MaPhieuNhap = maPN,
                        MaSanPham = int.Parse(dgv_CTDDH.Rows[a].Cells[1].Value.ToString()),
                        SoLuong = int.Parse(dgv_CTDDH.Rows[a].Cells[2].Value.ToString()),
                        TienNhap = int.Parse(dgv_CTDDH.Rows[a].Cells[3].Value.ToString())

                    };
                    a++;
                    if (bllpn.postCTPN(cthd))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Nhập hàng không thành công");
                        return;
                    }
                }
            }

            MessageBox.Show("Nhập hàng thành công");
            dgv_DSSanPham.DataSource = bllsanpham.LoadSanPham();
            
        }

        private void frmNhapTheoDonDatHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frmNhapLinhKien.dgv.Refresh();
        }
    }
}
