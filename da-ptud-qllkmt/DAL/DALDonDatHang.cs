using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALDonDatHang
    {
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        DALPhieuNhap dalPN = new DALPhieuNhap();

        public DALDonDatHang() { }

        public List<DonDatHang> GetDLDonDatHang()
        {
            List<View_PhieuNhap> lstPN = dalPN.GetDanhSachPN();
            return qllk.DonDatHangs.Where(t => !lstPN.Select(y => y.MaDDH).Contains(t.MaDDH)).ToList();
        }

        public DonDatHang GetThongTinDonDatHang(int maDDH)
        {
            return qllk.DonDatHangs.First(t => t.MaDDH == maDDH);
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
