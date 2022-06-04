using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DTO;

namespace DAL
{
    public class DALNPP
    {
        private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALNPP() { }
        public List<NhaPhanPhoi> GetDanhSachnpp()
        {
            var response = _apiService.GetResponse(string.Format("api/NPP/"));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<NhaPhanPhoi>>().Result;
            }
            return null;
        }
        public bool Postnpp(NhaPhanPhoi pKH)
        {
            var response = _apiService.PostResponse("api/NPP/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool Putnpp(NhaPhanPhoi pKH, int ten)
        {
            var response = _apiService.PutResponse(string.Format("api/NPP/{0}", ten), pKH);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool Deletenpp(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/NPP/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }

    }
}
