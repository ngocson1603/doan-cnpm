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
    public partial class frmLSPHSX : Form
    {
        BLLLSPHSX blllsp = new BLLLSPHSX();
        public frmLSPHSX()
        {
            InitializeComponent();
        }

        private void frmLSPHSX_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = blllsp.loadlsp();
            dataGridView2.DataSource = blllsp.loadhsx();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                btnsualsp.Enabled = true;
                btnxoalsp.Enabled = true;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textBox4.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                btnsuahsx.Enabled = true;
                btnxoahsx.Enabled = true;
            }
        }

        private void btnThemlsp_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                LoaiSanPham kh = new LoaiSanPham()
                {
                    TenLoaiSanPham = textBox2.Text,
                };

                if (blllsp.Themlsp(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = blllsp.loadlsp();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
            }
        }

        private void btnxoalsp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không!", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                if (blllsp.deletelsp(int.Parse(textBox1.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridView1.DataSource = blllsp.loadlsp();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
                btnxoalsp.Enabled = true;
            }
        }

        private void btnsualsp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không!", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                if (textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    LoaiSanPham kh = new LoaiSanPham()
                    {
                        TenLoaiSanPham = textBox2.Text,
                    };

                    if (blllsp.sualsp(kh, int.Parse(textBox1.Text)))
                    {
                        MessageBox.Show("Sửa thành công");
                        dataGridView1.DataSource = blllsp.loadlsp();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                        return;
                    }
                }
                btnsualsp.Enabled = true;
            }
        }

        private void btnthemhsx_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                HangSanXuat kh = new HangSanXuat()
                {
                    TenHangSanXuat = textBox3.Text,
                };

                if (blllsp.Themhsx(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView2.DataSource = blllsp.loadhsx();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
            }
        }

        private void btnxoahsx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không!", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                if (blllsp.deletehsx(int.Parse(textBox3.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridView2.DataSource = blllsp.loadhsx();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
                btnxoahsx.Enabled = true;
            }
        }

        private void btnsuahsx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không!", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                if (textBox4.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    HangSanXuat kh = new HangSanXuat()
                    {
                        TenHangSanXuat = textBox2.Text,
                    };

                    if (blllsp.suahsx(kh, int.Parse(textBox3.Text)))
                    {
                        MessageBox.Show("Sửa thành công");
                        dataGridView2.DataSource = blllsp.loadhsx();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                        return;
                    }
                }
                btnsuahsx.Enabled = true;
            }
        }
    }
}
