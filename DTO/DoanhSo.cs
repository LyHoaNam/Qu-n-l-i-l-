using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDaiLi
{
    public class DoanhSo
    {
        
        public string TenDaiLi { get; set; }
        public int SoPhieuXuat { get; set; }
        public int TongGiaTri { get; set; }
        public float Tyle { get; set; }
        public DoanhSo()
        { }
        public DoanhSo(string tendl,int sl, int tgt,float tl)
        {
            TenDaiLi = tendl;
            SoPhieuXuat = sl;
            TongGiaTri = tgt;
            Tyle = tl;

        }

    }
}
