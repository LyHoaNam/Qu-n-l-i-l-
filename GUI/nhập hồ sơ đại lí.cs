using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace QuanLiDaiLi
{
    public partial class nhaphosodaili : Form
    {
        DaiLiBUS objDL = new DaiLiBUS();
        TaoMa ID = new TaoMa();
        public nhaphosodaili()
        {
            InitializeComponent();
        }

     

        private void nhaphosodaili_Load(object sender, EventArgs e)
        {
            cbQuan.DataSource = objDL.GetQuan();
            cbQuan.ValueMember = "MaQuan";
            cbQuan.DisplayMember = "TenQuan";

            cbDaiLi.DataSource = objDL.GetLoaiDaiLi();
            cbDaiLi.ValueMember = "MaLoaiDaiLi";
            cbDaiLi.DisplayMember = "LoaiDaiLi";
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            int sdt = Convert.ToInt32(txtSDT.Text);
            DateTime ntn = dtNgayTiepNhan.Value;
            string lastID = ID.GetLastID("DaiLi", "MaDaiLi");
            string newID = ID.NextID(lastID, "DL");
            DaiLi dl = new DaiLi(newID, txtTen.Text, cbDaiLi.SelectedValue.ToString(), sdt, txtDiaChi.Text, cbQuan.SelectedValue.ToString(), ntn, objDL.NoBanDauDaiLi());
          //  if (objDL.ThemQuan(cbQuan.Text) == false)
           // {
            //    MessageBox.Show("Quan {0} ban da hon 4 dai li", cbQuan.Text);
           // }
            if (objDL.ThemDaiLi(dl))
            {
                MessageBox.Show("Them Dai Li Thanh Cong");

            }
            else
                MessageBox.Show("Co loi trong qua trinh them");
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
