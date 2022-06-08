using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
   public  class DALDonDatHang
    {
       QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();

       public DALDonDatHang() { }

       public List<DonDatHang> GetDLDonDatHang()
       {
           return qllk.DonDatHangs.Select(t => t).ToList();
       }



       public bool ThemDonDatHang(DonDatHang ddh)
       {
           try
           {
               qllk.DonDatHangs.InsertOnSubmit(ddh);
               qllk.SubmitChanges();
               return true;
           }
           catch (Exception)
           {

               return false;
           }
       }

       public int GetLastDonDatHang()
       {
           return qllk.DonDatHangs.OrderByDescending(t => t.MaDDH).First().MaDDH;
       }
    }
}
