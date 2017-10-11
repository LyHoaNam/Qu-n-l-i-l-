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
    public partial class TimNhanh : Form
    {
        public TimNhanh()
        {
            InitializeComponent();
        }
        string temp;
      
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "")
            {
               temp = txtMa.Text;
                IDMatHang();
                this.Close();
            }
            else
                MessageBox.Show("Mã chưa được nhập!", "THÔNG BÁO");
        }
        public string IDMatHang()
        {
            return temp;
            
        }

        private void TimNhanh_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && txtMa.Text !="")
            {
                btXacNhan_Click(sender,e);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
