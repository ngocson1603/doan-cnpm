using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALBaoHanh
    {
        private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALBaoHanh()
        {

        }

        public List<View_CTHDSP> getlistcthd(int ma)
        {
            return qllk.View_CTHDSPs.Where(t => t.MaHoaDon == ma).Select(t => t).ToList();
        }

        public List<HoaDon> getmahd()
        {
            return qllk.HoaDons.Select(t => t).ToList();
        }
        public string gettensp(int ma)
        {
            return qllk.SanPhams.Where(t => t.MaSanPham == ma).Select(t => t.TenSanPham).FirstOrDefault();
        }
        public int loadMaCuoiCung()
        {
            return qllk.BaoHanhs.OrderByDescending(t => t.MaBH).First().MaBH;
        }
        public string getngayhd(int ma)
        {
            var ngay = (from lk in qllk.HoaDons where lk.MaHoaDon == ma select lk.NgayLapHoaDon).FirstOrDefault();
            return ngay.ToString();
        }
        public string gethsd(int ma)
        {
            var hsd = (from lk in qllk.SanPhams where lk.MaSanPham == ma select lk.HSD).FirstOrDefault();
            return hsd.ToString();
        }
        //bao hanh
        public List<View_BaoHanh> GetWatchListBH()
        {
            var response = _apiService.GetResponse("api/BaoHanh/");
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_BaoHanh>>().Result;
            }
            return null;
        }
        public bool PostBH(ThemBaoHanh pKH)
        {
            var response = _apiService.PostResponse("api/BaoHanh/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool DeleteBH(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/BaoHanh/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }
        //chi tiet bao hanh
        public List<View_BaoHanhCT> GetWatchListCT(int ma)
        {
            var response = _apiService.GetResponse(string.Format("api/BaoHanhCT/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_BaoHanhCT>>().Result;
            }
            return null;
        }
        public bool PostBHCT(ThemCTBH pKH)
        {
            var response = _apiService.PostResponse("api/BaoHanhCT/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool DeleteBHCT(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/BaoHanhCT/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }
    }
}
