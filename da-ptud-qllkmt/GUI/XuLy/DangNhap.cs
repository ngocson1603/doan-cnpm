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
            string sql = "select count(*) from NhanVien,Users,ChucVu where NhanVien.ChucVu = ChucVu.MaChucVu and Users.MaNhanVien = NhanVien.MaNhanVien and TenDangNhap='"+ten+"'and Password = '" + pass + "' and Quyen = 1 and MaChucVu = 1 "; //ban hang
            string sql1 = "select count(*) from NhanVien,Users,ChucVu where NhanVien.ChucVu = ChucVu.MaChucVu and Users.MaNhanVien = NhanVien.MaNhanVien and TenDangNhap='" + ten + "'and Password = '" + pass + "' and Quyen = 1 and MaChucVu = 2 "; // nhap hang
            string sql2 = "select count(*) from NhanVien,Users,ChucVu where NhanVien.ChucVu = ChucVu.MaChucVu and Users.MaNhanVien = NhanVien.MaNhanVien and TenDangNhap='" + ten + "'and Password = '" + pass + "' and Quyen = 1 and MaChucVu = 3 "; // bao hanh
            string sql5 = "select count(*) from NhanVien,Users,ChucVu where NhanVien.ChucVu = ChucVu.MaChucVu and Users.MaNhanVien = NhanVien.MaNhanVien and TenDangNhap='" + ten + "'and Password = '" + pass + "' and Quyen = 1 and MaChucVu = 4 "; // admin
            string sql3 = "select count(*) from NhanVien,Users,ChucVu where NhanVien.ChucVu = ChucVu.MaChucVu and Users.MaNhanVien = NhanVien.MaNhanVien and TenDangNhap='" + ten + "'and Password = '" + pass + "' and Quyen = 0";//tai khoan bi khoa
            string sql4 = "select count(*) from KhachHang where Gmail = '" + ten + "'and Pass = '" + pass + "'";
            int kq = (int)kn.ExcuteScalar(sql);
            int kq1 = (int)kn.ExcuteScalar(sql1);
            int kq2 = (int)kn.ExcuteScalar(sql2);
            int kq3 = (int)kn.ExcuteScalar(sql3);
            int kq4 = (int)kn.ExcuteScalar(sql4);
            int kq5 = (int)kn.ExcuteScalar(sql5);
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
            else if (kq3 >= 1)
            {
                return 4;
            }
            else if (kq4 >= 1)
            {
                return 5;
            }
            else if (kq5 >= 1)
            {
                return 6;
            }
            else
            {
                return 7;
            }
        }
    }
}
