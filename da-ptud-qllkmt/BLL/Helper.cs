using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Helper
    {
        public Helper()
        {

        }
        public bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        public bool kiemtraSDT(string inputSDT)
        {
            try
            {

                return Regex.Match(inputSDT,
                    @"^([\+]?61[-]?|[0])?[1-9][0-9]{8}$").Success;

            }
            catch
            {
                return false;
            }
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
