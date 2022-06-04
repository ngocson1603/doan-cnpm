using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DTO;


namespace DAL
{
    public class DALNhanVien
    {
         private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALNhanVien()
        {

        }


        public List<NhanVien> LoadNhanVien()
        {
            return qllk.NhanViens.Select(t => t).ToList<NhanVien>();
        }



        public List<View_NhanVien> GetDanhSachNhanVien()
        {
            var response = _apiService.GetResponse(string.Format("api/NhanVien/"));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_NhanVien>>().Result;
            }
            return null;
        }
        public bool PostNhanVien(QuanLyNhanVien pKH)
        {
            var response = _apiService.PostResponse("api/NhanVien/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool PutNhanVien(QuanLyNhanVien pKH, int ten)
        {
            var response = _apiService.PutResponse(string.Format("api/NhanVien/{0}", ten), pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool DeleteNhanVien(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/NhanVien/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }

       

        public bool Kiemtratontai(int manv)
        {
            return qllk.NhanViens.Where(t => t.MaNhanVien == manv).FirstOrDefault() != null;
        }
    }
}
