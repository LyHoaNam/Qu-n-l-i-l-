using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLiDaiLi
{
    class PhieuXuatDLL:ConnectSQL
    {
        public PhieuXuatDLL():base(){ }
        public DataSet GetDataSet(string str)
        {
            
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
        public bool TryGetDataSet()
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string str= "UPDATE Quan SET SoLuongDaiLi = 0 WHERE TenQuan = 'Thu Duc'";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                DataSet dt = new DataSet();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
            }
            return false;
        }
        /*public DoanhSo getDoanhSo( int sumds,int thang)
        {
            DoanhSo ds = null;
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string str = "SELECT TenDaiLi , SoLuongXuat,TongGiaTri FROM DaiLi d join PhieuXuat px on d.MaDaiLi=px.MaDaiLi join ChiTietPhieuXuat ctp on px.MaPhieuXuat=ctp.MaPhieuXuat where month(px.NgayLapPhieu)='" + thang + "'";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    ds = new DoanhSo();
                    ds.TenDaiLi = rd["TenDaiLi"].ToString();
                    ds.SoPhieuXuat = (int)rd["SoLuongXuat"];
                    ds.TongGiaTri = (int)rd["TongGiaTri"];
                    ds.Tyle = sumds / (int)rd["TongGiatri"];
                    rd.Close();
                }

            }
            catch
            {
                conn.Close();
            }
            return ds;
        }*/
        public DataTable getDoanhSo(int sumds,int thang)
        {
            DataTable ds = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string str = "SELECT TenDaiLi , SoLuongXuat,TongGiaTri FROM DaiLi d join PhieuXuat px on d.MaDaiLi=px.MaDaiLi join ChiTietPhieuXuat ctp on px.MaPhieuXuat=ctp.MaPhieuXuat where month(px.NgayLapPhieu)='" + thang + "'";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();
            }
            return null;
        }

    }

}
