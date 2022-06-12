using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DTO;

namespace DAL
{
    public class DALPhieuNhap
    {
        private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALPhieuNhap()
        {

        }
        public List<View_PhieuNhap> GetDanhSachPN()
        {
            var response = _apiService.GetResponse(string.Format("api/PhieuNhap/"));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_PhieuNhap>>().Result;
            }
            return null;
        }
        public bool PostPN(ThemPhieuNhap pKH)
        {
            var response = _apiService.PostResponse("api/PhieuNhap/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool PutPN(ThemPhieuNhap pKH, int ten)
        {
            var response = _apiService.PutResponse(string.Format("api/PhieuNhap/{0}", ten), pKH);
            if (response == null)
                return false;
            else
                return true;
        }

        public bool DeletePN(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/PhieuNhap/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }
        public List<View_CTPhieuNhap> GetDanhSachCTPN()
        {
            var response = _apiService.GetResponse(string.Format("api/CTPN/"));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_CTPhieuNhap>>().Result;
            }
            return null;
        }


        //ctpn nhan vien
        public bool PostCTPN(ThemCTPN pKH)
        {
            var response = _apiService.PostResponse("api/CTPN/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }

        public bool DeleteCTPN(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/CTPN/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }



        public List<View_PhieuNhap> GetWatchListPNNV(int ma)
        {
            var response = _apiService.GetResponse(string.Format("api/PhieuNhap/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_PhieuNhap>>().Result;
            }
            return null;
        }

        public List<View_CTPhieuNhap> GetWatchListCTPNNV(int ma)
        {
            var response = _apiService.GetResponse(string.Format("api/CTPN/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_CTPhieuNhap>>().Result;
            }
            return null;
        }

        public List<View_PhieuNhap> GetWatchListPhieuNhapNV(int ma)
        {
            var response = _apiService.GetResponse(string.Format("api/LoadPNNV/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_PhieuNhap>>().Result;
            }
            return null;
        }

        public int GetLastPhieuNhap()
        {
            return qllk.PhieuNhaps.OrderByDescending(t => t.MaPhieuNhap).First().MaPhieuNhap;
        }




        public List<View_BieuMauNhapHang> LoadBieuMauNhap(int ma)
        {
            return qllk.View_BieuMauNhapHangs.Where(t=>t.MaPhieuNhap==ma).Select(t => t).ToList<View_BieuMauNhapHang>();
        }
    }
}
