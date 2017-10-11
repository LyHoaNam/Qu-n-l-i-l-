using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLiDaiLi
{
    class TaoMa
    {
        public string NextID(string lastID, string prefixID)
        {
            if (lastID == null)
            {
                return prefixID + "001";  // fixwidth default
            }
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            int lengthNumerID = lastID.Length - prefixID.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;

        }
        public string ID="";
        PhieuXuatDLL objPX = new PhieuXuatDLL();
        public string GetLastID(string nameTable, string nameSelectColumn)
        {

            try
            {
                string sql = "SELECT TOP 1 " + nameSelectColumn + " FROM " + nameTable + " ORDER BY " + nameSelectColumn + " DESC";
                DataSet temp = new DataSet();
                temp = objPX.GetDataSet(sql);
                DataSet dataSet = temp;
                if (dataSet.Tables[0].Rows.Count >0 )
                {
                   return dataSet.Tables[0].Rows[0][0].ToString();
                   
                }
              
            }
            catch (Exception)
            {
                //return null;
            }
            return null;
        }


    }
}
