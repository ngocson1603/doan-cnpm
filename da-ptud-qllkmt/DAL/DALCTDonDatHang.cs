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
 
        public bool ThemCTDonDatHang(CTDonDatHang ctddh)
        {
            try
            {
                qllk.CTDonDatHangs.InsertOnSubmit(ctddh);
                qllk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

                throw;
            }
        }
    }
}
