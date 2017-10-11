namespace QuanLiDaiLi
{
    partial class NhapLoaiDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapLoaiDL));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoaiDL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbNo = new System.Windows.Forms.NumericUpDown();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nbNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại đại lý:";
            // 
            // txtTenLoaiDL
            // 
            this.txtTenLoaiDL.Location = new System.Drawing.Point(146, 26);
            this.txtTenLoaiDL.Name = "txtTenLoaiDL";
            this.txtTenLoaiDL.Size = new System.Drawing.Size(115, 20);
            this.txtTenLoaiDL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nợ tối đa với loại đại lý:";
            // 
            // nbNo
            // 
            this.nbNo.Location = new System.Drawing.Point(146, 69);
            this.nbNo.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nbNo.Name = "nbNo";
            this.nbNo.Size = new System.Drawing.Size(115, 20);
            this.nbNo.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(88, 99);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(98, 40);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "XÁC NHẬN";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // NhapLoaiDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.nbNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenLoaiDL);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapLoaiDL";
            this.Text = "NHẬP LOẠI ĐẠI LÝ";
            this.Load += new System.EventHandler(this.NhapLoaiDL_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NhapLoaiDL_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nbNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLoaiDL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbNo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}