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
    public partial class frmDonDatHang_v2 : Form
    {
        BLLNhanVien bllNhanVien = new BLLNhanVien();
        BLLNPP bllNhaPhanPhoi = new BLLNPP();
        BLLSanPham bllSanPham = new BLLSanPham();
        BLLDonDatHang bllDonDatHang = new BLLDonDatHang();
        BLLCTDonDatHang bllCTDonDatHang = new BLLCTDonDatHang();
        int _maDonDatHang;
        int? tt;
        List<CTDonDatHang> lstCTDDH = new List<CTDonDatHang>();

        public frmDonDatHang_v2()
        {
            InitializeComponent();
            dgvChiTietDonDatHang.AutoGenerateColumns = false;
        }

        private void frmDonDatHang_v2_Load(object sender, EventArgs e)
        {
            cbbNhanVienLap.DataSource = bllNhanVien.loaddanhsachNhanVien();
            cbbNhanVienLap.DisplayMember = "TenNhanVien";
            cbbNhanVienLap.ValueMember = "MaNhanVien";

            cbbNhaPhanPhoi.DataSource = bllNhaPhanPhoi.loadnpp();
            cbbNhaPhanPhoi.DisplayMember = "TenNhaPhanPhoi";
            cbbNhaPhanPhoi.ValueMember = "MaNhaPhanPhoi";

            cbbSanPham.DataSource = bllSanPham.GetSLTheoDK();
            cbbSanPham.DisplayMember = "TenSanPham";
            cbbSanPham.ValueMember = "MaSanPham";
            txtThanhTien.Enabled = false;
        }

        private void LoadListCTDDH(List<CTDonDatHang> lst)
        {
            dgvChiTietDonDatHang.DataSource = null;
            dgvChiTietDonDatHang.ClearSelection();
            dgvChiTietDonDatHang.DataSource = lst;
        }

        private void LoadControlChucNang()
        {
            cbbSanPham.SelectedIndex = 0;
            grbThongTin.Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (grbThongTin.Controls.OfType<TextBox>().Any(t => t.Text == string.Empty))
            {
                MessageBox.Show("Nhap day du du lieu");
                return;
            }

            CTDonDatHang ctdh = new CTDonDatHang()
            {
                MaSanPham = int.Parse(cbbSanPham.SelectedValue.ToString()),
                SoLuong = int.Parse(txtSoLuong.Text),
                DonGia = int.Parse(txtDonGia.Text),
                ThanhTien = int.Parse(txtThanhTien.Text)
            };

            if (lstCTDDH.Any(t => t.MaSanPham == ctdh.MaSanPham))
            {
                CTDonDatHang ctdhSua = lstCTDDH.First(t => t.MaSanPham == ctdh.MaSanPham);
                ctdhSua.SoLuong += ctdh.SoLuong;
                ctdhSua.DonGia = ctdh.DonGia;
                ctdhSua.ThanhTien += ctdh.ThanhTien;
            }
            else
            {
                lstCTDDH.Add(ctdh);
            }

            LoadListCTDDH(lstCTDDH);
            LoadControlChucNang();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text.Length == 0 || txtSoLuong.Text.Length ==0)
                return;
            else
            {
                int sl = int.Parse(txtSoLuong.Text);
                int dg = int.Parse(txtDonGia.Text);
                tt = sl * dg;
                txtThanhTien.Text = tt.ToString();
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text.Length == 0 || txtSoLuong.Text.Length == 0)
                return;
            else
            {
                int sl = int.Parse(txtSoLuong.Text);
                int dg = int.Parse(txtDonGia.Text);
                tt = sl * dg;
                txtThanhTien.Text = tt.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvChiTietDonDatHang.SelectedRows[0];
            int maSP = int.Parse(r.Cells[0].Value.ToString());
            CTDonDatHang ctdhXoa = lstCTDDH.First(t => t.MaSanPham  == maSP);
            lstCTDDH.Remove(ctdhXoa);
            LoadListCTDDH(lstCTDDH);
            LoadControlChucNang();
        }

        private void dgvChiTietDonDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow r = dgvChiTietDonDatHang.SelectedRows[0];
            cbbSanPham.Text = bllSanPham.LayTenSanPhamTheoMa(int.Parse(r.Cells[0].Value.ToString()));
            txtSoLuong.Text = r.Cells[1].Value.ToString();
            txtDonGia.Text = r.Cells[2].Value.ToString();
            txtThanhTien.Text = r.Cells[3].Value.ToString();
        }

        private void TaoDonDatHang()
        {
            DonDatHang ddh = new DonDatHang();
            try
            {
                ddh.NgayLap = dtpNgayLap.Value;
                ddh.MaNhanVien = int.Parse(cbbNhanVienLap.SelectedValue.ToString());
                ddh.MaNhaPhanPhoi = int.Parse(cbbNhaPhanPhoi.SelectedValue.ToString());
                if (bllDonDatHang.ThemDonDatHang(ddh))
                {
                    _maDonDatHang = bllDonDatHang.GetLastDonDatHang();
                }
                else
                {
                    MessageBox.Show("Tạo đơn đặt hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi trong quá trình tạo đơn đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ThemCTDDH()
        {
            foreach (CTDonDatHang ct in lstCTDDH)
            {
                ct.MaDDH = _maDonDatHang;
                int kq = bllCTDonDatHang.ThemCTDonDatHang(ct);
                if (kq == 1)
                    continue;
                else
                {
                    MessageBox.Show("Co loi trong qua trinh them chi tiet dat hang");
                    break;
                }
            }
            MessageBox.Show("Them don dat hang thanh cong");


        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            TaoDonDatHang();
            ThemCTDDH();
            dgvChiTietDonDatHang.DataSource = null;
        }
    }
}
