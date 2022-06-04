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
        public BLLBaoHanh() { }

        public List<View_CTHDSP> getlist(int ma)
        {
            return dalbh.getlistcthd(ma);
        }
        public List<HoaDon> getmahd()
        {
            return dalbh.getmahd();
        }
        public List<View_BaoHanh> getmabh()
        {
            return dalbh.GetWatchListBH();
        }
        public List<View_BaoHanhCT> getctbh(int ma)
        {
            return dalbh.GetWatchListCT(ma);
        }
        public string getten(int ma)
        {
            return dalbh.gettensp(ma);
        }
        public int laodmacuoicung()
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
