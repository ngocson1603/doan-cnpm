using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLPhieuNhap
    {
        DALPhieuNhap dalphieunhap = new DALPhieuNhap();
        public BLLPhieuNhap()
        {

        }
        public List<View_PhieuNhap> LoadPN()
        {
            return dalphieunhap.GetDanhSachPN();
        }

        public List<View_CTPhieuNhap> LoadCTPN()
        {
            return dalphieunhap.GetDanhSachCTPN();
        }

        public List<View_PhieuNhap> LoadPhieuNhap(int ma)
        {
            return dalphieunhap.GetWatchListPNNV(ma);
        }

        public List<View_CTPhieuNhap> LoadCTPhieuNhap(int ma)
        {
            return dalphieunhap.GetWatchListCTPNNV(ma);
        }


        public List<View_PhieuNhap> LoadPhieuNhapNV(int ma)
        {
            return dalphieunhap.GetWatchListPhieuNhapNV(ma);
        }
        // them xoa sua pn

        public bool postPN(ThemPhieuNhap cthd)
        {
            return dalphieunhap.PostPN(cthd);
        }
        public bool deletePN(int ma)
        {
            return dalphieunhap.DeletePN(ma);
        }

        public bool putPN(ThemPhieuNhap cthd, int ma)
        {
            return dalphieunhap.PutPN(cthd, ma);
        }
        // them xoa ctpn

        public bool postCTPN(ThemCTPN cthd)
        {
            return dalphieunhap.PostCTPN(cthd);
        }


        public bool deleteCTPN(int ma)
        {
            return dalphieunhap.DeleteCTPN(ma);
        }

        public int GetLastPhieuNhap()
        {
            return dalphieunhap.GetLastPhieuNhap();
        }

        // bieu mau
        public List<View_BieuMauNhapHang> LoadBieuMauNhapHang(int ma)
        {
            return dalphieunhap.LoadBieuMauNhap(ma);
        }
    }
}
