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
    public partial class ThemMatHang : Form
    {
        ThayDoiQuyenBUS objTDQ = new ThayDoiQuyenBUS();
        DaiLiBUS objDL = new DaiLiBUS();
        public ThemMatHang()
        {
            InitializeComponent();
        }

        private void ThemMatHang_Load(object sender, EventArgs e)
        {
            cbDVT.DataSource = objDL.GetDonViTinh();
            cbDVT.ValueMember = "MaDonViTinh";
            cbDVT.DisplayMember = "TenDonViTinh";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || nudDonGia.Text == "" || nudSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập hết dữ liệu", "THÔNG BÁO");
            }
            else
            {


                int sl = Convert.ToInt32(nudSoLuong.Text);
                double dg = Convert.ToDouble(nudDonGia.Text);


                if (objTDQ.AddMatHang(txtTen.Text, sl, dg, cbDVT.Text))
                {
                    MessageBox.Show("Thêm loại đại lý thành công", "THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm", "THÔNG BÁO");
                }

            }
            txtTen.Text = "";
            nudDonGia.Text = "0";
            nudSoLuong.Text = "0";
        }

        private void ThemMatHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtTen.Text != "" && cbDVT.Text != "")
            {
                simpleButton1_Click(sender, e);
            }
        }
    }
}
