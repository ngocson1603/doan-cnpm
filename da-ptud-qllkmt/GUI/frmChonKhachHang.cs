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
    public partial class frmChonKhachHang : Form
    {
        BLLKhachHang bllkh = new BLLKhachHang();
        QL_CUAHANGLINHKIENMAYTINHDataContext qlkh = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        Helper hp = new Helper();
        public static int ma;
        private frmBanSanPham form1;
        public frmChonKhachHang(frmBanSanPham form1)
        {
            InitializeComponent();
        }

        private void frmChonKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllkh.LoadDanhSach();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string a = txt_timkiem.Text;
            if (a.Length > 0)
            {
                var orders = (from s in qlkh.KhachHangs where s.TenKhachHang.Contains(a.ToString()) select s).ToList();
                dataGridView1.DataSource = orders;
             
            }
            else if (txt_timkiem.Text.Length == 0)
            {
                dataGridView1.DataSource = bllkh.LoadDanhSach();
            }
            else
            {
                dataGridView1.DataSource = bllkh.LoadDanhSach();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ma = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("Đã thêm");

            frmTrangChuNhanVien.pnltrang.Controls.Clear();
            hp.motrangcon(new frmBanSanPham(), frmTrangChuNhanVien.pnltrang);

            this.Close();
        }
    }
}
