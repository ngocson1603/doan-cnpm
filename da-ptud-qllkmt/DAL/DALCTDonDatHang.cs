using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALCTDonDatHang
    {
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();

        public DALCTDonDatHang() { }

        public List<CTDonDatHang> GetCTDonDatHang()
        {
            return qllk.CTDonDatHangs.Select(t => t).ToList();
        }

        public List<CTDonDatHang> GetDLCTDonDatHangTheoMa(int maddh)
        {
            return qllk.CTDonDatHangs.Where(t => t.MaDDH == maddh).ToList();
        }
 
        public bool KiemTraTonTai(int maDDH, int maSP)
        {
            return qllk.CTDonDatHangs.Any(t => t.MaDDH == maDDH && t.MaSanPham == maSP);
        }

        public int ThemCTDonDatHang(CTDonDatHang ctddh)
        {
            try
            {
                if (KiemTraTonTai(ctddh.MaDDH, ctddh.MaSanPham))
                    return -1;
                qllk.CTDonDatHangs.InsertOnSubmit(ctddh);
                qllk.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
    }
}
