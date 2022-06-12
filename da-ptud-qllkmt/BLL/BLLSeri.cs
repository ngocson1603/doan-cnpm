using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Reflection;
namespace BLL
{
    public class BLLSeri
    {
        DALSeri dalsanpham = new DALSeri();

        public BLLSeri()
        {
        }
        public DataTable ListToDataTable<T>(List<T> items)
        {
            DataTable dt = new DataTable(typeof(T).Name);

            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                dt.Columns.Add(prop.Name);
            }

            foreach (T item in items)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }
        public DataTable LoadDataTable(int ma, List<View_CTHDSP> lstSP)
        {
            List<SeriHD> lst = loadsr(ma, lstSP);
            return ListToDataTable(lst);
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
