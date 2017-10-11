namespace QuanLiDaiLi
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.strMnPhieuThuTien = new System.Windows.Forms.ToolStripMenuItem();
            this.trMnPhieuXuatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.trMnBaoCaoDoanhSo = new System.Windows.Forms.ToolStripMenuItem();
            this.strMnBaoCaoCongNo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cbQuan = new System.Windows.Forms.ComboBox();
            this.dtNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.cbDaiLi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.ThongTin = new System.Windows.Forms.GroupBox();
            this.gdDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btthem = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.toolStrip1.SuspendLayout();
            this.ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSplitButton2
            // 
            resources.ApplyResources(this.toolStripSplitButton2, "toolStripSplitButton2");
            this.toolStripSplitButton2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strMnPhieuThuTien,
            this.trMnPhieuXuatHang});
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            // 
            // strMnPhieuThuTien
            // 
            resources.ApplyResources(this.strMnPhieuThuTien, "strMnPhieuThuTien");
            this.strMnPhieuThuTien.Name = "strMnPhieuThuTien";
            this.strMnPhieuThuTien.Click += new System.EventHandler(this.strMnPhieuThuTien_Click);
            // 
            // trMnPhieuXuatHang
            // 
            resources.ApplyResources(this.trMnPhieuXuatHang, "trMnPhieuXuatHang");
            this.trMnPhieuXuatHang.Name = "trMnPhieuXuatHang";
            this.trMnPhieuXuatHang.Click += new System.EventHandler(this.trMnPhieuXuatHang_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripSplitButton3
            // 
            resources.ApplyResources(this.toolStripSplitButton3, "toolStripSplitButton3");
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trMnBaoCaoDoanhSo,
            this.strMnBaoCaoCongNo});
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            // 
            // trMnBaoCaoDoanhSo
            // 
            resources.ApplyResources(this.trMnBaoCaoDoanhSo, "trMnBaoCaoDoanhSo");
            this.trMnBaoCaoDoanhSo.Name = "trMnBaoCaoDoanhSo";
            this.trMnBaoCaoDoanhSo.Click += new System.EventHandler(this.trMnBaoCaoDoanhSo_Click);
            // 
            // strMnBaoCaoCongNo
            // 
            resources.ApplyResources(this.strMnBaoCaoCongNo, "strMnBaoCaoCongNo");
            this.strMnBaoCaoCongNo.Name = "strMnBaoCaoCongNo";
            this.strMnBaoCaoCongNo.Click += new System.EventHandler(this.strMnBaoCaoCongNo_Click);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton2,
            this.toolStripSeparator2,
            this.toolStripSplitButton3,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // cbQuan
            // 
            resources.ApplyResources(this.cbQuan, "cbQuan");
            this.cbQuan.FormattingEnabled = true;
            this.cbQuan.Name = "cbQuan";
            this.cbQuan.SelectedIndexChanged += new System.EventHandler(this.cbQuan_SelectedIndexChanged);
            // 
            // dtNgayTiepNhan
            // 
            resources.ApplyResources(this.dtNgayTiepNhan, "dtNgayTiepNhan");
            this.dtNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTiepNhan.Name = "dtNgayTiepNhan";
            // 
            // cbDaiLi
            // 
            resources.ApplyResources(this.cbDaiLi, "cbDaiLi");
            this.cbDaiLi.FormattingEnabled = true;
            this.cbDaiLi.Name = "cbDaiLi";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtDiaChi
            // 
            resources.ApplyResources(this.txtDiaChi, "txtDiaChi");
            this.txtDiaChi.Name = "txtDiaChi";
            // 
            // txtSDT
            // 
            resources.ApplyResources(this.txtSDT, "txtSDT");
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtTen
            // 
            resources.ApplyResources(this.txtTen, "txtTen");
            this.txtTen.Name = "txtTen";
            // 
            // ThongTin
            // 
            resources.ApplyResources(this.ThongTin, "ThongTin");
            this.ThongTin.Controls.Add(this.cbQuan);
            this.ThongTin.Controls.Add(this.dtNgayTiepNhan);
            this.ThongTin.Controls.Add(this.cbDaiLi);
            this.ThongTin.Controls.Add(this.label6);
            this.ThongTin.Controls.Add(this.label5);
            this.ThongTin.Controls.Add(this.label4);
            this.ThongTin.Controls.Add(this.label3);
            this.ThongTin.Controls.Add(this.label2);
            this.ThongTin.Controls.Add(this.label1);
            this.ThongTin.Controls.Add(this.txtDiaChi);
            this.ThongTin.Controls.Add(this.txtSDT);
            this.ThongTin.Controls.Add(this.txtTen);
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.TabStop = false;
            // 
            // gdDanhSach
            // 
            resources.ApplyResources(this.gdDanhSach, "gdDanhSach");
            this.gdDanhSach.EmbeddedNavigator.AccessibleDescription = resources.GetString("gdDanhSach.EmbeddedNavigator.AccessibleDescription");
            this.gdDanhSach.EmbeddedNavigator.AccessibleName = resources.GetString("gdDanhSach.EmbeddedNavigator.AccessibleName");
            this.gdDanhSach.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gdDanhSach.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gdDanhSach.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gdDanhSach.EmbeddedNavigator.Anchor")));
            this.gdDanhSach.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gdDanhSach.EmbeddedNavigator.BackgroundImage")));
            this.gdDanhSach.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gdDanhSach.EmbeddedNavigator.BackgroundImageLayout")));
            this.gdDanhSach.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gdDanhSach.EmbeddedNavigator.ImeMode")));
            this.gdDanhSach.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gdDanhSach.EmbeddedNavigator.MaximumSize")));
            this.gdDanhSach.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gdDanhSach.EmbeddedNavigator.TextLocation")));
            this.gdDanhSach.EmbeddedNavigator.ToolTip = resources.GetString("gdDanhSach.EmbeddedNavigator.ToolTip");
            this.gdDanhSach.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gdDanhSach.EmbeddedNavigator.ToolTipIconType")));
            this.gdDanhSach.EmbeddedNavigator.ToolTipTitle = resources.GetString("gdDanhSach.EmbeddedNavigator.ToolTipTitle");
            this.gdDanhSach.MainView = this.gridView1;
            this.gdDanhSach.Name = "gdDanhSach";
            this.gdDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gdDanhSach;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3"))});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "TenDaiLi";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.FieldName = "LoaiDaiLi";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            resources.ApplyResources(this.gridColumn3, "gridColumn3");
            this.gridColumn3.FieldName = "TenQuan";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            resources.ApplyResources(this.gridColumn4, "gridColumn4");
            this.gridColumn4.FieldName = "NoCuaDaiLi";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // btthem
            // 
            resources.ApplyResources(this.btthem, "btthem");
            this.btthem.Image = ((System.Drawing.Image)(resources.GetObject("btthem.Image")));
            this.btthem.Name = "btthem";
            this.btthem.Click += new System.EventHandler(this.them_Click_1);
            // 
            // btXoa
            // 
            resources.ApplyResources(this.btXoa, "btXoa");
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Name = "btXoa";
            this.btXoa.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btThoat
            // 
            resources.ApplyResources(this.btThoat, "btThoat");
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.Name = "btThoat";
            this.btThoat.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // mainform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.gdDanhSach);
            this.Controls.Add(this.ThongTin);
            this.Controls.Add(this.toolStrip1);
            this.Name = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ThongTin.ResumeLayout(false);
            this.ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem strMnPhieuThuTien;
        private System.Windows.Forms.ToolStripMenuItem trMnPhieuXuatHang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem trMnBaoCaoDoanhSo;
        private System.Windows.Forms.ToolStripMenuItem strMnBaoCaoCongNo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cbQuan;
        private System.Windows.Forms.DateTimePicker dtNgayTiepNhan;
        private System.Windows.Forms.ComboBox cbDaiLi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.GroupBox ThongTin;
        private DevExpress.XtraGrid.GridControl gdDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.SimpleButton btthem;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThoat;
    }
}