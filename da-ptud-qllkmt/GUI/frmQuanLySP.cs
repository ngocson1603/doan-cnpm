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
using System.IO;
namespace GUI
{
    public partial class frmQuanLySP : Form
    {
        Helper hp = new Helper();
        BLLSanPham bllsanpham = new BLLSanPham();
        BLLLSPHSX bll = new BLLLSPHSX();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public frmQuanLySP()
        {
            InitializeComponent();
            
        }

        private void frmQuanLySP_Load(object sender, EventArgs e)
        {
            dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
            txt_LoaiSP.DataSource = bll.loadlsp();
            txt_LoaiSP.DisplayMember = "TenLoaiSanPham";
            txt_LoaiSP.ValueMember = "MaLoaiSanPham";
            txt_LoaiSP.SelectedIndex = 0;

            txt_HangSX.DataSource = bll.loadhsx();
            txt_HangSX.DisplayMember = "TenHangSanXuat";
            txt_HangSX.ValueMember = "MaHangSanXuat";
            txt_HangSX.SelectedIndex = 0;
        }
        public OpenFileDialog openFileDialog = new OpenFileDialog();
        private void btn_Them_Click(object sender, EventArgs e)
        {

            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png ";
            openFileDialog.FilterIndex = 1;
            string pathss = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string CorrectFileNames = System.IO.Path.GetFileName(openFileDialog.FileName);
            string a = pathss + "\\Images\\" + CorrectFileNames;


            if (!File.Exists(a))
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string CorrectFileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                System.IO.File.Copy(openFileDialog.FileName, paths + "\\Images\\" + CorrectFileName);
                QuanLySanPham kh = new QuanLySanPham()
                {
                    //MaSanPham = int.Parse(txt_MaSP.Text),
                    TenSanPham = txt_TenSP.Text,
                    LoaiSanPham = int.Parse(txt_LoaiSP.SelectedValue.ToString()),
                    HangSanXuat = int.Parse(txt_HangSX.SelectedValue.ToString()),
                    HSD = int.Parse(txtHSD.Text),
                    GiaBan = int.Parse(txt_GiaBan.Text),
                    TonKho = int.Parse(txt_TonKho.Text),
                    Image = txt_Image.Text
                };

                if (bllsanpham.postSP(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
                
            }
            else if (File.Exists(a))
            {
                QuanLySanPham kh = new QuanLySanPham()
                {
                    //MaSanPham = int.Parse(txt_MaSP.Text),
                    TenSanPham = txt_TenSP.Text,
                    LoaiSanPham = int.Parse(txt_LoaiSP.SelectedValue.ToString()),
                    HangSanXuat = int.Parse(txt_HangSX.SelectedValue.ToString()),
                    HSD = int.Parse(txtHSD.Text),
                    GiaBan = int.Parse(txt_GiaBan.Text),
                    TonKho = int.Parse(txt_TonKho.Text),
                    Image = txt_Image.Text
                };

                if (bllsanpham.postSP(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
                
            }       
        }

        private void dgv_QLLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_QLLK.Rows[e.RowIndex];
                txt_MaSP.Text = row.Cells[0].Value.ToString();
                
                txt_TenSP.Text = row.Cells[1].Value.ToString();


                txt_LoaiSP.Text = bll.tenl(int.Parse(row.Cells[2].Value.ToString()));
                txt_HangSX.Text = bll.tenh(int.Parse(row.Cells[3].Value.ToString()));
                txtHSD.Text = row.Cells[4].Value.ToString();
                txt_GiaBan.Text = row.Cells[5].Value.ToString();
                txt_TonKho.Text = row.Cells[6].Value.ToString();
                txt_Image.Text = row.Cells[7].Value.ToString();

                string direct = hp.Directory() + dgv_QLLK.CurrentRow.Cells[7].Value.ToString();
                pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);

                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
                toolStripButton1.Enabled = true;
                btn_nhapvao.Enabled = true;
            }
        }
        public Image GetImg(string direct, int w, int h)
        {
            Image i = Image.FromFile(direct);
            return (Image)(new Bitmap(i, new Size(w, h)));
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png ";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //if (openFileDialog.CheckFileExists)
                //{

                //    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                //    string CorrectFileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                //    System.IO.File.Copy(openFileDialog.FileName, paths + "\\Images\\" + CorrectFileName);
                //    MessageBox.Show("Upload thành công");

                //}
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                txt_Image.Text = openFileDialog.SafeFileName;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (bllsanpham.deleteSP(int.Parse(txt_MaSP.Text)))
            {
                MessageBox.Show("Xóa thành công");
                dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            QuanLySanPham kh = new QuanLySanPham()
            {
                //MaSanPham = int.Parse(txt_MaSP.Text),
                TenSanPham = txt_TenSP.Text,
                LoaiSanPham = int.Parse(txt_LoaiSP.SelectedValue.ToString()),
                HangSanXuat = int.Parse(txt_HangSX.SelectedValue.ToString()),
                HSD = int.Parse(txtHSD.Text),
                GiaBan = int.Parse(txt_GiaBan.Text),
                TonKho = int.Parse(txt_TonKho.Text),
                Image = txt_Image.Text
            };
            if (bllsanpham.putSP(kh, int.Parse(txt_MaSP.Text)))
            {
                MessageBox.Show("Sửa thông tin thành công");
                dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại");
                return;
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ban
        public static BindingList<ThemSanPham> lstsp = new BindingList<ThemSanPham>();

        //nhap
        public static BindingList<ThemSanPham> lstnhap = new BindingList<ThemSanPham>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (a.Length > 0)
            {
                var orders = (from s in qllk.View_SanPhams where s.TenSanPham.Contains(a.ToString()) select s).ToList();
                dgv_QLLK.DataSource = orders;

            }
            else if (textBox1.Text.Length == 0)
            {
                dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
            }
            else
            {
                dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            int so = 1;
            string ma = txt_MaSP.Text;
            int tonkho = so;
            string tensp = txt_TenSP.Text;
            string loai = txt_LoaiSP.SelectedValue.ToString();
            string hang = txt_HangSX.SelectedValue.ToString();
            string gia = txt_GiaBan.Text;
            string anh = txt_Image.Text;
            if (lstsp.Any(n => n.ma == ma))
            {
                MessageBox.Show("Đã thêm");
                var item = lstsp.SingleOrDefault(x => x.ma == ma);

                if (item.soluong == int.Parse(txt_TonKho.Text) - 1)
                {
                    MessageBox.Show("Hiện tại số lượng sản phẩm tại cửa hàng không còn đủ");
                    return;
                }
                else
                {
                    item.soluong++;
                }
            }
            else
            {
                MessageBox.Show("Đã thêm");

                ThemSanPham sp = new ThemSanPham(tensp, loai, hang, gia, tonkho, anh, ma);
                lstsp.Add(sp);
                
            }
            //toolStripButton1.Enabled = false;
        }

        private void frmQuanLySP_FormClosed(object sender, FormClosedEventArgs e)
        {
            toolStripButton1.Enabled = false;
        }

        private void btn_nhapvao_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            string ma = txt_MaSP.Text;
            
            string tensp = txt_TenSP.Text;
            string loai = txt_LoaiSP.SelectedValue.ToString();
            string hang = txt_HangSX.SelectedValue.ToString();
            string gia = txt_GiaBan.Text;
            string anh = txt_Image.Text;
           
                MessageBox.Show("Đã thêm");
                ThemSanPham sp = new ThemSanPham(tensp, loai, hang, gia, soluong, anh, ma);
                lstnhap.Add(sp);
        }

        private void txt_TonKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtHSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_GiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
