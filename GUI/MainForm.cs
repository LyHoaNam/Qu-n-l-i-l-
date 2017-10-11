using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;
namespace QuanLiDaiLi
{
    public partial class mainform : Form
    {
        DaiLiBUS objdl = new DaiLiBUS();
        DataTable tbDaiLi;
        TaoMa ID = new TaoMa();
        public static string strChon = "";
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            tbDaiLi = objdl.GetDaiLi();
            gdDanhSach.DataSource = tbDaiLi;

            cbQuan.DataSource = objdl.GetQuan();
            cbQuan.ValueMember = "MaQuan";
            cbQuan.DisplayMember = "TenQuan";

            cbDaiLi.DataSource = objdl.GetLoaiDaiLi();
            cbDaiLi.ValueMember = "MaLoaiDaiLi";
            cbDaiLi.DisplayMember = "LoaiDaiLi";



        }

 

        private void strMnPhieuThuTien_Click(object sender, EventArgs e)
        {
            phieuthutien f = new phieuthutien();
            f.Show();
        }

        private void trMnPhieuXuatHang_Click(object sender, EventArgs e)
        {
            PhieuXuatHang f = new PhieuXuatHang();
            f.Show();
        }

        private void strMnBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            BaoCaoCongNoDaiLi f = new BaoCaoCongNoDaiLi();
            f.Show();
        }

        private void trMnBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhSo f = new BaoCaoDoanhSo();
            f.Show();
        }


        private void gdDanhSachView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    
    

        private void them_Click_1(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
                MessageBox.Show("Bạn phải nhập đủ thông tin đại lý","THÔNG BÁO");
            else
            {
                int sdt = Convert.ToInt32(txtSDT.Text);
                DateTime ntn = dtNgayTiepNhan.Value;
                string lastID = ID.GetLastID("DaiLi", "MaDaiLi");
                string newID = ID.NextID(lastID, "DL");
                DaiLi dl = new DaiLi(newID, txtTen.Text, cbDaiLi.SelectedValue.ToString(), sdt, txtDiaChi.Text, cbQuan.SelectedValue.ToString(), ntn, 0);

              

                if (objdl.GetSoLuongQuanDangCo(cbQuan.SelectedValue.ToString())>= objdl.GetSoLuongQuanToiDa(cbQuan.SelectedValue.ToString()))
                {
                    MessageBox.Show("Quận: "+cbQuan.Text+" chỉ chứa "+ objdl.GetSoLuongQuanToiDa(cbQuan.SelectedValue.ToString())+" quận!","THÔNG BÁO");
                }
                else
                {
                    if (objdl.ThemDaiLi(dl))
                    {
                        MessageBox.Show("Thêm đại lý thành công","THÔNG BÁO");

                    }
                    else
                        MessageBox.Show("Có lỗi trong quá trình thêm","THÔNG BÁO");
                }
                gdDanhSach.DataSource = objdl.GetDaiLi();
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtTen.Text = "";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa đại lý?", "XÓA ĐẠI LÝ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string ten = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                string TienNo = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
                
                if (objdl.XoaDaiLi(ten,TienNo) == true)
                    MessageBox.Show("Xóa đại lý thành công", "THÔNG BÁO");
                else
                    MessageBox.Show("Đại lý này đã chứa dữ liệu, hệ thống không có phép xóa","THÔNG BÁO");

            }
            gdDanhSach.DataSource = objdl.GetDaiLi();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show("Đang Update");
        }

        private void cbQuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ThayDoiQuyen f = new ThayDoiQuyen();
            f.Show();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if(!char.IsDigit(e.KeyChar)&&(int) e.KeyChar!=8)
                {
                e.Handled = true;
                }
        }
    }
}
