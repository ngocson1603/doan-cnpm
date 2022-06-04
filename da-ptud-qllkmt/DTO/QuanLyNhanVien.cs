using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLyNhanVien
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh{ get; set; }
        public DateTime NgayVaoLam { get; set; }
        public int ChucVu { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }

    }
}
