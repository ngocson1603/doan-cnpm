using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DTO;

namespace DAL
{
    public class DALKhachHang
    {
        private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALKhachHang()
        {

        }
        public List<KhachHang> loadmakh()
        {
            return qllk.KhachHangs.Select(t => t).ToList();
        }
        
        public List<KhachHang> LoadKhachHang()
        {
            return qllk.KhachHangs.Select(t => t).ToList<KhachHang>();
        }
        public int loadmakhtheotk(string taik)
        {
            var makh = (from p in qllk.KhachHangs where p.Gmail == taik select p.MaKH).FirstOrDefault();
            return makh;
        }
        public List<KhachHang> GetDanhSachKhachHang()
        {
            var response = _apiService.GetResponse(string.Format("api/KhachHang/"));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<KhachHang>>().Result;
            }
            return null;
        }
        public bool PostKhachHang(KhachHang pKH)
        {
            var response = _apiService.PostResponse("api/KhachHang/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool PutKhachHang(KhachHang pKH, int ten)
        {
            var response = _apiService.PutResponse(string.Format("api/KhachHang/{0}", ten), pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool DeleteKhachHang(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/KhachHang/{0}", ma));
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
