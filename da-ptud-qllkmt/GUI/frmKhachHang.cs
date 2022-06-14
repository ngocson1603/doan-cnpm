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
    public partial class frmKhachHang : Form
    {
        QL_CUAHANGLINHKIENMAYTINHDataContext qlkh = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        BLLKhachHang bllkhachhang = new BLLKhachHang();
        BLLDangKy blldk = new BLLDangKy();
        Helper hp = new Helper();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachhang.DataSource = bllkhachhang.loaddanhsachKhachHang();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMakh.Text = dgvKhachhang.Rows[numrow].Cells[0].Value.ToString();
            txt_Gmail.Text = dgvKhachhang.Rows[numrow].Cells[1].Value.ToString();
            txt_Pass.Text = dgvKhachhang.Rows[numrow].Cells[2].Value.ToString();
            txtHotenkh.Text = dgvKhachhang.Rows[numrow].Cells[3].Value.ToString(); 
            dateTimeNgaysinhkhachhang.Text = dgvKhachhang.Rows[numrow].Cells[4].Value.ToString();
            if (this.dgvKhachhang.CurrentRow.Cells[5].Value.Equals("Nam"))
                rbtnNam.Checked = true;
            else
                rbtnNu.Checked = true;
            txt_Diachi.Text = dgvKhachhang.Rows[numrow].Cells[6].Value.ToString();
            txt_Sdt.Text = dgvKhachhang.Rows[numrow].Cells[7].Value.ToString();
        }
        public static string tenkhachhangkhongluu;
        public static string diachi;
        public static string sodienthoai;
        public static bool check = true;

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            if (hp.isEmail(txt_Gmail.Text) == false)
            {
                MessageBox.Show("Gmail sai định dạng");
                return;
            }
            if (hp.kiemtraSDT(txt_Sdt.Text) == false)
            {
                MessageBox.Show("Sđt sai định dạng");
                return;
            }
            if (checkBox1.Checked == true)
            {
                tenkhachhangkhongluu = txtHotenkh.Text;
                diachi = txt_Diachi.Text;
                sodienthoai = txt_Sdt.Text;
                check = false;
                MessageBox.Show("Đã thêm");
            }
            else
            {
                string a = "Nam";
                if (rbtnNu.Checked == true)
                {
                    a = "Nữ";
                }
                int ngay = int.Parse(DateTime.Now.Year.ToString());
                int ngaysinh = int.Parse(dateTimeNgaysinhkhachhang.Value.Year.ToString());
                int kq = ngay - ngaysinh;
                if (txt_Pass.Text == string.Empty || txtHotenkh.Text == string.Empty || txt_Diachi.Text == string.Empty || txt_Sdt.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                if (kq < 18)
                {
                    MessageBox.Show("Khách hàng chưa đủ 18");
                    return;
                }
                if (bllkhachhang.kiemtratontai(txt_Gmail.Text))
                {
                    MessageBox.Show("Tài khoản này đã được đăng ký");
                    return;
                }
                else
                {
                    KhachHang kh = new KhachHang()
                    {


                        //MaKH = int.Parse(txtMakh.Text),
                        Gmail = txt_Gmail.Text,
                        Pass = txt_Pass.Text,
                        TenKhachHang = txtHotenkh.Text,
                        Ngaysinh = dateTimeNgaysinhkhachhang.Value,
                        GioiTinh = a,
                        DiaChi = txt_Diachi.Text,
                        SDT = txt_Sdt.Text
                    };

                    if (bllkhachhang.ThemKH(kh))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvKhachhang.DataSource = bllkhachhang.loaddanhsachKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                        return;
                    }
                }

            }
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không!", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                if (bllkhachhang.deleteKH(int.Parse(txtMakh.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvKhachhang.DataSource = bllkhachhang.loaddanhsachKhachHang();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }

        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không!", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                if (hp.isEmail(txt_Gmail.Text) == false)
                {
                    MessageBox.Show("Gmail sai định dạng");
                    return;
                }
                if (hp.kiemtraSDT(txt_Sdt.Text) == false)
                {
                    MessageBox.Show("Sđt sai định dạng");
                    return;
                }
                string a = "Nam";
                if (rbtnNu.Checked == true)
                {
                    a = "Nữ";
                }
                int ngay = int.Parse(DateTime.Now.Year.ToString());
                int ngaysinh = int.Parse(dateTimeNgaysinhkhachhang.Value.Year.ToString());
                int kq = ngay - ngaysinh;
                if (txt_Pass.Text == string.Empty || txtHotenkh.Text == string.Empty || txt_Diachi.Text == string.Empty || txt_Sdt.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                if (kq < 18)
                {
                    MessageBox.Show("Khách hàng chưa đủ 18");
                    return;
                }
                //if (bllkhachhang.kiemtratontai(txt_Gmail.Text))
                //{
                //    MessageBox.Show("Tài khoản này đã được đăng ký");
                //    return;
                //}
                else
                {
                    KhachHang kh = new KhachHang()
                    {


                        //MaKH = int.Parse(txtMakh.Text),
                        Gmail = txt_Gmail.Text,
                        Pass = txt_Pass.Text,
                        TenKhachHang = txtHotenkh.Text,
                        Ngaysinh = dateTimeNgaysinhkhachhang.Value,
                        GioiTinh = a,
                        DiaChi = txt_Diachi.Text,
                        SDT = txt_Sdt.Text
                    };

                    if (bllkhachhang.suaKH(kh, int.Parse(txtMakh.Text)))
                    {
                        MessageBox.Show(" Sửa thành công");
                        dgvKhachhang.DataSource = bllkhachhang.loaddanhsachKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                        return;
                    }
                }
            }

        }

        private void txtMatimkiem_TextChanged(object sender, EventArgs e)
        {
            string a = txt_timkiem.Text;
            if (a.Length > 0)
            {
                var orders = (from s in qlkh.KhachHangs where s.TenKhachHang.Contains(a.ToString()) select s).ToList();
                dgvKhachhang.DataSource = orders;
             
            }
            else if (txt_timkiem.Text.Length == 0)
            {
                dgvKhachhang.DataSource = bllkhachhang.loaddanhsachKhachHang();
            }
            else
            {
                dgvKhachhang.DataSource = bllkhachhang.loaddanhsachKhachHang();
            }
        }

        private void txt_Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
