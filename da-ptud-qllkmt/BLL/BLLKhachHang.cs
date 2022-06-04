using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLLKhachHang
    {
        DALKhachHang dalkhachhang = new DALKhachHang();

        public BLLKhachHang()
        {

        }

        //public List<KhachHang> LoadDanhSachKhachHang()
        //{
        //    return dalkhachhang.LoadKhachHang();
        //}

        public List<KhachHang> loaddanhsachKhachHang()
        {
            return dalkhachhang.GetDanhSachKhachHang();
        }
        public List<KhachHang> loadmakh()
        {
            return dalkhachhang.loadmakh();
        }
        public bool ThemKH(KhachHang kh)
        {
            return dalkhachhang.PostKhachHang(kh);
        }
        public bool deleteKH(int ma)
        {
            return dalkhachhang.DeleteKhachHang(ma);
        }
        public bool suaKH(KhachHang kh, int ten)
        {
            return dalkhachhang.PutKhachHang(kh, ten);
        }

        public bool kiemtratontai(string gmail)
        {
            return dalkhachhang.Kiemtratontai(gmail);
        }

        public int loadmakh(string gmail)
        {
            return dalkhachhang.loadmakhtheotk(gmail);
        }

    }

}
