﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLLSanPham
    {
        DALSanPham dalsanpham = new DALSanPham();

        public BLLSanPham()
        { 
        }

        public List<View_SanPham> LoadSanPham()
        {
            return dalsanpham.GetWatchListSanPham();
        }

        public List<SanPham> GetSLTheoDK()
        {
            return dalsanpham.GetSLTheoDK();
        }

        // them xoa sua

        public bool postSP(QuanLySanPham cthd)
        {
            return dalsanpham.PostSanPham(cthd);
        }
        public bool deleteSP(int ma)
        {
            return dalsanpham.DeleteSanPham(ma);
        }

        public bool putSP(QuanLySanPham cthd, int ma)
        {
            return dalsanpham.PutSanPham(cthd, ma);
        }
        

        public string LayTenSanPhamTheoMa(int maSP)
        {
            return dalsanpham.LayTenSanPhamTheoMa(maSP);
        }

        public SanPham LayThongTinSanPhamTheoMa(int maSP)
        {
            return dalsanpham.LayThongTinSanPhamTheoMa(maSP);
        }
    }
}
