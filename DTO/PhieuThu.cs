using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDaiLi
{
    class PhieuThu
    {
        public string MaPhieuThuTien { get; set; }
        public string MaDaiLi { get; set; }
        public DateTime NgayThuTien { get; set; }
        public int SoTienThu { get; set; }
        public string email { get; set; }
        public PhieuThu()
        { }
        public PhieuThu(string map, string mdl,DateTime Ngay, int tien, string em)
        {
            MaPhieuThuTien = map;
            MaDaiLi = mdl;
            NgayThuTien = Ngay;
            SoTienThu = tien;
            email = em;
        }
    }
}
