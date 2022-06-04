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
