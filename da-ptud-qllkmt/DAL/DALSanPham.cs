using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALSanPham
    {
        private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();

        public DALSanPham()
        {

        }

        public List<SanPham>LoadSanPham()
        {
            return qllk.SanPhams.Select(t => t).ToList<SanPham>();

        }

        public List<View_SanPham> GetWatchListSanPham()
        {
            var response = _apiService.GetResponse("api/SanPham/");
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_SanPham>>().Result;
            }
            return null;
        }






        public bool PostSanPham(QuanLySanPham pCT)
        {
            var response = _apiService.PostResponse("api/SanPham/", pCT);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool DeleteSanPham(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/SanPham/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }
        public bool PutSanPham(QuanLySanPham pKH, int ten)
        {
            var response = _apiService.PutResponse(string.Format("api/SanPham/{0}", ten), pKH);
            if (response == null)
                return false;
            else
                return true;
        }



    }
}
