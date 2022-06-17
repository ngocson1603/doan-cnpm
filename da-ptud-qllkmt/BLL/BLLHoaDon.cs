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

        public List<View_CTHD> LoadHoaDon()
        {
            return dalhoadon.GetDanhSachHD();
        }
        public int Loadmakhongluu()
        {
            return dalhoadon.loadmakhongluu();
        }
        public int loadmacuoi(int ma)
        {
            return dalhoadon.loadMaCuoiCung(ma);
        }
        public int loadmacuoionl()
        {
            return dalhoadon.loadmacuoionl();
        }
        public bool KTTontai(int ma)
        {
            return dalhoadon.KTTonTai(ma);
        }
        public List<DH> DHOnl()
        {
            return dalhoadon.DonMuaOnl();
        }
        public List<CTDDH> CTDHOnl(int ma)
        {
            return dalhoadon.CTDonMuaOnl(ma);
        }
        public List<View_CTHD> LoadHoaDonNV(int ma)
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

        public HoaDon GetThongTinHoaDon(int maHD)
        {
            return dalhoadon.GetThongTinHoaDon(maHD);
        }

        //xoa dh
        public bool xoaDH(int ma)
        {
            return dalhoadon.xoaDH(ma);
        }
        public bool xoaCTDH(int ma)
        {
            return dalhoadon.xoaCTDH(ma);
        }
    }
}
