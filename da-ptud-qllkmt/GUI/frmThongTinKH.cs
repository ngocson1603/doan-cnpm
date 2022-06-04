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
    public partial class frmThongTinKH : Form
    {
        BLLDangKy blldangky = new BLLDangKy();
        BLLKhachHang bllkh = new BLLKhachHang();
        public static string hoten;
        public static int makh;
        public frmThongTinKH()
        {
            InitializeComponent();
        }

        private void frmThongTinKH_Load(object sender, EventArgs e)
        {
            makh = bllkh.loadmakh(frmDN.taikhoan);
            initdb();
            
        }

        void initdb()
        {
            List<KhachHang> list = blldangky.loadKhachHangAPI(makh);
            foreach (KhachHang kh in list)
            {
                string user = kh.Gmail.ToString();
                string pass = kh.Pass.ToString();
                string tenkh = kh.TenKhachHang.ToString();
                string ngays = kh.Ngaysinh.ToString();
                string gioitinh = kh.GioiTinh.ToString();
                string diachi = kh.DiaChi.ToString();
                string sdt = kh.SDT.ToString();
                int ma = kh.MaKH;

                txtUserName.Text = user;
                txtPassWord.Text = pass;
                txtHoTen.Text = tenkh;
                dateTimeNgay.Text = ngays;
                if (gioitinh == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
                txtDiaChi.Text = diachi;
                txtSoDienThoai.Text = sdt;
                txtMa.Text = ma.ToString();
            }
            hoten = txtHoTen.Text;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
            int ngay = int.Parse(DateTime.Now.Year.ToString());
            int ngaysinh = int.Parse(dateTimeNgay.Value.Year.ToString());
            int kq = ngay - ngaysinh;
            string gioitinh = "Nam";
            if(rdoNu.Checked==true){
                gioitinh = "Nữ";
            }
            if (txtUserName.Text == string.Empty || txtPassWord.Text == string.Empty || txtHoTen.Text == string.Empty || txtDiaChi.Text == string.Empty || txtSoDienThoai.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (kq < 18)
            {
                MessageBox.Show("Tuổi phải lớn hơn 18", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //if(blldangky.suaThongTin(txtUserName.Text,txtPassWord.Text,txtHoTen.Text,dateTimeNgay.Text,gioitinh,txtDiaChi.Text,txtSoDienThoai.Text)){
            //    MessageBox.Show("Sửa thông tin thành công");
            //}
            KhachHang kh = new KhachHang();
            kh.Gmail = txtUserName.Text;
            kh.Pass = txtPassWord.Text;
            kh.TenKhachHang = txtHoTen.Text;
            kh.Ngaysinh = DateTime.Parse(dateTimeNgay.Text);
            kh.GioiTinh = gioitinh;
            kh.DiaChi = txtDiaChi.Text;
            kh.SDT = txtSoDienThoai.Text;
            if (blldangky.suaKhachHang(kh,int.Parse(txtMa.Text)))
            {
                MessageBox.Show("Sửa thông tin thành công");
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại");
                return;
            }
        }

        private void gunathoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát?", "Exit", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPassWord.PasswordChar == '*')
            {
                pictureBox1.Load("AnhLapTop\\eye1.png");
                pictureBox1.BringToFront();
                txtPassWord.PasswordChar = '\0';
            }
            else {
                pictureBox1.Load("AnhLapTop\\eye2.png");
                pictureBox1.BringToFront();
                txtPassWord.PasswordChar = '*';
            }
        }
    }
}
