using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALHoaDon
    {
        private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALHoaDon()
        {

        }

        public List<HoaDon> LoadHoaDon()
        {
            return qllk.HoaDons.Select(t => t).ToList<HoaDon>();
        }
        public List<DH> DonMuaOnl()
        {
            return qllk.DHs.Select(t => t).ToList();
        }
        public List<CTDDH> CTDonMuaOnl(int ma)
        {
            return qllk.CTDDHs.Where(t=>t.iddh == ma).Select(t => t).ToList();
        }
        public int loadmakhongluu()
        {
            var makh = (from p in qllk.KhachHangs where p.Gmail == null select p.MaKH).FirstOrDefault();
            return makh;
        }
        public int loadMaCuoiCung(int manv)
        {
            return qllk.HoaDons.OrderByDescending(t => t.MaHoaDon).Where(t=>t.MaNhanVien == manv).First().MaHoaDon;
        }
        public int loadmacuoionl()
        {
            return qllk.HoaDons.OrderByDescending(t => t.MaHoaDon).First().MaHoaDon;
        }
        public List<View_CTHD> GetDanhSachHD()
        {
            var response = _apiService.GetResponse(string.Format("api/HD/"));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_CTHD>>().Result;
            }
            return null;
        }
        public List<View_CTHD> GetWatchListHDNV(int ma)
        {
            var response = _apiService.GetResponse(string.Format("api/LoadHDNV/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_CTHD>>().Result;
            }
            return null;
        }
        public bool PostHD(QuanLyHoaDon pKH)
        {
            var response = _apiService.PostResponse("api/HD/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool PutHD(QuanLyHoaDon pKH, int ten)
        {
            var response = _apiService.PutResponse(string.Format("api/HD/{0}", ten), pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool DeleteHD(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/HD/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }

        public HoaDon GetThongTinHoaDon(int maHD)
        {
            return qllk.HoaDons.First(t => t.MaHoaDon == maHD);
        }
        public bool KTTonTai(int ma)
        {
            return qllk.HoaDons.Where(t => t.MaHoaDon == ma).FirstOrDefault() != null;
        }
        //xoa don
        public bool xoaDH(int ma)
        {
            try
            {
                var kh = qllk.DHs.Where(t => t.iddh == ma).FirstOrDefault();

                qllk.DHs.DeleteOnSubmit(kh);
                qllk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaCTDH(int ma)
        {
            try
            {
                var kh = qllk.CTDDHs.Where(t => t.iddh == ma).ToList();

                qllk.CTDDHs.DeleteAllOnSubmit(kh);
                qllk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
