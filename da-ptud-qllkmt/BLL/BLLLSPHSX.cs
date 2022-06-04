using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLLSPHSX
    {
        DALLSPHSX dallsp = new DALLSPHSX();
        public BLLLSPHSX() { }
        public string tenl(int ma)
        {
            return dallsp.loadtenlsp(ma);
        }
        public string tenh(int ma)
        {
            return dallsp.loadtenhsx(ma);
        }
        public List<LoaiSanPham> loadlsp()
        {
            return dallsp.GetDanhSachlsp();
        }
        public bool Themlsp(LoaiSanPham kh)
        {
            return dallsp.Postlsp(kh);
        }
        public bool deletelsp(int ma)
        {
            return dallsp.Deletelsp(ma);
        }
        public bool sualsp(LoaiSanPham kh, int ten)
        {
            return dallsp.Putlsp(kh, ten);
        }
        //hang san xuat
        public List<HangSanXuat> loadhsx()
        {
            return dallsp.GetDanhSachhsx();
        }
        public bool Themhsx(HangSanXuat kh)
        {
            return dallsp.Posthsx(kh);
        }
        public bool deletehsx(int ma)
        {
            return dallsp.Deletehsx(ma);
        }
        public bool suahsx(HangSanXuat kh, int ten)
        {
            return dallsp.Puthsx(kh, ten);
        }
    }
}
