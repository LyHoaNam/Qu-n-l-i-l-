using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLiDaiLi
{
   
    class DaiLiDLL: ConnectSQL
    {
        
        public DaiLiDLL() : base() { }
        public DataTable GetAll(string str)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
               
            }
            finally
            {
                conn.Close();
            }
        }
      
       
        
        public bool AddData(string SQLstring)
       {
          
            
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                
                SqlCommand cmd = new SqlCommand(SQLstring, conn);
                cmd.ExecuteNonQuery();
                
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
   
                return false;
            }
       }
        private int soluong=0;
        public int GetSlQuanToiDa(string str)
        {
            try
            {
                string sql = "SELECT SoLuongDaiLi FROM Quan WHERE MaQuan ='" + str + "'";
                DataSet temp = new DataSet();
                temp = objPX.GetDataSet(sql);
                DataSet dataSet = temp;
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    soluong = Convert.ToInt16(dataSet.Tables[0].Rows[0][0].ToString());
                }
                return soluong;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int GetSlQuanDangCo(string str)
        {
            try
            {
                string sql = "SELECT count(MaQuan) FROM DaiLi WHERE MaQuan ='"+str+"'";
                DataSet temp = new DataSet();
                temp = objPX.GetDataSet(sql);
                DataSet dataSet = temp;
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    soluong = Convert.ToInt16(dataSet.Tables[0].Rows[0][0].ToString());
                }
                return soluong;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        PhieuXuatDLL objPX =new PhieuXuatDLL();
   
        public bool updateDaiLi(string str)
        {
         
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
        }

        public bool DelData(string str)
        {
            
            
            SqlCommand cmd = new SqlCommand(str, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.Close();
            }
            return false;
        }


    }
}
