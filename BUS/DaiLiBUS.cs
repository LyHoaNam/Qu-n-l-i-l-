using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLiDaiLi
{
    class DaiLiBUS
    {
        DaiLiDLL objDL = new DaiLiDLL();
        PhieuXuatDLL objPX = new PhieuXuatDLL();
        public DataTable GetDaiLi()
        {
            string str = "SELECT MaDaiLi,TenDaiLi, LoaiDaiLi,TenQuan, NoCuaDaiLi FROM DaiLi d Join Quan q on d.MaQuan=q.MaQuan join LoaiDaiLi l on l.MaLoaiDaiLi=d.MaLoaiDaiLi";
            return objDL.GetAll(str);
        }
        string ID="123";
    
        public string GetTenDaiLi(string IDDL)
        {
            string str = "SELECT TenDaiLi FROM DaiLi WHERE MaDaiLi = '" + IDDL + "'";
            try
            {
                DataSet data = new DataSet();
                data = objPX.GetDataSet(str);

                if (data.Tables[0].Rows.Count > 0)
                {
                    ID = data.Tables[0].Rows[0][0].ToString();

                }

            }
            catch (Exception)
            {

            }
            return ID;

        }
        public DataTable GetALLLoaiDaiLi()
        {
            string str = "SELECT * FROM LoaiDaiLi";
            return objDL.GetAll(str);
        }
        public DataTable GetQuan()
        {
            string str = "SELECT MaQuan, TenQuan FROM Quan";
            return objDL.GetAll(str);
        }
        public DataTable GetLoaiDaiLi()
        {
            string str = "SELECT MaLoaiDaiLi, LoaiDaiLi FROM LoaiDaiLi";
            return objDL.GetAll(str);
        }
        public DataTable GetMatHang()
        {
            string str = "SELECT MaMatHang,TenMatHang,SoLuongTinh,DonGiaXuat, TenDonViTinh FROM MatHang m join DonViTinh d on m.MaDonViTinh=d.MaDonViTinh";
            return objDL.GetAll(str);
        }
        public DataTable GetDonViTinh()
        {
            string str = "SELECT * FROM DonViTinh";
            return objDL.GetAll(str);
        }
        public DataTable GetALLQuan()
        {
            string str = "SELECT * FROM Quan";
            return objDL.GetAll(str);
        }
 
        public DataTable GetBaoCaoDoanhSo(int thang)
        {

            string str = "SELECT px.MaDaiLi, Sum(TongGiaTri) Tong, COUNT(SoPX) Dem from PhieuXuat px where month(NgayLapPhieu) = "+thang+" group by px.MaDaiLi";
           
            return objDL.GetAll(str);
        }
   
        public bool ThemDaiLi(DaiLi dl)
        {
            string SQLstring = "insert into DaiLi(MaDaiLi, TenDaiLi, MaLoaiDaiLi, DienThoai, DiaChi, MaQuan, NgayTiepNhan, NoCuaDaiLi)" +
                                   "values ('" + dl.MaDaiLi + "', '" + dl.TenDaiLi + "','" + dl.LoaiDaiLi + "'," + dl.DienThoai + ",'" + dl.DiaChi + "','" + dl.TenQuan + "','" + dl.NgayTiepNhan + "'," + dl.NocuaDaiLi + ")";
            if (objDL.AddData(SQLstring))
            return true;
            else
            return false;
        }
        public bool XoaDaiLi(string ten,string tienno)
        {
            string SQLstring = "DELETE FROM DaiLi WHERE TenDaiLi= '" + ten+"' AND NoCuaDaiLi ="+tienno;
            if (objDL.AddData(SQLstring))
            {
               
                return true;
            }
            else
                return false;
            
        }
     
        public int GetSoLuongQuanDangCo(string str)
        {
            return objDL.GetSlQuanDangCo(str);
        }
        public int GetSoLuongQuanToiDa(string str)
        {
            return objDL.GetSlQuanToiDa(str);
        }
        public int NoBanDauDaiLi()
        {
            int a = 0;
            return a;
        }
        public DataTable GetNoDaiLi(string thang)
        {
            string str = "SELECT MaDaiLi, Sum(TongGiaTri) Tong FROM PhieuXuat WHERE MONTH(NgayLapPhieu)= "+thang+" GROUP BY MaDaiLi";
            return objDL.GetAll(str);
        }

        double tien;
        double tienthu=0;
        public double GetSoTienThu_ID(string ID_DL,string thang)
        {
            string str = "SELECT SUM(SoTienThu)  FROM PhieuThuTien WHERE MaDaiLi ='"+ID_DL+"' AND MONTH(NgayThuTien)= "+thang+" GROUP BY MaDaiLi";
           
            tienthu = 0;
            try
            {
                DataSet data = new DataSet();
                data = objPX.GetDataSet(str);

                if (data.Tables[0].Rows.Count > 0)
                {
                    tienthu = Convert.ToDouble(data.Tables[0].Rows[0][0].ToString());
                }

            }
            catch (Exception)
            {

            }
            return tienthu;

        }
        public double GetTongTienPX_ID(string ID_DL, string thang)
        {
            string str = "SELECT Sum(TongGiaTri) Tong FROM PhieuXuat WHERE MONTH(NgayLapPhieu)= "+thang+" AND MaDaiLi='"+ID_DL+"'";
            tien = 0;
            try
            {
                DataSet data = new DataSet();
                data = objPX.GetDataSet(str);

                if (data.Tables[0].Rows.Count > 0)
                {
                    tien = Convert.ToDouble(data.Tables[0].Rows[0][0].ToString());

                }

            }
            catch (Exception)
            {

            }
            return tien;

        }
    }
 

}
