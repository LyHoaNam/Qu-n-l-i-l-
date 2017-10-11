using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLiDaiLi
{
    class TyLe_BCDS
    {
        PhieuXuatDLL objPX = new PhieuXuatDLL();
        int SoLuongPX = 0;
        public double TongTienDL(int thang)
        {
            double num = 0;
            try
            {
                string str = "SELECT sum(TongGiaTri) Tong, count(SoPX) so  FROM PhieuXuat WHERE month(NgayLapPhieu)=" + thang + "";
                DataSet temp = new DataSet();
                temp = objPX.GetDataSet(str);

                
                if (temp.Tables[0].Rows.Count > 0)
                {
                     num = Convert.ToDouble(temp.Tables[0].Rows[0][0].ToString());
                    SoLuongPX = Convert.ToInt32(temp.Tables[0].Rows[0][1].ToString());
                   
                }
            }
            catch (Exception)
            {
            }
            
            return num;
        }
        public int SoLuongPhieuXuat(int thang)
        {
            return SoLuongPX;
        }
      

    }
}
