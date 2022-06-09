using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThemBH
    {
        //public string tensp { get; set; }
        //public int soluong { get; set; }
        public string ma { get; set; }
        public string lydo { get; set; }

        //public ThemBH(string tensp,int soluong, string ma, string lydo)
        //{
        //    this.tensp = tensp;
        //    this.soluong = soluong;
        //    this.ma = ma;
        //    this.lydo = lydo;
        //}
        public ThemBH(string ma, string lydo)
        {
            this.ma = ma;
            this.lydo = lydo;
        }
    }
}
