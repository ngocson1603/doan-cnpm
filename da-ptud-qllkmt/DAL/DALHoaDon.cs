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



        public List<View_HoaDon> GetDanhSachHD()
        {
            var response = _apiService.GetResponse(string.Format("api/HD/"));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_HoaDon>>().Result;
            }
            return null;
        }
        public List<View_HoaDon> GetWatchListHDNV(int ma)
        {
            var response = _apiService.GetResponse(string.Format("api/LoadHDNV/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_HoaDon>>().Result;
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

        
    }
}
