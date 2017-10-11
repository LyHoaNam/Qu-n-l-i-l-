using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLiDaiLi
{
    class PhieuXuatBUS
    {
        DaiLiDLL objDL = new DaiLiDLL();
        public DataTable GetMa_TenMatHang()
        {
            string str = "SELECT MaMatHang,TenMatHang from MatHang";
            return objDL.GetAll(str);
        }
        public DataTable GetMa_TenMatHangbangID(string ID)
        {
                string str = "SELECT MaMatHang,TenMatHang from MatHang where MaMatHang ='" + ID + "'";
            if (objDL.GetAll(str) != null)
                return objDL.GetAll(str);
            else
                return null;
         
        }
        public DataTable GetMatHang(string ID)
        {
            string str = "select MaMatHang,  TenMatHang, TenDonViTinh, DonGiaXuat from MatHang m join DonViTinh d on m.MaDonViTinh=d.MaDonViTinh WHERE MaMatHang = '"+ID+"'";
            return objDL.GetAll(str);
        }
        public bool ThemPhieuXuat(string madl, DateTime ngay, double tongt,string so)
        {
            string SQLstring = "insert into PhieuXuat(MaDaiLi, NgayLapPhieu, TongGiaTri, SoPX) values('"+madl+" ', '"+ngay+"', "+tongt+", "+so+")";
            if (objDL.AddData(SQLstring))
                return true;
            else
                return false;
        }
        public bool ThemChiTietPhieuXuat(string so, string mamh, string soluong, string tien)
        {
            string SQLstring = "insert into ChiTietPhieuXuat(SoPX, MaMatHang, SoLuongXuat, ThanhTien) values("+so+", '"+mamh+"',"+soluong+", "+tien+")";
            if (objDL.AddData(SQLstring))
                return true;
            else
                return false;
        }
        public bool ThayDoiTienNo(double newno, string ma)
        {
            string str = "UPDATE DaiLi SET NoCuaDaiLi = " + newno + "+NoCuaDaiLi WHERE MaDaiLi = '" + ma + "'";
            if (objDL.updateDaiLi(str))
                return true;
            else
                return false;

        }

    }
}
