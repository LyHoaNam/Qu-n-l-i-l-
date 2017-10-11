namespace QuanLiDaiLi
{
    partial class PhieuXuatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
       // private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuXuatHang));
            this.gdXuatHang = new DevExpress.XtraGrid.GridControl();
            this.gdViewXuatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateXH = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTenDaiLi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTinhTien = new DevExpress.XtraEditors.SimpleButton();
            this.btThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btTimNhanh = new DevExpress.XtraEditors.SimpleButton();
            this.nUDSoTienTra = new System.Windows.Forms.NumericUpDown();
            this.cbMatHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nUDSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.them = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdXuatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdViewXuatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoTienTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // gdXuatHang
            // 
            this.gdXuatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gdXuatHang.Location = new System.Drawing.Point(28, 109);
            this.gdXuatHang.MainView = this.gdViewXuatHang;
            this.gdXuatHang.Name = "gdXuatHang";
            this.gdXuatHang.Size = new System.Drawing.Size(559, 135);
            this.gdXuatHang.TabIndex = 9;
            this.gdXuatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdViewXuatHang});
            // 
            // gdViewXuatHang
            // 
            this.gdViewXuatHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gdViewXuatHang.GridControl = this.gdXuatHang;
            this.gdViewXuatHang.IndicatorWidth = 50;
            this.gdViewXuatHang.Name = "gdViewXuatHang";
            this.gdViewXuatHang.OptionsView.ShowGroupPanel = false;
            this.gdViewXuatHang.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gdViewXuatHang_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MÃ MẶT HÀNG";
            this.gridColumn1.FieldName = "MaMatHang";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TÊN MẶT HÀNG";
            this.gridColumn2.FieldName = "TenMatHang";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ĐƠN VỊ TÍNH";
            this.gridColumn3.FieldName = "TenDonViTinh";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "SỐ LƯỢNG";
            this.gridColumn4.FieldName = "soluong";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ĐƠN GIÁ";
            this.gridColumn5.FieldName = "DonGiaXuat";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "THÀNH TIỀN";
            this.gridColumn6.FieldName = "thanhtien";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTongTien.Location = new System.Drawing.Point(468, 262);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(119, 20);
            this.txtTongTien.TabIndex = 10;
            // 
            // txtConLai
            // 
            this.txtConLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConLai.Location = new System.Drawing.Point(468, 320);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.ReadOnly = true;
            this.txtConLai.Size = new System.Drawing.Size(119, 20);
            this.txtConLai.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số tiền trả";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Còn lại";
            // 
            // dateXH
            // 
            this.dateXH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateXH.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateXH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateXH.Location = new System.Drawing.Point(405, 28);
            this.dateXH.Name = "dateXH";
            this.dateXH.Size = new System.Drawing.Size(182, 20);
            this.dateXH.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập phiếu:";
            // 
            // cbTenDaiLi
            // 
            this.cbTenDaiLi.FormattingEnabled = true;
            this.cbTenDaiLi.Location = new System.Drawing.Point(94, 28);
            this.cbTenDaiLi.Name = "cbTenDaiLi";
            this.cbTenDaiLi.Size = new System.Drawing.Size(180, 21);
            this.cbTenDaiLi.TabIndex = 7;
            this.cbTenDaiLi.SelectedIndexChanged += new System.EventHandler(this.cbTenDaiLi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đại lý:";
            // 
            // btTinhTien
            // 
            this.btTinhTien.Image = ((System.Drawing.Image)(resources.GetObject("btTinhTien.Image")));
            this.btTinhTien.Location = new System.Drawing.Point(28, 271);
            this.btTinhTien.Name = "btTinhTien";
            this.btTinhTien.Size = new System.Drawing.Size(97, 64);
            this.btTinhTien.TabIndex = 38;
            this.btTinhTien.Text = "XÓA HÀNG";
            this.btTinhTien.Click += new System.EventHandler(this.btTinhTien_Click_1);
            // 
            // btThanhToan
            // 
            this.btThanhToan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btThanhToan.Image")));
            this.btThanhToan.Location = new System.Drawing.Point(297, 272);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(101, 64);
            this.btThanhToan.TabIndex = 39;
            this.btThanhToan.Text = "THANH TOÁN";
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click_1);
            // 
            // btTimNhanh
            // 
            this.btTimNhanh.Image = ((System.Drawing.Image)(resources.GetObject("btTimNhanh.Image")));
            this.btTimNhanh.Location = new System.Drawing.Point(165, 272);
            this.btTimNhanh.Name = "btTimNhanh";
            this.btTimNhanh.Size = new System.Drawing.Size(100, 64);
            this.btTimNhanh.TabIndex = 40;
            this.btTimNhanh.Text = "TÌM NHANH";
            this.btTimNhanh.Click += new System.EventHandler(this.btTimNhanh_Click);
            // 
            // nUDSoTienTra
            // 
            this.nUDSoTienTra.Location = new System.Drawing.Point(468, 291);
            this.nUDSoTienTra.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nUDSoTienTra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nUDSoTienTra.Name = "nUDSoTienTra";
            this.nUDSoTienTra.Size = new System.Drawing.Size(120, 20);
            this.nUDSoTienTra.TabIndex = 41;
            this.nUDSoTienTra.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // cbMatHang
            // 
            this.cbMatHang.FormattingEnabled = true;
            this.cbMatHang.Location = new System.Drawing.Point(94, 68);
            this.cbMatHang.Name = "cbMatHang";
            this.cbMatHang.Size = new System.Drawing.Size(180, 21);
            this.cbMatHang.TabIndex = 42;
            this.cbMatHang.SelectedIndexChanged += new System.EventHandler(this.cbMatHang_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Mặt hàng:";
            // 
            // nUDSoLuong
            // 
            this.nUDSoLuong.Location = new System.Drawing.Point(405, 68);
            this.nUDSoLuong.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nUDSoLuong.Name = "nUDSoLuong";
            this.nUDSoLuong.Size = new System.Drawing.Size(115, 20);
            this.nUDSoLuong.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Số lượng:";
            // 
            // them
            // 
            this.them.Image = ((System.Drawing.Image)(resources.GetObject("them.Image")));
            this.them.Location = new System.Drawing.Point(549, 60);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(38, 34);
            this.them.TabIndex = 46;
            this.them.Text = "simpleButton1";
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // PhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(623, 362);
            this.Controls.Add(this.them);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nUDSoLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMatHang);
            this.Controls.Add(this.nUDSoTienTra);
            this.Controls.Add(this.btTimNhanh);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.btTinhTien);
            this.Controls.Add(this.dateXH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTenDaiLi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConLai);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.gdXuatHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhieuXuatHang";
            this.Text = "XUẤT HÀNG";
            this.Load += new System.EventHandler(this.Xuất_hàng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdXuatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdViewXuatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoTienTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gdXuatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gdViewXuatHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateXH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTenDaiLi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btTinhTien;
        private DevExpress.XtraEditors.SimpleButton btThanhToan;
        private DevExpress.XtraEditors.SimpleButton btTimNhanh;
        private System.Windows.Forms.NumericUpDown nUDSoTienTra;
        private System.Windows.Forms.ComboBox cbMatHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUDSoLuong;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton them;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}