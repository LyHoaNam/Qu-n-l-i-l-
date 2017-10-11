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
    public partial class DonViTinh : Form
    {
        ThayDoiQuyenBUS objTDQ = new ThayDoiQuyenBUS();
        public DonViTinh()
        {
            InitializeComponent();
        }

        private void DonViTinh_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtDVT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập hết dữ liệu");
            }
            else
            {
                if (objTDQ.AddDonViTinh(txtDVT.Text))
                {
                    MessageBox.Show("Thêm đơn vị " + txtDVT.Text + " Thành Công");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm");
                }

            }
            this.Close();

        }

        private void DonViTinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtDVT.Text != "")
            {
                simpleButton1_Click(sender, e);
            }
        }
    }
}
