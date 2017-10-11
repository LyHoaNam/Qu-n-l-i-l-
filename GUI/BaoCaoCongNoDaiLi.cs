using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDaiLi
{
    public partial class BaoCaoCongNoDaiLi : Form
    {
        DaiLiBUS ObjDL =new DaiLiBUS();
        public BaoCaoCongNoDaiLi()
        {
            InitializeComponent();
        }

        private void BaoCaoCongNoDaiLi_Load(object sender, EventArgs e)
        {
     
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int th = Convert.ToInt16(cbEThang.Text);
                DataTable dt = new DataTable();
                dt = ObjDL.GetNoDaiLi(th.ToString());
                DataColumn NoDau = new DataColumn("nodau");
                DataColumn NoCoui = new DataColumn("nocuoi");
                DataColumn TenDL = new DataColumn("TenDL");
                dt.Columns.Add(NoDau);
                dt.Columns.Add(NoCoui);
                dt.Columns.Add(TenDL);

                foreach (DataRow d in dt.Rows)
                {
                    string ID = d.ItemArray[0].ToString();
                    Double phatsinh = Convert.ToDouble(d.ItemArray[1].ToString());

                    d["TenDL"] = ObjDL.GetTenDaiLi(ID);

                    d["nodau"] = ObjDL.GetTongTienPX_ID(ID, (th - 1).ToString()) - ObjDL.GetSoTienThu_ID(ID, (th - 1).ToString());

                    d["nocuoi"] = ObjDL.GetTongTienPX_ID(ID, (th + 1).ToString()) - ObjDL.GetSoTienThu_ID(ID, (th + 1).ToString());

                    d["Tong"] = phatsinh - ObjDL.GetSoTienThu_ID(ID, (th).ToString());

                }

                gridControl1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình xác nhận!", "THÔNG BÁO");
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BaoCaoCongNoDaiLi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                simpleButton1_Click(sender,e);
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
