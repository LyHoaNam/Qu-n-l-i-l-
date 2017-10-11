using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLiDaiLi
{
    class PhieuThuBus
    {
        DaiLiDLL objDL = new DaiLiDLL();
        PhieuXuatDLL objPX = new PhieuXuatDLL();
        public DataTable GetDaiLi()
        {
            string str = "SELECT MaDaiLi, TenDaiLi, DiaChi,DienThoai FROM DaiLi";
            return objDL.GetAll(str);
        }
        public DataTable GetMaDaiLi(string ma)
        {
            string str = "SELECT MaDaiLi, TenDaiLi, DiaChi,DienThoai FROM DaiLi WHERE MaDaiLi ='"+ma+"'";
            return objDL.GetAll(str);
        }
        public bool ThemPhieuThu(PhieuThu pt)
        {
            string SQLstring = "insert into PhieuThuTien(MaPhieuThuTien,MaDaiLi,NgayThuTien,SoTienThu,Email)" +
                                  "values ('" + pt.MaPhieuThuTien + "', '" + pt.MaDaiLi + "','" + pt.NgayThuTien + "','" + pt.SoTienThu + "','" + pt.email+"')";
            if (objDL.AddData(SQLstring))
                return true;
            else
                return false;
        }
        public int no=0;
        public int GetNoDaiLi(string ma)
        {
            try
            {
                string str = "SELECT NoCuaDaiLi FROM DaiLi WHERE MaDaiLi='" + ma + "'";
                DataSet data = new DataSet();
                data = objPX.GetDataSet(str);
                
                if (data.Tables[0].Rows.Count > 0)
                {
                    no= Convert.ToInt32(data.Tables[0].Rows[0][0].ToString());
                    
                }
            }
            catch(Exception)
            {
              
            }
            return no;
        }
        public bool ThayDoiTienNo(int newno,string ma)
        {
            string str = "UPDATE DaiLi SET NoCuaDaiLi = " + newno + " WHERE MaDaiLi = '" + ma + "'";
            if (objDL.updateDaiLi(str))
                return true;
            else
                return false;
            
        }
    }
}
