using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DTO;

namespace DAL
{
    public class DALDangKy
    {
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALDangKy()
        {

        }

        //public List<KhachHang> loadThongTin(string user)
        //{
        //    return qllk.KhachHangs.Where(t => t.Gmail.Equals(user)).Select(t => t).ToList();
        //}

        private ApiService _apiService = new ApiService();

        public List<KhachHang> GetWatchInfoKH(int ma)
        {
            var response = _apiService.GetResponse(string.Format("api/KhachHang/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<KhachHang>>().Result;
            }
            return null;
        }


        //public List<KhachHang> GetWatchInfoKH()
        //{
        //    var response = _apiService.GetResponse(string.Format("api/KhachHang/"));
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return response.Content.ReadAsAsync<List<KhachHang>>().Result;
        //    }
        //    return null;
        //}


        public bool PutKhachHang(KhachHang pKH, int ten)
        {
            var response = _apiService.PutResponse(string.Format("api/KhachHang/{0}", ten), pKH);
            if (response == null)
                return false;
            else
                return true;
        }

        public bool PostDangKy(KhachHang pKH)
        {
            var response = _apiService.PostResponse("api/KhachHang/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }

        public bool Kiemtratontai(string gmail)
        {
            return qllk.KhachHangs.Where(t => t.Gmail == gmail).FirstOrDefault() != null;
        }
    }
}
