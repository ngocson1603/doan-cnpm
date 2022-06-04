using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALDangNhap
    {
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALDangNhap()
        {

        }
        public bool Kiemtradangnhapkhachhang(string gmail,string pass)
        {
            return qllk.KhachHangs.Where(t => t.Gmail == gmail && t.Pass == pass).FirstOrDefault() != null;
        }
        public bool Kiemtradangnhapnhanvien(string tendn, string pass)
        {
            return qllk.Users.Where(t => t.TenDangNhap == tendn && t.Password == pass).FirstOrDefault() != null;
        }
        public string loadmanv(string manv)
        {
            var manv1 = (from lk in qllk.Users where lk.TenDangNhap == manv select lk.MaNhanVien).FirstOrDefault();
            return manv1.ToString();
        }

        public string loadtentheoma(string manv)
        {
            var tennv = (from lk in qllk.NhanViens where lk.MaNhanVien == int.Parse(manv) select lk.TenNhanVien).FirstOrDefault();
            return tennv.ToString();
        }
        public string loadtentheomakh(string makh)
        {
            var tennv = (from lk in qllk.KhachHangs where lk.MaKH == int.Parse(makh) select lk.TenKhachHang).FirstOrDefault();
            return tennv.ToString();
        }
    }
}
