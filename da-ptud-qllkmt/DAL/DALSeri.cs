using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Reflection;
namespace DAL
{
    public class DALSeri
    {
        private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALSeri() { }
        
        public List<SeriHD> loadsr(int mahd)
        {
            return qllk.SeriHDs.Where(t=>t.MaHoaDon == mahd).Select(t => t).ToList();
        }
        public string loadseritheomasp(int ma)
        {
            var load = qllk.SeriSPs.Where(t => t.MaSanPham == ma && t.TinhTrang == false).Select(t => t.Seri).FirstOrDefault();
            return load;
        }
        public bool them(SeriHD kh)
        {
            try
            {
                SeriHD khs = new SeriHD();
                khs.Seri = kh.Seri;
                khs.MaHoaDon = kh.MaHoaDon;

                qllk.SeriHDs.InsertOnSubmit(kh);
                qllk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public SeriSP LayThongTinSeriSP(string maSeri)
        {
            return qllk.SeriSPs.First(t => t.Seri == maSeri);
        }
    }
}
