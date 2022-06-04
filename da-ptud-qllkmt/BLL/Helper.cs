using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Helper
    {
        public Helper()
        {

        }
        public string Directory()
        {
            string curdirect = Environment.CurrentDirectory;
            string direct = curdirect.Substring(0, curdirect.Length - 9) + "Images/";
            return direct;
        }

        public Form currentchildform;
        public void motrangcon(Form trangcon, Panel pnl)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();

            }
            currentchildform = trangcon;
            trangcon.TopLevel = false;
            trangcon.FormBorderStyle = FormBorderStyle.None;
            trangcon.Dock = DockStyle.Fill;
            pnl.Controls.Add(trangcon);
            pnl.Tag = trangcon;
            trangcon.BringToFront();
            trangcon.Show();
        }
    }
}
