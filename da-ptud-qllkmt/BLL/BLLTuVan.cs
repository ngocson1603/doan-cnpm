using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLTuVan
    {
        DALTuVan daltuvan = new DALTuVan();
        public BLLTuVan() { }


        public List<TinhTrangOne> LoadTinhTrang1()
        {
            return daltuvan.GetTT1();
        }

        public List<View_TinhTrangTwo> LoadTinhTrang2(string tentt1)
        {
            return daltuvan.GetTT2(tentt1);
        }

        public List<View_TinhTrangThree> LoadTinhTrang3(string tentt1, string tentt2)
        {
            return daltuvan.GetTT3(tentt1, tentt2);
        }

        public string LoadAnh(string kq)
        {
            return daltuvan.loadAnh(kq);
        }
    }
}