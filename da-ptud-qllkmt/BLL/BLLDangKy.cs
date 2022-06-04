using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLDangKy
    {
        DALDangKy daldangky = new DALDangKy();
        public BLLDangKy() { }

        //public List<KhachHang> loadThongTin(string user)
        //{
        //    return daldangky.loadThongTin(user);
        //}

        public List<KhachHang> loadKhachHangAPI(int tenkh)
        {
            return daldangky.GetWatchInfoKH(tenkh);
        }

        public bool suaKhachHang(KhachHang kh,int ten)
        {
            return daldangky.PutKhachHang(kh,ten);
        }
        public bool kiemtratontai(string gmail)
        {
            return daldangky.Kiemtratontai(gmail);
        }
        public bool themKhachHang(KhachHang kh)
        {
            return daldangky.PostDangKy(kh);
        }
    }
}
