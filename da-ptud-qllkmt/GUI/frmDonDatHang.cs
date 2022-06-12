using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class frmDonDatHang : Form
    {
        BLLNhanVien bllNhanVien = new BLLNhanVien();
        BLLNPP bllNhaPhanPhoi = new BLLNPP();
        BLLSanPham bllSanPham = new BLLSanPham();
        BLLDonDatHang bllDonDatHang = new BLLDonDatHang();
        BLLCTDonDatHang bllCTDonDatHang = new BLLCTDonDatHang();
        int _maDonDatHang;

        public frmDonDatHang()
        {
            InitializeComponent();
            dgvDonDatHang.AutoGenerateColumns = false;
            dgvChiTietDonDatHang.AutoGenerateColumns = false;
        }

        public void loadDonDatHang()
        {
            dgvDonDatHang.DataSource = bllDonDatHang.GetDLDonDatHang();
        }

        public void loadDLCTDonDatHang()
        {
            dgvChiTietDonDatHang.DataSource = bllCTDonDatHang.GetCTDonDatHang();
        }

        public void loadDLCTDonDatHangTheoMa()
        {
            dgvChiTietDonDatHang.DataSource = null;
            dgvChiTietDonDatHang.ClearSelection();
            dgvChiTietDonDatHang.DataSource = bllCTDonDatHang.GetDLCTDonDatHangTheoMa(_maDonDatHang);
        }

        private void btnTaoDonDatHang_Click(object sender, EventArgs e)
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
                    loadDonDatHang();
                    grbChiTietDonDatHang.Enabled = grbThongTin.Enabled = true;
                    grbDonDatHang.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Tạo đơn đặt hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi trong quá trình tạo đơn đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
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

            grbThongTin.Enabled = grbChiTietDonDatHang.Enabled = false;
            txtThanhTien.Enabled = false;
        }


        string tongtien(DataGridView gv)
        {
            int tt = 0;
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                int gia = int.Parse(gv.CurrentRow.Cells[4].Value.ToString());
                tt += gia;
            }
            return tt.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text.Length == 0 || txtSoLuong.Text.Length == 0)
            {
                return;
            }
            int sl = int.Parse(txtSoLuong.Text);
            int dg = int.Parse(txtDonGia.Text);
            int? tt;

            CTDonDatHang ctddh = new CTDonDatHang();
            ctddh.MaDDH = _maDonDatHang;
            ctddh.MaSanPham = int.Parse(cbbSanPham.SelectedValue.ToString());
            ctddh.SoLuong = int.Parse(txtSoLuong.Text);
            ctddh.DonGia = int.Parse(txtDonGia.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
            ctddh.ThanhTien = int.Parse(txtThanhTien.Text);
            int kq = bllCTDonDatHang.ThemCTDonDatHang(ctddh);
            if (kq == 1)
            {
                MessageBox.Show("Thêm chi tiết đon đặt hàng thành công");
                loadDLCTDonDatHangTheoMa();
                txtThanhTien.Text = tongtien(dgvChiTietDonDatHang);
            }
            else if (kq == 0)
            {
                MessageBox.Show("Thêm không thành công");
            }
            else
            {
                MessageBox.Show("Mat hang nay da ton tai trong don dat hang");
                return;
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {

            if (dgvChiTietDonDatHang.Rows.Count <= 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất 1 chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Hoàn tất đơn đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChiTietDonDatHang.DataSource = dgvDonDatHang.DataSource = null;
                dgvDonDatHang.ClearSelection();
                dgvChiTietDonDatHang.ClearSelection();
                grbChiTietDonDatHang.Enabled = grbThongTin.Enabled = false;
                grbDonDatHang.Enabled = true;
                txtDonGia.Text = txtSoLuong.Text = txtThanhTien.Text = "";
                cbbSanPham.SelectedIndex = cbbNhanVienLap.SelectedIndex = cbbNhaPhanPhoi.SelectedIndex = 0;
            }
        }
    }
}
