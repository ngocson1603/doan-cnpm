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
    public partial class frmDangKy : Form
    {
        BLLDangKy blldangky = new BLLDangKy();
        Helper hp = new Helper();
        public frmDangKy()
        {
            InitializeComponent();
            rdoNam.Checked = true;
        }

        private void gunathoat_Click(object sender, EventArgs e)
        {
            frmDN frm = new frmDN();
            frm.Show();
            this.Hide();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string a = "Nam";
            int ngay = int.Parse(DateTime.Now.Year.ToString());
            int ngaysinh = int.Parse(dateTimeNgay.Value.Year.ToString());
            int kq = ngay - ngaysinh;
            if (rdoNu.Checked == true)
            {
                a = "Nữ";
            }
            if (txtUserName.Text == string.Empty || txtPassWord.Text == string.Empty || txtHoTen.Text == string.Empty || txtDiaChi.Text == string.Empty || txtSoDienThoai.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (kq < 18)
            {
                MessageBox.Show("Khách hàng chưa đủ 18");
                return;
            }
            if (blldangky.kiemtratontai(txtUserName.Text))
            {
                MessageBox.Show("Tài khoản này đã được đăng ký");
                return;
            }
            if (hp.isEmail(txtUserName.Text) == false)
            {
                MessageBox.Show("Gmail sai định dạng");
                return;
            }
            if (hp.kiemtraSDT(txtSoDienThoai.Text) == false)
            {
                MessageBox.Show("Sđt sai định dạng");
                return;
            }
            else
            {
                KhachHang kh = new KhachHang()
                {
                    Gmail = txtUserName.Text,
                    Pass = txtPassWord.Text,
                    TenKhachHang = txtHoTen.Text,
                    Ngaysinh = dateTimeNgay.Value,
                    GioiTinh = a,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSoDienThoai.Text
                };

                if (blldangky.themKhachHang(kh))
                {
                    MessageBox.Show("Đăng ký thành công");
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại");
                    return;
                }
            }
        }
    }
}
