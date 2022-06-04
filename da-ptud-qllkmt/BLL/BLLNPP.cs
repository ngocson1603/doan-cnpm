using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLNPP
    {
        DALNPP dalnpp = new DALNPP();
        public BLLNPP() { }
        public List<NhaPhanPhoi> loadnpp()
        {
            return dalnpp.GetDanhSachnpp();
        }
        public bool Themnpp(NhaPhanPhoi kh)
        {
            return dalnpp.Postnpp(kh);
        }
        public bool deletenpp(int ma)
        {
            return dalnpp.Deletenpp(ma);
        }
        public bool suanpp(NhaPhanPhoi kh, int ten)
        {
            return dalnpp.Putnpp(kh, ten);
        }
    }
}
