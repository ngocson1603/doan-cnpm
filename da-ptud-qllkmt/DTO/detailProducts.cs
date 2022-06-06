﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class detailProducts
    {
        public string TenSP { get; set; }

        public string TenLoai { get; set; }

        public string TenHang { get; set; }

        public int GiaBan { get; set; }

        public int TonKho { get; set; }
        public int HSD { get; set; }

        public string Hinh { get; set; }

        public int MaSP { get; set; }

        public detailProducts()
        {
            TenSP = TenSP;
            TenLoai = TenLoai;
            TenHang = TenHang;
            GiaBan = GiaBan;
            TonKho = TonKho;
            HSD = HSD;
            Hinh = Hinh;
            MaSP = MaSP;
        }

        public detailProducts(string tensp,string tenloai,string tenhang,int giaban,int tonkho,int hsd,string hinh,int ma)
        {
            TenSP = tensp;
            TenLoai = tenloai;
            TenHang = tenhang;
            GiaBan = giaban;
            TonKho = tonkho;
            HSD = hsd;
            Hinh = hinh;
            MaSP = ma;
        }
    }
}
