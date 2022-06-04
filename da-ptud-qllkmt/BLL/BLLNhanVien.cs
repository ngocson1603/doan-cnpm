using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLNhanVien
    {

        DALNhanVien dalnhanvien = new DALNhanVien();

        public BLLNhanVien()
        {

        }

        public List<View_NhanVien> loaddanhsachNhanVien()
        {
            return dalnhanvien.GetDanhSachNhanVien();
        }

        public bool ThemNV(QuanLyNhanVien kh)
        {
            return dalnhanvien.PostNhanVien(kh);
        }
        public bool deleteNV(int ma)
        {
            return dalnhanvien.DeleteNhanVien(ma);
        }
        public bool suaNV(QuanLyNhanVien kh, int ten)
        {
            return dalnhanvien.PutNhanVien(kh, ten);
        }

        public bool kiemtratontai(int manv)
        {
            return dalnhanvien.Kiemtratontai(manv);
        }
    }
}
