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
    public partial class frmTuVanSuaChua : Form
    {
        BLLTuVan blltuvan = new BLLTuVan();
        ID3Learn id3 = new ID3Learn();
        public frmTuVanSuaChua()
        {
            InitializeComponent();
        }


        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            string kq = id3.load(cboTT1.SelectedValue.ToString(), cboTT2.SelectedValue.ToString(), cboTT3.SelectedValue.ToString());
            guna2TextBox1.Text = kq;
            string a = blltuvan.LoadAnh(kq);
            pictureBox1.Load("AnhLapTop\\" + a);
        }

        private void frmTuVanSuaChua_Load_1(object sender, EventArgs e)
        {
            cboTT1.DataSource = blltuvan.LoadTinhTrang1();
            cboTT1.DisplayMember = "TenTinhTrangOne";
            cboTT1.ValueMember = "TenTinhTrangOne";
            cboTT1.SelectedIndex = 0;
        }

        private void cboTT1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboTT2.DataSource = blltuvan.LoadTinhTrang2(cboTT1.SelectedValue.ToString());
            cboTT2.DisplayMember = "TenTinhTrangTwo";
            cboTT2.ValueMember = "TenTinhTrangTwo";
        }

        private void cboTT2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboTT3.DataSource = blltuvan.LoadTinhTrang3(cboTT1.SelectedValue.ToString(), cboTT2.SelectedValue.ToString());
            cboTT3.DisplayMember = "TenTinhTrangThree";
            cboTT3.ValueMember = "TenTinhTrangThree";

            if (cboTT3.Text.Length > 0)
            {
                guna2Button1.Enabled = true;
            }
        }
    }
}
