using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALGioHang
    {
        private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALGioHang()
        {

        }

        //public List<View_BieuMauGio> loadBieuMauGio(string tenkh)
        //{
        //    return qllk.View_BieuMauGios.Where(t => t.Gmail.Equals(tenkh)).Select(t => t).ToList();
        //}

        public List<View_GioHang> GetWatchListGioHang(string ma)
        {
            var response = _apiService.GetResponse(string.Format("api/HoaDon/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_GioHang>>().Result;
            }
            return null;
        }

        public List<View_BieuMauGio> GetWatchListBieuMauGioHang(int ma,int mahd)
        {
            var response = _apiService.GetResponse(string.Format("api/BieuMauGio/{0}/{1}", ma,mahd));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_BieuMauGio>>().Result;
            }
            return null;
        }

        public List<View_CTHD> GetWatchListGioHangSP()
        {
            var response = _apiService.GetResponse("api/GioHang/");
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_CTHD>>().Result;
            }
            return null;
        }


        // LOAD CHI TIET HOA DON 
        public List<View_CTHDSP> GetWatchListCTHDSP(int ma)
        {
            var response = _apiService.GetResponse(string.Format("api/ChiTietHoaDonSP/{0}", ma));

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_CTHDSP>>().Result;
            }
            return null;
        }

        public string loadTenSP(int masp)
        {
            var tensp = (from lk in qllk.SanPhams where lk.MaSanPham == masp select lk.TenSanPham).FirstOrDefault();
            return tensp.ToString();
        }
        public string loadGiaSP(int masp)
        {
            var tensp = from lk in qllk.SanPhams where lk.MaSanPham == masp select lk.GiaBan;
            return tensp.ToString();
        }
        public int loadMaCuoiCung()
        {
            return qllk.HoaDons.OrderByDescending(t => t.MaHoaDon).First().MaHoaDon;
        }
        public int loadMaCuoiCungTheoNV(int manv)
        {
            //var mahd = (from p in qllk.HoaDons where p.MaNhanVien == manv && p.NgayLapHoaDon == ngaylap select p.MaHoaDon).FirstOrDefault();
            //return mahd;

            return qllk.HoaDons.OrderByDescending(t => t.MaHoaDon).Where(t=>t.MaNhanVien == manv).First().MaHoaDon;
        }
        public List<View_SanPham> loadTenSanPham()
        {
            return qllk.View_SanPhams.Select(t=>t).ToList();
        }
        public string loadMaKH(string taik)
        {
            var makh = (from p in qllk.KhachHangs where p.Gmail == taik select p.MaKH).FirstOrDefault();
            return makh.ToString();
        }
        
        public bool PostGioHang(ThemGioHang pCT)
        {
            var response = _apiService.PostResponse("api/GioHang/", pCT);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool PostChiTietHD(ThemCTHD pCT)
        {
            var response = _apiService.PostResponse("api/ChiTietHoaDonSP/", pCT);
            if (response == null)
                return false;
            else
                return true;
        }


        public bool DeleteGio(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/GioHang/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }

        public bool DeleteCTHD(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/ChiTietHoaDonSP/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }

        public bool PutCTHD(ThemCTHD pKH, int ten)
        {
            var response = _apiService.PutResponse(string.Format("api/ChiTietHoaDonSP/{0}", ten), pKH);
            if (response == null)
                return false;
            else
                return true;
        }


        public bool themGioHang(ChiTietHoaDon cthd)
        {
            try
            {
                qllk.ChiTietHoaDons.InsertOnSubmit(cthd);
                qllk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //public bool xoaGioHang(int ma)
        //{
        //    ChiTietHoaDon cthd = qllk.ChiTietHoaDons.Where(t => t.MaHoaDon == ma).FirstOrDefault();
        //    try
        //    {
        //        qllk.ChiTietHoaDons.DeleteOnSubmit(cthd);
        //        qllk.SubmitChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

       

        
    }
}
