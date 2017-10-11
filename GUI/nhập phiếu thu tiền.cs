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
    public partial class phieuthutien : Form
    {
        PhieuThuBus objpt = new PhieuThuBus();
        BindingSource bSource = new BindingSource();
        TaoMa ID =new TaoMa();
        public phieuthutien()
        {
            InitializeComponent();
        }
        private void phieuthutien_Load(object sender, EventArgs e)
        {
            bSource.DataSource = objpt.GetDaiLi();
            cbTenDaiLi.DataSource = bSource;
            cbTenDaiLi.DisplayMember = "TenDaiLi";
            cbTenDaiLi.ValueMember = "MaDaiLi";
        }
        private void cbTenDaiLi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string madl = cbTenDaiLi.SelectedValue.ToString();
            DataTable tb = new DataTable();
            tb = objpt.GetMaDaiLi(madl);
            foreach (DataRow d in tb.Rows)
            {
                txtDiaChi.Text = d.ItemArray[2].ToString();
                txtSDT.Text = d.ItemArray[3].ToString();
            }
        }
        
        private void btXacNhan_Click_1(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || nUDSoTienThu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập hết dữ liệu");
            }
            else
            {

                string lastID = ID.GetLastID("PhieuThuTien", "MaPhieuThuTien");
                string newID = ID.NextID(lastID, "PT");

                int tien = Convert.ToInt32(nUDSoTienThu.Text);
                int tienno = objpt.GetNoDaiLi(cbTenDaiLi.SelectedValue.ToString());
                
                if (tien > tienno)
                {
                    MessageBox.Show("Số tiền nợ đại lý nợ: "+tienno+ " bé hơn tiền thu!","SỐ TIỀN NỢ KHÔNG VƯỢC HƠN SỐ TIỀN THU");
                }
                else
                {

                    DateTime ngay = dateTT.Value;
                    PhieuThu Pt = new PhieuThu(newID, cbTenDaiLi.SelectedValue.ToString(), ngay, tien, txtEmail.Text);
                    int tiennodatra = tienno - tien;
                    objpt.ThayDoiTienNo(tiennodatra, cbTenDaiLi.SelectedValue.ToString());
                    if (objpt.ThemPhieuThu(Pt))
                    {
                        MessageBox.Show("Thêm phiếu thu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm");
                    }
                }
            }
          
        }

        private void btTroVe_Click_1(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Tiền nợ của đại lý: " + cbTenDaiLi.Text + " là: " + objpt.GetNoDaiLi(cbTenDaiLi.SelectedValue.ToString()).ToString(), "THÔNG BÁO");
            }
            catch
            {
                MessageBox.Show("Chưa có dữ liệu để xem!", "THÔNG BÁO");
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
