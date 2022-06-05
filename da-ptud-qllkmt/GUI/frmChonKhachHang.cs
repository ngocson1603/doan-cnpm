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
        public static int ma;
        public frmChonKhachHang()
        {
            InitializeComponent();
        }

        private void frmChonKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllkh.loaddanhsachKhachHang();
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
                dataGridView1.DataSource = bllkh.loaddanhsachKhachHang();
            }
            else
            {
                dataGridView1.DataSource = bllkh.loaddanhsachKhachHang();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBanSanPham.chonmanv = ma;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ma = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            string ma = txt_MaSP.Text;

            string tensp = txt_TenSP.Text;
            string loai = txt_LoaiSP.SelectedValue.ToString();
            string hang = txt_HangSX.SelectedValue.ToString();
            string gia = txt_GiaBan.Text;
            string anh = txt_Image.Text;

            MessageBox.Show("Đã thêm");
            ThemSanPham sp = new ThemSanPham(tensp, loai, hang, gia, anh, ma);
            lstnhap.Add(sp);

            MessageBox.Show("Đã thêm");
        }
    }
}
