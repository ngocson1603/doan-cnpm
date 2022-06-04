using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.XuLy
{
    public class DangNhap
    {
        loadProduct kn = new loadProduct();
        public DangNhap() 
        { 
        }
        public int dangNhap(string ten,string pass)
        {
            string sql = "select count(*) from Users where TenDangNhap = '" + ten + "'and Password = '" + pass + "' and Quyen = 1";
            string sql1 = "select count(*) from Users where TenDangNhap = '" + ten + "'and Password = '" + pass + "' and Quyen = 0";
            string sql2 = "select count(*) from KhachHang where Gmail = '" + ten + "'and Pass = '" + pass + "'";
            int kq = (int)kn.ExcuteScalar(sql);
            int kq1 = (int)kn.ExcuteScalar(sql1);
            int kq2 = (int)kn.ExcuteScalar(sql2);
            if (kq >= 1)
            {
                return 1;
            }
            else if (kq1 >= 1)
            {
                return 2;
            }
            else if (kq2 >= 1)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}
