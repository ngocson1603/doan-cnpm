using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLDangNhap
    {
        DALDangNhap daldangnhap = new DALDangNhap();
        public BLLDangNhap()
        {
        }

        public bool kiemtrakh(string gmail,string pass)
        {
            return daldangnhap.Kiemtradangnhapkhachhang(gmail,pass);
        }
        public bool kiemtranv(string gmail, string pass)
        {
            return daldangnhap.Kiemtradangnhapnhanvien(gmail, pass);
        }

        public string loadmanv(string gmail)
        {
            return daldangnhap.loadmanv(gmail);
        }

        public string loadtentheoma(string ma)
        {
            return daldangnhap.loadtentheoma(ma);
        }
        public string loadtentheomakh(string ma)
        {
            return daldangnhap.loadtentheomakh(ma);
        }
    }
}
