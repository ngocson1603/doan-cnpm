using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALTuVan
    {
        private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALTuVan() { }


        public List<TinhTrangOne> GetTT1()
        {
            var response = _apiService.GetResponse("api/TT1/");
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<TinhTrangOne>>().Result;
            }
            return null;
        }

        public List<View_TinhTrangTwo> GetTT2(string ma)
        {
            var response = _apiService.GetResponse(string.Format("api/TT2/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_TinhTrangTwo>>().Result;
            }
            return null;
        }

        public List<View_TinhTrangThree> GetTT3(string ma, string mahd)
        {
            var response = _apiService.GetResponse(string.Format("api/TT3/{0}/{1}", ma, mahd));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_TinhTrangThree>>().Result;
            }
            return null;
        }

        //public List<View_Anh> loadAnh(string kq)
        //{
        //    var response = _apiService.GetResponse(string.Format("api/Anh/{0}", kq));
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return response.Content.ReadAsAsync<List<View_Anh>>().Result;
        //    }
        //    return null;
        //}

        public string loadAnh(string kq)
        {
            var tensp = (from lk in qllk.View_Anhs where lk.KetQua == kq select lk.Anh).FirstOrDefault();
            return tensp.ToString();
        }
    }
}