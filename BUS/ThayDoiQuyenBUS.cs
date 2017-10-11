using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLiDaiLi
{
    class ThayDoiQuyenBUS
    {
        DaiLiDLL objdl = new DaiLiDLL();
        TaoMa ID = new TaoMa();
        PhieuXuatDLL objPX = new PhieuXuatDLL();
        public bool DelLoaiDL(string loaidl)
        {
            string SQLstring = "DELETE FROM LoaiDaiLi WHERE MaLoaiDaiLi= '" + loaidl + "'";
            if (objdl.AddData(SQLstring))
                return true;
            else return false;
        }
        public bool DelDonViTinh(string ten)
        {
            string SQLstring = "DELETE FROM DonViTinh WHERE TenDonViTinh= '" + ten + "'";
            if (objdl.AddData(SQLstring))
                return true;
            return false;
        }
        public bool DelMatHang(string ten)
        {
            string SQLstring = "DELETE FROM MatHang WHERE TenMatHang= '" + ten + "'";
            if (objdl.AddData(SQLstring))
                return true;
            return false;
        }
        public bool AddLoaiDL(string str, double no)
        {
            string lastIDloaiDL= ID.GetLastID("LoaiDaiLi", "MaLoaiDaiLi");
            string newIDloaiDL = ID.NextID(lastIDloaiDL, "LDL");
            string SQLstring = "insert into LoaiDaiLi(MaLoaiDaiLi,LoaiDaiLi,NoToiDa)" +
                                 "values ('"+ newIDloaiDL +"',N'" + str + "', " +no+ ")";
            if (objdl.AddData(SQLstring))
                return true;
            else
                return false;
        }
        public bool AddDonViTinh(string str)
        {
            string lastID = ID.GetLastID("DonViTinh", "MaDonViTinh");
            string newID = ID.NextID(lastID, "DVT");
            string SQLstring = "insert into DonViTinh(MaDonViTinh,TenDonViTinh)" +
                                "values ('" + newID + "', '" + str + "')";
            if (objdl.AddData(SQLstring))
                return true;
            else
                return false;
        }
        string IDDVT;
        public string GetIDDonViTinh(string ten)
        {
            IDDVT = "";
            string str = "SELECT MaDonViTinh FROM DonViTinh WHERE TenDonViTinh = '" + ten + "'";
            try
            {
                DataSet data = new DataSet();
                data = objPX.GetDataSet(str);

                if (data.Tables[0].Rows.Count > 0)
                {
                    IDDVT = data.Tables[0].Rows[0][0].ToString();

                }

            }
            catch (Exception)
            {

            }
            return IDDVT;
        }
        public string GetSoLuongDaiLi_Quan(string quan)
        {
            string str = "SELECT SoLuongDaiLi FROM Quan WHERE MaQuan = '" + quan + "'";
            IDDVT = "";
            try
            {
                DataSet data = new DataSet();
                data = objPX.GetDataSet(str);

                if (data.Tables[0].Rows.Count > 0)
                {
                    IDDVT = data.Tables[0].Rows[0][0].ToString();

                }

            }
            catch (Exception)
            {

            }
            return IDDVT;
        }
        public bool AddMatHang(string ten, int sl, double dg, string dvt)
        {
            string lastID = ID.GetLastID("MatHang", "MaMatHang");
            string newID = ID.NextID(lastID, "MH");
            string IDdonvi = GetIDDonViTinh(dvt);
            string SQLstring = "insert into MatHang(MaMatHang,TenMatHang,SoLuongTinh,MaDonViTinh,DonGiaXuat)" +
                                "values ('" + newID + "', '" + ten + "', "+sl+" , '" + IDdonvi+"',"+dg+")";
            if (objdl.AddData(SQLstring))
                return true;
            else
                return false;
        }
        public bool ThayDoiQuan(string quan, string slquan)
        {
            string str = "UPDATE Quan SET SoLuongDaiLi = " + slquan + " WHERE MaQuan = '" + quan + "'";
            if (objdl.updateDaiLi(str))
                return true;
            else
                return false;

        }

    }
}
