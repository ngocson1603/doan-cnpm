using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLBaoHanh
    {
        DALBaoHanh dalbh = new DALBaoHanh();
        DALSanPham dalSP = new DALSanPham();

        public BLLBaoHanh() { }

        public List<View_CTHDSP> getlist(int ma, double soThangSuDung)
        {
            List<View_CTHDSP> lst = dalbh.getlistcthd(ma);
            List<View_CTHDSP> lstCC = new List<View_CTHDSP>();
            foreach (View_CTHDSP item in lst)
            {
                SanPham sp = dalSP.LayThongTinSanPhamTheoMa(item.MaSanPham);
                if ((double)sp.HSD < soThangSuDung)
                    continue;
                else
                    lstCC.Add(item);
            }

            return lstCC;
        }

        public List<HoaDon> getmahd()
        {
            return dalbh.getmahd();
        }
        public int? getMaTheoSeri(string ma)
        {
            return dalbh.loadMaSPTheoSoSeri(ma);
        }
        public List<View_BaoHanh> getmabh()
        {
            return dalbh.GetWatchListBH();
        }
        public List<View_BieuMauBH> getmabaohanh(int ma)
        {
            return dalbh.getbieumaubh(ma);
        }
        public List<View_BaoHanhCT> getctbh(int ma)
        {
            return dalbh.GetWatchListCT(ma);
        }
        public List<View_BieuMauBaoHanh> loadbieumau(int ma)
        {
            return dalbh.getbieumau(ma);
        }
        public string getten(int ma)
        {
            return dalbh.gettensp(ma);
        }
        public int loadmacuoicung()
        {
            return dalbh.loadMaCuoiCung();
        }
        public string getngay(int ma)
        {
            return dalbh.getngayhd(ma);
        }
        public string loadhsd(int ma)
        {
            return dalbh.gethsd(ma);
        }
        //bao hanh
        public bool thembh(ThemBaoHanh cthd)
        {
            return dalbh.PostBH(cthd);
        }
        public bool xoabh(int ma)
        {
            return dalbh.DeleteBH(ma);
        }
        //ct bao hanh
        public bool thembhct(ThemCTBH cthd)
        {
            return dalbh.PostBHCT(cthd);
        }
        public bool xoabhct(int ma)
        {
            return dalbh.DeleteBHCT(ma);
        }
    }
}
