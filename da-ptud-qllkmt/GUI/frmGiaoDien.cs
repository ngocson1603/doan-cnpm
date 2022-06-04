using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmGiaoDien : Form
    {
        public frmGiaoDien()
        {
            InitializeComponent();
        }
        int cpt = 1;

        private void frmGiaoDien_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(4);

            guna2DataGridView1.Rows[0].Cells[0].Value = Image.FromFile("AnhLapTop\\1.png");
            guna2DataGridView1.Rows[1].Cells[0].Value = Image.FromFile("AnhLapTop\\2.png");
            guna2DataGridView1.Rows[2].Cells[0].Value = Image.FromFile("AnhLapTop\\3.png");
            guna2DataGridView1.Rows[3].Cells[0].Value = Image.FromFile("AnhLapTop\\4.png");

            guna2DataGridView1.Rows[0].Cells[1].Value = "Laptop Đồ họa ConceptD 7 Ezel Pro";
            guna2DataGridView1.Rows[1].Cells[1].Value = "Laptop Asus Gaming ROG Strix G733ZX-LL016W";
            guna2DataGridView1.Rows[2].Cells[1].Value = "Laptop MSI Gaming GE76 Raider";
            guna2DataGridView1.Rows[3].Cells[1].Value = "Microsoft Surface Book 3";
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (cpt > 1)
            {
                cpt--;
                guna2PictureBox_laptop.Image = (Image)guna2DataGridView1.Rows[cpt - 1].Cells[0].Value;
                lblName.Text = guna2DataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                guna2PictureBox_laptop1.Load("AnhLapTop\\" + cpt.ToString() +cpt.ToString() + ".png");
                guna2PictureBox_laptop2.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox_laptop3.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString()+".png");
                guna2PictureBoxThongTin.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
            }
            else
            {
                cpt = 4;
                guna2PictureBox_laptop.Image = (Image)guna2DataGridView1.Rows[cpt - 1].Cells[0].Value;
                lblName.Text = guna2DataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                guna2PictureBox_laptop1.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox_laptop2.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox_laptop3.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBoxThongTin.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt < guna2DataGridView1.Rows.Count)
            {
                cpt++;
                guna2PictureBox_laptop.Image = (Image)guna2DataGridView1.Rows[cpt - 1].Cells[0].Value;
                lblName.Text = guna2DataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                guna2PictureBox_laptop1.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox_laptop2.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox_laptop3.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBoxThongTin.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
            }
            else 
            { 
                cpt = 1;
                guna2PictureBox_laptop.Image = (Image)guna2DataGridView1.Rows[cpt-1].Cells[0].Value;
                lblName.Text = guna2DataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                guna2PictureBox_laptop1.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox_laptop2.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox_laptop3.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBoxThongTin.Load("AnhLapTop\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
            }
        }

        private void guna2PictureBox_laptop1_Click(object sender, EventArgs e)
        {
            guna2PictureBox_laptop.Image = guna2PictureBox_laptop1.Image;
        }

        private void guna2PictureBox_laptop2_Click(object sender, EventArgs e)
        {
            guna2PictureBox_laptop.Image = guna2PictureBox_laptop2.Image;
        }

        private void guna2PictureBox_laptop3_Click(object sender, EventArgs e)
        {
            guna2PictureBox_laptop.Image = guna2PictureBox_laptop3.Image;
        }
    }
}
