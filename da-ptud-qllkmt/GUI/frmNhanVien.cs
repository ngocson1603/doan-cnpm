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
    public partial class frmNhanVien : Form
    {
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        BLLNhanVien bllnhanvien = new BLLNhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = bllnhanvien.loaddanhsachNhanVien();

        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            try
            {
                numrow = e.RowIndex;
                txtManv.Text = dgv_NhanVien.Rows[numrow].Cells[0].Value.ToString();
                txtHotennv.Text = dgv_NhanVien.Rows[numrow].Cells[1].Value.ToString();
                dateTimeNgaysinhnv.Text = dgv_NhanVien.Rows[numrow].Cells[2].Value.ToString();
                dateTime_Ngayvaolam.Text = dgv_NhanVien.Rows[numrow].Cells[4].Value.ToString();
                txtchuvu.Text = dgv_NhanVien.Rows[numrow].Cells[5].Value.ToString();
                txtDiachinv.Text = dgv_NhanVien.Rows[numrow].Cells[6].Value.ToString();
                txtDienthoainv.Text = dgv_NhanVien.Rows[numrow].Cells[7].Value.ToString();
                if (this.dgv_NhanVien.CurrentRow.Cells[3].Value.Equals("Nam"))
                    rbtnNamnv.Checked = true;
                else
                    rbtnNunv.Checked = true;
            }
            catch
            {
                
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string a = txt_TimKiem.Text;
            if (a.Length > 0)
            {
                var orders = (from s in qllk.NhanViens where s.TenNhanVien.Contains(a.ToString()) select s).ToList();
                dgv_NhanVien.DataSource = orders;

            }
            else if (txt_TimKiem.Text.Length == 0)
            {
                dgv_NhanVien.DataSource = bllnhanvien.loaddanhsachNhanVien();
            }
            else
            {
                dgv_NhanVien.DataSource = bllnhanvien.loaddanhsachNhanVien();
            }
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            string a = "Nam";
            if (rbtnNunv.Checked == true)
            {
                a = "Nữ";
            }
            int ngay = int.Parse(DateTime.Now.Year.ToString());
            int ngaysinh = int.Parse(dateTimeNgaysinhnv.Value.Year.ToString());
            int kq = ngay - ngaysinh;
            if (Text == string.Empty || txtchuvu.Text == string.Empty || txtDiachinv.Text == string.Empty || txtDienthoainv.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (kq < 18)
            {
                MessageBox.Show("Khách hàng chưa đủ 18");
                return;
            }
            else
            {
                QuanLyNhanVien  nv= new QuanLyNhanVien()
                {
                    
                    TenNhanVien =txtHotennv.Text,
                    NgaySinh = dateTimeNgaysinhnv.Value,
                    GioiTinh = a,
                    NgayVaoLam =dateTime_Ngayvaolam.Value,
                    ChucVu = int.Parse(txtchuvu.Text),
                    DiaChi = txtDiachinv.Text,
                    SoDT =txtDienthoainv.Text
                };

                if (bllnhanvien.ThemNV(nv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_NhanVien.DataSource = bllnhanvien.loaddanhsachNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
            }

        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không!", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                string a = "Nam";
                if (rbtnNunv.Checked == true)
                {
                    a = "Nữ";
                }
                int ngay = int.Parse(DateTime.Now.Year.ToString());
                int ngaysinh = int.Parse(dateTimeNgaysinhnv.Value.Year.ToString());
                int kq = ngay - ngaysinh;
                if (txtHotennv.Text == string.Empty || txtchuvu.Text == string.Empty || txtDiachinv.Text == string.Empty || txtDienthoainv.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                if (kq < 18)
                {
                    MessageBox.Show("Nhân viên chưa đủ 18");
                    return;
                }
                else
                {
                    QuanLyNhanVien nv = new QuanLyNhanVien()
                    {

                        //MaNhanVien = txtManv.Text,
                        TenNhanVien = txtHotennv.Text,
                        NgaySinh = dateTimeNgaysinhnv.Value,
                        GioiTinh = a,
                        NgayVaoLam = dateTime_Ngayvaolam.Value,
                        ChucVu = int.Parse(txtchuvu.Text),
                        DiaChi = txtDiachinv.Text,
                        SoDT = txtDienthoainv.Text
                    };

                    if (bllnhanvien.suaNV(nv, int.Parse(txtManv.Text)))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgv_NhanVien.DataSource = bllnhanvien.loaddanhsachNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                        return;
                    }
                }
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không!", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                if (bllnhanvien.deleteNV(int.Parse(txtManv.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    dgv_NhanVien.DataSource = bllnhanvien.loaddanhsachNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
        }
    }
}
