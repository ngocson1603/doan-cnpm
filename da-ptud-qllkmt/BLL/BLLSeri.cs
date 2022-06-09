using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLSeri
    {
        DALSeri dalsanpham = new DALSeri();

        public BLLSeri()
        {
        }

        public List<SeriHD> loadsr(int mahd, List<View_CTHDSP> lstSP)
        {
            List<SeriHD> lstSR = dalsanpham.loadsr(mahd);
            List<SeriHD> lstCC = new List<SeriHD>();
            foreach (View_CTHDSP itemSP in lstSP)
            {
                foreach (SeriHD itemSR in lstSR)
                {
                    SeriSP seriSP = dalsanpham.LayThongTinSeriSP(itemSR.Seri);
                    if (seriSP.MaSanPham == itemSP.MaSanPham)
                        lstCC.Add(itemSR);
                    else
                        continue;
                }
            }

            return lstCC;
        }
        // them xoa sua

        public bool postSP(SeriHD cthd)
        {
            return dalsanpham.them(cthd);
        }

        public string loadseritheoma(int ma)
        {
            return dalsanpham.loadseritheomasp(ma);
        }

    }
}
