using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public class BLLDonDatHang
    {
       DALDonDatHang dalDonDatHang = new DALDonDatHang();

       public BLLDonDatHang() { }


       public List<DonDatHang> GetDLDonDatHang()
       {
           return dalDonDatHang.GetDLDonDatHang();
       }

       public DonDatHang GetThongTinDonDatHang(int maDDH)
       {
           return dalDonDatHang.GetThongTinDonDatHang(maDDH);
       }

       public bool ThemDonDatHang(DonDatHang ddh)
       {
           return dalDonDatHang.ThemDonDatHang(ddh);
       }

       public int GetLastDonDatHang()
       {
           return dalDonDatHang.GetLastDonDatHang();
       }
    }
}
