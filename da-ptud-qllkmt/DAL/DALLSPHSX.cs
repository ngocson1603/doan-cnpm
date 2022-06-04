using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DTO;

namespace DAL
{
    public class DALLSPHSX
    {
        private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALLSPHSX() { }

        public string loadtenlsp(int ma)
        {
            var ngay = (from lk in qllk.LoaiSanPhams where lk.MaLoaiSanPham == ma select lk.TenLoaiSanPham).FirstOrDefault();
            return ngay.ToString();
        }

        public string loadtenhsx(int ma)
        {
            var ngay = (from lk in qllk.HangSanXuats where lk.MaHangSanXuat == ma select lk.TenHangSanXuat).FirstOrDefault();
            return ngay.ToString();
        }
        public List<LoaiSanPham> GetDanhSachlsp()
        {
            var response = _apiService.GetResponse(string.Format("api/LSP/"));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<LoaiSanPham>>().Result;
            }
            return null;
        }
        public bool Postlsp(LoaiSanPham pKH)
        {
            var response = _apiService.PostResponse("api/LSP/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool Putlsp(LoaiSanPham pKH, int ten)
        {
            var response = _apiService.PutResponse(string.Format("api/LSP/{0}", ten), pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool Deletelsp(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/LSP/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }

        //hang san xuat
        public List<HangSanXuat> GetDanhSachhsx()
        {
            var response = _apiService.GetResponse(string.Format("api/HSX/"));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<HangSanXuat>>().Result;
            }
            return null;
        }
        public bool Posthsx(HangSanXuat pKH)
        {
            var response = _apiService.PostResponse("api/HSX/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool Puthsx(HangSanXuat pKH, int ten)
        {
            var response = _apiService.PutResponse(string.Format("api/HSX/{0}", ten), pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool Deletehsx(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/LSP/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }
    }
}
