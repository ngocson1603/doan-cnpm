using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLLSanPham
    {
        DALSanPham dalsanpham = new DALSanPham();

        public BLLSanPham()
        { 
        }

        public List<View_SanPham> LoadSanPham()
        {
            return dalsanpham.GetWatchListSanPham();
        }


        // them xoa sua

        public bool postSP(QuanLySanPham cthd)
        {
            return dalsanpham.PostSanPham(cthd);
        }
        public bool deleteSP(int ma)
        {
            return dalsanpham.DeleteSanPham(ma);
        }

        public bool putSP(QuanLySanPham cthd, int ma)
        {
            return dalsanpham.PutSanPham(cthd, ma);
        }
        


    }
}
