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
    public partial class ThayDoiQuyen : Form
    {
        DaiLiBUS objDL = new DaiLiBUS();
        ThayDoiQuyenBUS objTDQ = new ThayDoiQuyenBUS();

        public ThayDoiQuyen()
        {
            InitializeComponent();
        }

        private void ThayDoiQuyen_Load(object sender, EventArgs e)
        {
            gcDonViTinh.DataSource = objDL.GetDonViTinh();
            gcLoaiDaiLi.DataSource = objDL.GetALLLoaiDaiLi();
            gcMatHang.DataSource = objDL.GetMatHang();
            DataTable quan = objDL.GetALLQuan();
            cbQuan.DataSource = quan;
            cbQuan.DisplayMember = "TenQuan";
            cbQuan.ValueMember = "MaQuan";
            nudSLQuan.Text = objTDQ.GetSoLuongDaiLi_Quan(cbQuan.SelectedValue.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Bạn có muốn xóa ", "Xóa loại đại lý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string tenloaidl = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                string loaidl = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
                if (objTDQ.DelLoaiDL(loaidl)!=true)
                    MessageBox.Show("Loại đại lý: "+tenloaidl+" đã sử dụng, hệ thống không cho phép xóa!","THÔNG BÁO");
            }
            gcLoaiDaiLi.DataSource = objDL.GetALLLoaiDaiLi();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            NhapLoaiDL f = new NhapLoaiDL();
            f.ShowDialog();
            gcLoaiDaiLi.DataSource = objDL.GetALLLoaiDaiLi();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (objTDQ.ThayDoiQuan(cbQuan.SelectedValue.ToString(), nudSLQuan.Text))
            {
                MessageBox.Show("Bạn đã thay đổi số lượng quận thành công", "THÔNG BÁO");
            }
            else
                MessageBox.Show("Có lỗi trong quá trình thay đổi", "THÔNG BÁO");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Xóa đơn vị tính", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string ten = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[0]).ToString();
                if (objTDQ.DelDonViTinh(ten) != true)
                    MessageBox.Show("Có lỗi trong quá trình xóa");

            }

            gcDonViTinh.DataSource = objDL.GetDonViTinh();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DonViTinh f = new DonViTinh();
            f.ShowDialog();
            gcDonViTinh.DataSource = objDL.GetDonViTinh();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            ThemMatHang f = new ThemMatHang();
            f.ShowDialog();
            gcMatHang.DataSource = objDL.GetMatHang();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ?", "Xóa mặt hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string ten = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns[0]).ToString();
                if (objTDQ.DelMatHang(ten) == true)
                    MessageBox.Show("Bạn xóa đã mặt hàng " + ten + " thành công", "THÔNG BÁO");
                else
                    MessageBox.Show("Có lỗi trong quá trình xóa", "THÔNG BÁO");

            }
            gcMatHang.DataSource = objDL.GetMatHang();
        }

        private void cbQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudSLQuan.Text = objTDQ.GetSoLuongDaiLi_Quan(cbQuan.SelectedValue.ToString());
        }
    }
}
