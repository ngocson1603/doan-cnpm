using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class productList
    {
        public string Anh { get; set; }

        public string TenSP { get; set; }

        public productList()
        {
            Anh = Anh;
            TenSP = TenSP;
        }

        public productList(string tensp, string anh)
        {
            Anh = anh;
            TenSP = tensp;
        }
    }
}
