using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLCTDonDatHang
    {   
            DALCTDonDatHang dalCTDonDatHang = new DALCTDonDatHang();
            public BLLCTDonDatHang() { }
            public List<CTDonDatHang> GetCTDonDatHang()
            {
                return dalCTDonDatHang.GetCTDonDatHang();
            }

            public List<CTDonDatHang> GetDLCTDonDatHangTheoMa(int maddh)
            {
                return dalCTDonDatHang.GetDLCTDonDatHangTheoMa(maddh);
            }
            public int ThemCTDonDatHang(CTDonDatHang ctddh)
            {
                return dalCTDonDatHang.ThemCTDonDatHang(ctddh);
            }

    }
}
