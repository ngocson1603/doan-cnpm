using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLHoaDon
    {
        DALHoaDon dalhoadon = new DALHoaDon();

        public BLLHoaDon()
        {

        }

        public List<View_HoaDon> LoadHoaDon()
        {
            return dalhoadon.GetDanhSachHD();
        }
        public List<View_HoaDon> LoadHoaDonNV(int ma)
        {
            return dalhoadon.GetWatchListHDNV(ma);
        }

        // them xoa sua

        public bool postHD(QuanLyHoaDon cthd)
        {
            return dalhoadon.PostHD(cthd);
        }
        public bool deleteHD(int ma)
        {
            return dalhoadon.DeleteHD(ma);
        }

        public bool putHD(QuanLyHoaDon cthd, int ma)
        {
            return dalhoadon.PutHD(cthd, ma);
        }
    }

}
