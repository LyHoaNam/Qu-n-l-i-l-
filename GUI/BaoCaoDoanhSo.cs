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
    
    public partial class BaoCaoDoanhSo : Form
    {
        DaiLiBUS objdl = new DaiLiBUS();
        DaiLiDLL te = new DaiLiDLL();
        TyLe_BCDS objtl = new TyLe_BCDS();
        
        public BaoCaoDoanhSo()
        {
            InitializeComponent();
        }
        
 

        private void trove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

    
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = Convert.ToInt16(cbEThang.Text);
                if (thang < 1 || thang > 12)
                {
                    MessageBox.Show("Bạn nhập tháng không hợp lệ","THÔNG BÁO");
                }
                else
                {
                    DataTable tb = new DataTable();
                    DataColumn tyle = new DataColumn("Ty_Le");
                    tb = objdl.GetBaoCaoDoanhSo(thang);
                    DataColumn ten = new DataColumn("ten");
                    tb.Columns.Add(tyle);
                    tb.Columns.Add(ten);
                    foreach (DataRow d in tb.Rows)
                    {
                        double temp = Convert.ToDouble(d.ItemArray[1].ToString());
                        double tongds = objtl.TongTienDL(thang);
                        double tl = temp / tongds;
                        string IDdl = d.ItemArray[0].ToString();
                        d["Ty_Le"] = tl.ToString();
                        d["ten"] = objdl.GetTenDaiLi(IDdl);
                    }

                    gridControl1.DataSource = tb;


                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình xác nhận!","THÔNG BÁO");
            }
        }

        private void BaoCaoDoanhSo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btXacNhan_Click(sender, e);
            }
        }

        private void BaoCaoDoanhSo_Load(object sender, EventArgs e)
        {

        }
    }
}
