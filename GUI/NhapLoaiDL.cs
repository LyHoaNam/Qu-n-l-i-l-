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
    public partial class NhapLoaiDL : Form
    {
        ThayDoiQuyenBUS objTDQ = new ThayDoiQuyenBUS();
        public NhapLoaiDL()
        {
            InitializeComponent();
        }

        private void NhapLoaiDL_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiDL.Text == "" || nbNo.Text == "")
            {
                MessageBox.Show("Bạn phải nhập hết dữ liệu","THÔNG BÁO");
            }
            else
            {


                int no = Convert.ToInt32(nbNo.Text);


                if (objTDQ.AddLoaiDL(txtTenLoaiDL.Text, no))
                {
                    MessageBox.Show("Thêm loại đại lý thành công", "THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm", "THÔNG BÁO");
                }

            }
            this.Close();
        }

        private void NhapLoaiDL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtTenLoaiDL.Text!="")
            {
                simpleButton1_Click(sender, e);
            }
        }
    }
}
