using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLGioHang
    {
        DALGioHang dalgiohang = new DALGioHang();
        public BLLGioHang()
        {

        }
        public bool postGioHang(ThemGioHang cthd)
        {
            return dalgiohang.PostGioHang(cthd);
        }
        public bool deleteGioHang(int ma)
        {
            return dalgiohang.DeleteGio(ma);
        }
        public bool postGioHangCTHD(ThemCTHD cthd)
        {
            return dalgiohang.PostChiTietHD(cthd);
        }
        public bool deleteGioHangCTHD(int ma)
        {
            return dalgiohang.DeleteCTHD(ma);
        }
        public bool themGioHang(ChiTietHoaDon cthd)
        {
            return dalgiohang.themGioHang(cthd);
        }




        public bool SuaCTHD(ThemCTHD cthd, int ten)
        {
            return dalgiohang.PutCTHD(cthd,ten);
        }

        //public List<View_GioHang> loadGioHang(string tenkh)
        //{
        //    return dalgiohang.loadGioHang(tenkh);
        //}

        public List<View_CTHDSP> loadChiTietHoaDon(int ma)
        {
            return dalgiohang.GetWatchListCTHDSP(ma);
        }
        public List<View_SanPham> loadSanPham()
        {
            return dalgiohang.loadTenSanPham();
        }

        public List<View_GioHang> loadGioHangAPI(string tenkh)
        {
            return dalgiohang.GetWatchListGioHang(tenkh);
        }

        public List<View_CTHD> loadHDAPI()
        {
            return dalgiohang.GetWatchListGioHangSP();
        }

        public List<View_BieuMauGio> loadBieuMauGioHangAPI(int tenkh,int ma)
        {
            return dalgiohang.GetWatchListBieuMauGioHang(tenkh,ma);
        }

        public string loadTenSP(int masp)
        {
            return dalgiohang.loadTenSP(masp);
        }
        public string loadGiaSP(int masp)
        {
            return dalgiohang.loadGiaSP(masp);
        }
        public string loadMaKH(string taik)
        {
            return dalgiohang.loadMaKH(taik);
        }
        public int loadMaCuoiCung()
        {
            return dalgiohang.loadMaCuoiCung();
        }
        public int loadMaCuoiCungNV(int ma)
        {
            return dalgiohang.loadMaCuoiCungTheoNV(ma);
        }
    }
}
