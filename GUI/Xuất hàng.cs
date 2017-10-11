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
    public partial class PhieuXuatHang : Form
    {
        PhieuXuatBUS objpx = new PhieuXuatBUS();
        PhieuThuBus objpt = new PhieuThuBus();
        TaoMa ID = new TaoMa();
        public DataTable TableHang = new DataTable();
        public PhieuXuatHang()
        {
            InitializeComponent();
        }

        DataTable tb = new DataTable();
        //int n = 0;
        private void Xuất_hàng_Load(object sender, EventArgs e)
        {
            TableHang.Columns.Add("MaMatHang",typeof(string));
            TableHang.Columns.Add("TenMatHang", typeof(string));
            TableHang.Columns.Add("soluong", typeof(string));
            TableHang.Columns.Add("DonGiaXuat", typeof(string));
            TableHang.Columns.Add("TenDonViTinh", typeof(string));
            TableHang.Columns.Add("thanhtien", typeof(string));

            cbMatHang.DataSource = objpx.GetMa_TenMatHang();
            cbMatHang.ValueMember = "MaMatHang";
            cbMatHang.DisplayMember = "TenMatHang";

            cbTenDaiLi.DataSource = objpt.GetDaiLi();
            cbTenDaiLi.DisplayMember = "TenDaiLi";
            cbTenDaiLi.ValueMember = "MaDaiLi";

          
            txtTongTien.Text = "";
            txtConLai.Text = "";

            tongtien = 0;
            conlai = 0;
        }

        private void gdViewXuatHang_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

     
        double tongtien = 0;
        double conlai = 0;
        private void btTinhTien_Click_1(object sender, EventArgs e)
        {
            try
            {
                string thanhtienMH = gdViewXuatHang.GetRowCellValue(gdViewXuatHang.FocusedRowHandle, gdViewXuatHang.Columns[5]).ToString();
                tongtien = tongtien - Convert.ToDouble(thanhtienMH);
                conlai = Convert.ToDouble(nUDSoTienTra.Text) - tongtien;
                txtConLai.Text = conlai.ToString();
                txtTongTien.Text = tongtien.ToString();
                gdViewXuatHang.DeleteRow(gdViewXuatHang.FocusedRowHandle);
                dem--;
            }
            catch
            { }
        }

        private void btThanhToan_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tongtien == 0 && nUDSoTienTra.Value != -1)
                    MessageBox.Show("Bạn chưa nhập hêt thông tin thanh toán!", "THÔNG BÁO");
                else
                {
                    //               if(MessageBox.Show.("Bạn có chắc muốn thanh toán! "))
                    conlai = -Convert.ToDouble(nUDSoTienTra.Text) + tongtien;
                    txtConLai.Text = conlai.ToString();

                    string lastID = ID.GetLastID("PhieuXuat", "SoPX");
                    string newID = ID.NextID(lastID, "1");

                    DateTime ngay = dateXH.Value;



                    if (!objpx.ThayDoiTienNo(conlai, cbTenDaiLi.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Có lỗi trong quá trình thanh toán", "THÔNG BÁO");
                    }
                    else
                    {
                        if (!objpx.ThemPhieuXuat(cbTenDaiLi.SelectedValue.ToString(), ngay, tongtien, newID))
                            MessageBox.Show("Có lỗi trong quá trình thanh toán", "THÔNG BÁO");
                        else
                        {
                            for (int i = 0; i < dem; i++)
                            {
                                string IDMatHang = gdViewXuatHang.GetRowCellValue(i, gdViewXuatHang.Columns[0]).ToString();
                                string soluong = gdViewXuatHang.GetRowCellValue(i, gdViewXuatHang.Columns[3]).ToString();
                                string tienMH = gdViewXuatHang.GetRowCellValue(i, gdViewXuatHang.Columns[5]).ToString();
                                objpx.ThemChiTietPhieuXuat(newID, IDMatHang, soluong, tienMH);
                            }
                            MessageBox.Show("Thanh toán thành công", "THÔNG BÁO");
                        }

                    }

                }
            }
            catch
            {
             
            }
        }

      
        int dem = 0;
        
        private bool KiemTraTrungMH(string str)
        {
            int test = 0;
            for (int i=0;i<dem;i++)
            {
                if (str == gdViewXuatHang.GetRowCellValue(i, gdViewXuatHang.Columns[0]).ToString())
                {
                    return false;
                }
                else
                     test++;
            }
            if (test == dem)
                return true;
            return false;
        }
        private void them_Click(object sender, EventArgs e)
        {
            
            if (nUDSoLuong.Value !=0 && KiemTraTrungMH(cbMatHang.SelectedValue.ToString()) ==true)
            {
                tb = objpx.GetMatHang(cbMatHang.SelectedValue.ToString());
                DataRow row = TableHang.NewRow();
                double dongia, soluongMH, thanhtienMH;
                foreach(DataRow d in tb.Rows)
                {
                   
                    dongia = Convert.ToDouble(d.ItemArray[3].ToString());
                    soluongMH = (double)nUDSoLuong.Value;
                    thanhtienMH = dongia * soluongMH;
                    tongtien = tongtien + thanhtienMH;

                    row["MaMatHang"] = d.ItemArray[0].ToString();
                    row["TenMatHang"] = d.ItemArray[1].ToString();
                    row["soluong"] = soluongMH;
                    row["DonGiaXuat"] = d.ItemArray[3].ToString();
                    row["TenDonViTinh"] = d.ItemArray[2].ToString();
                    row["thanhtien"] = thanhtienMH;

                    dem++;
                }
                TableHang.Rows.Add(row);
                gdXuatHang.DataSource = TableHang;
                txtTongTien.Text = tongtien.ToString();
            }
        }

        private void btTimNhanh_Click(object sender, EventArgs e)
        {
            TimNhanh f = new TimNhanh();
            f.ShowDialog();
            if (objpx.GetMa_TenMatHangbangID(f.IDMatHang()) != null)
            {
                cbMatHang.DataSource = objpx.GetMa_TenMatHangbangID(f.IDMatHang());
                cbMatHang.ValueMember = "MaMatHang";
                cbMatHang.DisplayMember = "TenMatHang";
            }
            else
                MessageBox.Show("Mã mặt hàng nhập sai!", "THÔNG BÁO");

        }

        private void cbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbTenDaiLi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMatHang.DataSource = objpx.GetMa_TenMatHang();
            cbMatHang.ValueMember = "MaMatHang";
            cbMatHang.DisplayMember = "TenMatHang";
        }
    }
}
