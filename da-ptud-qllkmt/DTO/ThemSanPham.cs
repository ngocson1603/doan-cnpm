using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThemSanPham
    {
        public string tensp { get; set; }
        public string loai { get; set; }
        public string hang { get; set; }
        public string gia { get; set; }
        public int soluong { get; set; }
        public string anh { get; set; }
        public string ma { get; set; }

        public ThemSanPham(string tensp, string loai, string hang, string gia, int soluong, string anh, string ma)
        {
            this.tensp = tensp;
            this.loai = loai;
            this.hang = hang;
            this.soluong = soluong;
            this.gia = gia;
            this.anh = anh;
            this.ma = ma;
        }

        public ThemSanPham(string tensp, string loai, string hang, string gia, string anh, string ma)
        {
            this.tensp = tensp;
            this.loai = loai;
            this.hang = hang;
            
            this.gia = gia;
            this.anh = anh;
            this.ma = ma;
        }

        public ThemSanPham(string tensp,int soluong,string anh,string ma)
        {
            this.tensp = tensp;
            this.soluong = soluong;
            this.anh = anh;
            this.ma = ma;
        }

        public ThemSanPham(int ma)
        {
            this.soluong = ma;
        }
    }
}
