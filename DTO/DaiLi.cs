using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDaiLi
{
    public class DaiLi
    {
        public string MaDaiLi { get; set; }
        public string TenDaiLi { get; set; }
        public string LoaiDaiLi { get; set; }
        public string DiaChi { get; set; }
        public string TenQuan { get; set; }
        public DateTime NgayTiepNhan { get; set; }
     
        public int NocuaDaiLi { get; set; }
        public int DienThoai { get; set; }
        public DaiLi()
        { }
        public DaiLi(string Ma,string Ten, string LoaiDL, int SDT, string DiaChiDL, string Quan, DateTime Ngay, int No)
        {
            MaDaiLi = Ma;
            TenDaiLi = Ten;
            LoaiDaiLi = LoaiDL;
            DienThoai = SDT;
            DiaChi = DiaChiDL;
            TenQuan = Quan;
            NgayTiepNhan = Ngay;
            NocuaDaiLi = No;

        }
       
    }
}
