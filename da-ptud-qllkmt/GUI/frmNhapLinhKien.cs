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
using GUI.XuLy;

namespace GUI
{
    public partial class frmNhapLinhKien : Form
    {
        BLLPhieuNhap bllpn = new BLLPhieuNhap();
        BLLGioHang bllgio = new BLLGioHang();
        BLLNPP bllnpp = new BLLNPP();
        BLLDangNhap blldn = new BLLDangNhap();
        public frmNhapLinhKien()
        {
            InitializeComponent();
        }
        public static DataGridView dgv;
        private void frmNhapLinhKien_Load(object sender, EventArgs e)
        {
            //dgv_PhieuNhap.DataSource = bllpn.LoadPN();
            //dgv_ChiTietPhieuNhap.DataSource = bllpn.LoadCTPN();
            dgv_PhieuNhap.DataSource = bllpn.LoadPhieuNhapNV(int.Parse(frmTrangChuNhanVien.manv));
            dgv_PhieuNhap.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
            //dgv.Refresh();
            loaddata(frmQuanLySP.lstnhap);
            if (dgv_Chitiethoadon.Rows.Count >= 0)
            {
                dgv_Chitiethoadon.Columns[5].Visible = false;
            }
            txt_MaNhanVien.Text = frmTrangChuNhanVien.manv;


            cbb_npp.DataSource = bllnpp.loadnpp();
            cbb_npp.DisplayMember = "MaNhaPhanPhoi";
            cbb_npp.ValueMember = "MaNhaPhanPhoi";



            // 
            txt_maddh.Text = frmNhapTheoDonDatHang.ma.ToString();

        }

        private void btn_ThemPN_Click(object sender, EventArgs e)
        {
            //ThemPhieuNhap cthdsp = new ThemPhieuNhap()
            //{
            //    //MaPhieuNhap = int.Parse(txt_MaPhieuNhap.Text),
            //    MaNhanVien = int.Parse(txt_MaNhanVien.Text),
            //    MaNhaPhanPhoi = int.Parse(cbb_npp.Text),
            //    TongTien = int.Parse(txt_TongTien.Text),
            //    NgayNhap = dateTimePicker1.Value
            //};

            //if (bllpn.postPN(cthdsp))
            //{
            //    MessageBox.Show("Thêm thành công");
            //    dgv_PhieuNhap.DataSource = bllpn.LoadPN();
            //}
            //else
            //{
            //    MessageBox.Show("Thêm thất bại");
            //}
            loaddata(frmQuanLySP.lstnhap);

            int a = 0;
            ThemPhieuNhap cthdsp = new ThemPhieuNhap()
            {
                MaNhanVien = int.Parse(txt_MaNhanVien.Text),
                MaNhaPhanPhoi = int.Parse(cbb_npp.Text),
                //TongTien = int.Parse(txt_TongTien.Text),
                NgayNhap = dateTimePicker1.Value,
                MaDDH = int.Parse(txt_maddh.Text)
            };

            if (bllpn.postPN(cthdsp))
            {
                dgv_PhieuNhap.DataSource = bllpn.LoadPhieuNhapNV(int.Parse(txt_MaNhanVien.Text));
                int so = dgv_PhieuNhap.RowCount;
                dgv_PhieuNhap.CurrentCell = dgv_PhieuNhap[1, so - 1];
                txt_MaPhieuNhap.Text = dgv_PhieuNhap.CurrentRow.Cells[0].Value.ToString();
                for (int x = 0; x < dgv_Chitiethoadon.Rows.Count; x++)
                {
                    ThemCTPN cthd = new ThemCTPN()
                    {
                        MaPhieuNhap = int.Parse(txt_MaPhieuNhap.Text),
                        MaSanPham = int.Parse(dgv_Chitiethoadon.Rows[a].Cells[6].Value.ToString()),
                        SoLuong = int.Parse(dgv_Chitiethoadon.Rows[a].Cells[4].Value.ToString()),
                        TienNhap = int.Parse(dgv_Chitiethoadon.Rows[a].Cells[3].Value.ToString())

                    };
                    a++;
                    if (bllpn.postCTPN(cthd))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Nhập hàng không thành công");
                        break;
                    }
                }
                MessageBox.Show("Nhập hàng thành công");
                dgv_PhieuNhap.DataSource = bllpn.LoadPhieuNhapNV(int.Parse(txt_MaNhanVien.Text));
            }


            frmQuanLySP.lstnhap.Clear();


        }




        private void btn_XoaPN_Click(object sender, EventArgs e)
        {
            //if (bllpn.deletePN(int.Parse(txt_MaPhieuNhap.Text)))
            //{
            //    MessageBox.Show("Xóa thành công");
            //    dgv_PhieuNhap.DataSource = bllpn.LoadPN();
            //}
            //else
            //{
            //    MessageBox.Show("Xóa thất bại");
            //    return;
            //}


            if (bllpn.deleteCTPN(int.Parse(txt_MaPhieuNhap.Text)))
            {
                bllpn.deletePN(int.Parse(txt_MaPhieuNhap.Text));
                MessageBox.Show("Xóa thành công");
                dgv_PhieuNhap.DataSource = bllpn.LoadPhieuNhapNV(int.Parse(txt_MaNhanVien.Text));
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }
        }

        private void btn_SuaPN_Click(object sender, EventArgs e)
        {
            //PhieuNhap cthdsp = new PhieuNhap()
            //{
            //    MaPhieuNhap = int.Parse(txt_MaPhieuNhap.Text),
            //    MaNhanVien = int.Parse(txt_MaNhanVien.Text),
            //    MaNhaPhanPhoi = int.Parse(cbb_npp.Text),
            //    TongTien = int.Parse(txt_TongTien.Text),
            //    NgayNhap = dateTimePicker1.Value
            //};

            //if (bllpn.putPN(cthdsp, int.Parse(txt_MaPhieuNhap.Text)))
            //{
            //    MessageBox.Show("Sửa thành công");
            //    dgv_PhieuNhap.DataSource = bllpn.LoadPhieuNhapNV(int.Parse(txt_MaNhanVien.Text));
            //}
            //else
            //{
            //    MessageBox.Show("Sửa thất bại");
            //}
            ThemPhieuNhap kh = new ThemPhieuNhap()
            {

                MaNhanVien = int.Parse(txt_MaNhanVien.Text),
                MaNhaPhanPhoi = int.Parse(cbb_npp.Text),
                //TongTien = int.Parse(txt_TongTien.Text),
                NgayNhap = dateTimePicker1.Value,
                MaDDH = int.Parse(txt_maddh.Text)
            };

            if (bllpn.putPN(kh, int.Parse(txt_MaPhieuNhap.Text)))
            {
                MessageBox.Show(" Sửa thành công");
                dgv_PhieuNhap.DataSource = bllpn.LoadPhieuNhapNV(int.Parse(txt_MaNhanVien.Text));
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
                return;
            }
           

        }

        //private void btn_ThemCTPN_Click(object sender, EventArgs e)
        //{
        //    ThemCTPN cthdsp = new ThemCTPN()
        //    {
        //        MaPhieuNhap = int.Parse(txt_MaCTPN.Text),
        //        MaSanPham = int.Parse(cbb_MaSP.Text),
        //        SoLuong =  int.Parse(txt_Soluong.Text),
        //        TienNhap = int.Parse(txt_TienNhap.Text),
        //    };

        //    if (bllpn.postCTPN(cthdsp))
        //    {
        //        MessageBox.Show("Thêm thành công");
        //        dgv_ChiTietPhieuNhap.DataSource = bllpn.LoadCTPN();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm thất bại");
        //    }
        //}

        //private void btn_XoaCTPN_Click(object sender, EventArgs e)
        //{
        //    if (bllpn.deleteCTPN(int.Parse(txt_MaCTPN.Text)))
        //    {
        //        MessageBox.Show("Xóa thành công");
        //        dgv_ChiTietPhieuNhap.DataSource = bllpn.LoadCTPN();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Xóa thất bại");
        //        return;
        //    }
        //}



        public void loaddata(BindingList<ThemSanPham> loadsp)
        {
            dgv_Chitiethoadon.DataSource = loadsp;
            dgv_Chitiethoadon.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
            //dgv_Chitiethoadon.Columns[0].ReadOnly = true;
            //dgv_Chitiethoadon.Columns[1].ReadOnly = true;
            //dgv_Chitiethoadon.Columns[2].ReadOnly = true;
            //dgv_Chitiethoadon.Columns[3].ReadOnly = true;
            //dgv_Chitiethoadon.Columns[5].ReadOnly = true;
            //dgv_Chitiethoadon.Columns[6].ReadOnly = true;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form fsf = Application.OpenForms["frmQuanLySP"];

            if (fsf != null)
            {
                //return;
                fsf.Close();
            }
            else
            {
                frmQuanLySP frm = new frmQuanLySP();
                frm.Show();
                frm.TopMost = true;
                frm.btn_nhapvao.Visible = true;
                frm.txt_GiaBan.Enabled = false;
                frm.txt_HangSX.Enabled = false;
                frm.txt_Image.Enabled = false;
                frm.txt_LoaiSP.Enabled = false;
                frm.txt_MaSP.Enabled = false;
                frm.txt_TenSP.Enabled = false;
                frm.txt_TonKho.Enabled = false;
                frm.txtHSD.Enabled = false;
                frm.btn_Sua.Visible = false;
                frm.btn_Them.Visible = false;
                frm.btn_Xoa.Visible = false;
                frm.btn.Enabled = false;
            }
        }

        private void dgv_Chitiethoadon_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgv_PhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_PhieuNhap.Rows[e.RowIndex];
                txt_MaPhieuNhap.Text = row.Cells[0].Value.ToString();
                cbb_npp.Text = row.Cells[2].Value.ToString();
                txt_MaNhanVien.Text = row.Cells[1].Value.ToString();
                txt_TongTien.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = dgv_PhieuNhap.Rows[e.RowIndex].Cells[4].Value.ToString();

                dgv_ChiTietPhieuNhap.DataSource = bllpn.LoadCTPhieuNhap(int.Parse(row.Cells[0].Value.ToString()));
                dgv_ChiTietPhieuNhap.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
            }

           
        }

        private void dgv_ChiTietPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_ChiTietPhieuNhap.Rows[e.RowIndex];
                txt_MaCTPN.Text = row.Cells[0].Value.ToString();
                cbb_MaSP.Text = row.Cells[1].Value.ToString();
                txt_Soluong.Text = row.Cells[2].Value.ToString();
                txt_TienNhap.Text = row.Cells[3].Value.ToString();
                //txt_maddh.Text = row.Cells[4].Value.ToString();
            

                //dgv_ChiTietPhieuNhap.DataSource = bllpn.LoadCTPhieuNhap(int.Parse(row.Cells[0].Value.ToString()));

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmQuanLySP.lstnhap.RemoveAt(dgv_Chitiethoadon.CurrentCell.RowIndex);
            guna2Button1.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmNhapTheoDonDatHang frm1 = new frmNhapTheoDonDatHang();
            frm1.Show();
        }
        public static string tennv;
        public static int mapn;
        public static int npp;
        public static int tongtien;
        
        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            if (dgv_ChiTietPhieuNhap.Rows.Count == 0)
            {
                MessageBox.Show("khong co du lieu de xuat");
                return;
            }
            npp = int.Parse(cbb_npp.Text);

            tennv = blldn.loadtentheoma(txt_MaNhanVien.Text);

            dataExcel.DataSource = bllpn.LoadBieuMauNhapHang(int.Parse(txt_MaPhieuNhap.Text));
            
            mapn = int.Parse(dgv_ChiTietPhieuNhap.CurrentRow.Cells[0].Value.ToString());

            ExcelExportPN ex = new ExcelExportPN();
           
            int a = 0;
            for (int x = 0; x < dataExcel.Rows.Count; x++)
            {
                tongtien += int.Parse(dataExcel.Rows[a].Cells[2].Value.ToString()) * int.Parse(dataExcel.Rows[a].Cells[3].Value.ToString());
                a++;
            }
            List<View_BieuMauNhapHang> pListKhoa = new List<View_BieuMauNhapHang>();

            foreach (DataGridViewRow item in dataExcel.Rows)
            {
                View_BieuMauNhapHang i = new View_BieuMauNhapHang();
                i.MaPhieuNhap = int.Parse(item.Cells[0].Value.ToString());
                i.MaSanPham = int.Parse(item.Cells[1].Value.ToString());
                i.SoLuong = int.Parse(item.Cells[2].Value.ToString());
                i.TienNhap = int.Parse(item.Cells[3].Value.ToString());
                i.NgayNhap = DateTime.Parse(item.Cells[4].Value.ToString());
                //i.TongTien = int.Parse(item.Cells[5].Value.ToString());

                pListKhoa.Add(i);
            }


            string path = string.Empty;

            ex.ExportKhoa(pListKhoa, ref path, false);

            DialogResult r = MessageBox.Show("ban co muon mo file khong", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (!string.IsNullOrEmpty(path) && r == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }

            btn_Xuat.Enabled = false;
            toolStripButton1.Enabled = false;
        }

        private void btn_LoadLai_Click(object sender, EventArgs e)
        {
            //dgv_PhieuNhap.Refresh();
            dgv_PhieuNhap.DataSource = bllpn.LoadPhieuNhapNV(int.Parse(frmTrangChuNhanVien.manv));

        }

   

    }
}
