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
    public partial class frmNPP : Form
    {
        BLLNPP bllnpp = new BLLNPP();
        Helper hp = new Helper();
        public frmNPP()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtDchi.Text == string.Empty || txtEmail.Text == string.Empty || txtSdt.Text == string.Empty || txtTennpp.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            if (hp.isEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Gmail sai định dạng");
                return;
            }
            if (hp.kiemtraSDT(txtSdt.Text) == false)
            {
                MessageBox.Show("Sđt sai định dạng");
                return;
            }
            else
            {
                NhaPhanPhoi kh = new NhaPhanPhoi()
                {
                    TenNhaPhanPhoi = txtTennpp.Text,
                    DiaChi = txtDchi.Text,
                    SDT = txtSdt.Text,
                    Email = txtEmail.Text,
                };

                if (bllnpp.Themnpp(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = bllnpp.loadnpp();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
            }
        }

        private void frmNPP_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllnpp.loadnpp();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtManpp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTennpp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtDchi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtSdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không!", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                if (bllnpp.deletenpp(int.Parse(txtManpp.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridView1.DataSource = bllnpp.loadnpp();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
                toolStripButton2.Enabled = true;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không!", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                if (txtDchi.Text == string.Empty || txtEmail.Text == string.Empty || txtSdt.Text == string.Empty || txtTennpp.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                if (hp.isEmail(txtEmail.Text) == false)
                {
                    MessageBox.Show("Gmail sai định dạng");
                    return;
                }
                if (hp.kiemtraSDT(txtSdt.Text) == false)
                {
                    MessageBox.Show("Sđt sai định dạng");
                    return;
                }
                else
                {
                    NhaPhanPhoi kh = new NhaPhanPhoi()
                    {
                        TenNhaPhanPhoi = txtTennpp.Text,
                        DiaChi = txtDchi.Text,
                        SDT = txtSdt.Text,
                        Email = txtEmail.Text,
                    };

                    if (bllnpp.suanpp(kh, int.Parse(txtManpp.Text)))
                    {
                        MessageBox.Show("Sửa thành công");
                        dataGridView1.DataSource = bllnpp.loadnpp();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                        return;
                    }
                }
                toolStripButton3.Enabled = true;
            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
