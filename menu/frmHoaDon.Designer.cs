namespace menu
{
    partial class frmHoaDon
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
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.grCtrlThongtTinKH = new DevExpress.XtraEditors.GroupControl();
            this.btnChonKH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.grCtrlThongTinSP = new DevExpress.XtraEditors.GroupControl();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.btnChonSP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.txtSLBan = new DevExpress.XtraEditors.TextEdit();
            this.SLTon = new DevExpress.XtraEditors.TextEdit();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSP = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSP = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvThongTinSP = new System.Windows.Forms.DataGridView();
            this.ColumnMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSLBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEMaHoaDon = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.dtENgayLap = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlThongtTinKH)).BeginInit();
            this.grCtrlThongtTinKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlThongTinSP)).BeginInit();
            this.grCtrlThongTinSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMaHoaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtENgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtENgayLap.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(83, 43);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(136, 22);
            this.txtMaKH.TabIndex = 0;
            this.txtMaKH.EditValueChanged += new System.EventHandler(this.txtMaKH_EditValueChanged);
            // 
            // grCtrlThongtTinKH
            // 
            this.grCtrlThongtTinKH.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grCtrlThongtTinKH.Appearance.Options.UseBackColor = true;
            this.grCtrlThongtTinKH.Controls.Add(this.btnChonKH);
            this.grCtrlThongtTinKH.Controls.Add(this.label2);
            this.grCtrlThongtTinKH.Controls.Add(this.txtTenKH);
            this.grCtrlThongtTinKH.Controls.Add(this.label1);
            this.grCtrlThongtTinKH.Controls.Add(this.txtMaKH);
            this.grCtrlThongtTinKH.Location = new System.Drawing.Point(12, 88);
            this.grCtrlThongtTinKH.Name = "grCtrlThongtTinKH";
            this.grCtrlThongtTinKH.Size = new System.Drawing.Size(420, 137);
            this.grCtrlThongtTinKH.TabIndex = 1;
            this.grCtrlThongtTinKH.Text = "Thông tin khách hàng";
            // 
            // btnChonKH
            // 
            this.btnChonKH.Location = new System.Drawing.Point(269, 67);
            this.btnChonKH.Name = "btnChonKH";
            this.btnChonKH.Size = new System.Drawing.Size(75, 23);
            this.btnChonKH.TabIndex = 2;
            this.btnChonKH.Text = "Chọn KH";
            this.btnChonKH.UseVisualStyleBackColor = true;
            this.btnChonKH.Click += new System.EventHandler(this.btnChonKH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên KH";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(83, 85);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(136, 22);
            this.txtTenKH.TabIndex = 3;
            this.txtTenKH.EditValueChanged += new System.EventHandler(this.txtTenKH_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã KH";
            // 
            // grCtrlThongTinSP
            // 
            this.grCtrlThongTinSP.Controls.Add(this.btnThemVaoGio);
            this.grCtrlThongTinSP.Controls.Add(this.btnChonSP);
            this.grCtrlThongTinSP.Controls.Add(this.label8);
            this.grCtrlThongTinSP.Controls.Add(this.label7);
            this.grCtrlThongTinSP.Controls.Add(this.btnHuy);
            this.grCtrlThongTinSP.Controls.Add(this.label6);
            this.grCtrlThongTinSP.Controls.Add(this.label5);
            this.grCtrlThongTinSP.Controls.Add(this.label4);
            this.grCtrlThongTinSP.Controls.Add(this.txtThanhTien);
            this.grCtrlThongTinSP.Controls.Add(this.txtSLBan);
            this.grCtrlThongTinSP.Controls.Add(this.SLTon);
            this.grCtrlThongTinSP.Controls.Add(this.txtDonGia);
            this.grCtrlThongTinSP.Controls.Add(this.txtTenSP);
            this.grCtrlThongTinSP.Controls.Add(this.txtMaSP);
            this.grCtrlThongTinSP.Controls.Add(this.label3);
            this.grCtrlThongTinSP.Location = new System.Drawing.Point(12, 231);
            this.grCtrlThongTinSP.Name = "grCtrlThongTinSP";
            this.grCtrlThongTinSP.Size = new System.Drawing.Size(420, 290);
            this.grCtrlThongTinSP.TabIndex = 2;
            this.grCtrlThongTinSP.Text = "Thông tin sản phẩm";
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.Location = new System.Drawing.Point(288, 120);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(106, 23);
            this.btnThemVaoGio.TabIndex = 16;
            this.btnThemVaoGio.Text = "Thêm vào giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = true;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // btnChonSP
            // 
            this.btnChonSP.Location = new System.Drawing.Point(288, 91);
            this.btnChonSP.Name = "btnChonSP";
            this.btnChonSP.Size = new System.Drawing.Size(106, 23);
            this.btnChonSP.TabIndex = 15;
            this.btnChonSP.Text = "Chọn SP";
            this.btnChonSP.UseVisualStyleBackColor = true;
            this.btnChonSP.Click += new System.EventHandler(this.btnChonSP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Thành tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số lượng bán";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(288, 149);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số lượng tồn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên SP";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(114, 232);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(136, 22);
            this.txtThanhTien.TabIndex = 9;
            this.txtThanhTien.EditValueChanged += new System.EventHandler(this.txtThanhTien_EditValueChanged);
            // 
            // txtSLBan
            // 
            this.txtSLBan.Location = new System.Drawing.Point(349, 52);
            this.txtSLBan.Name = "txtSLBan";
            this.txtSLBan.Size = new System.Drawing.Size(45, 22);
            this.txtSLBan.TabIndex = 8;
            this.txtSLBan.EditValueChanged += new System.EventHandler(this.textEditSLBan_EditValueChanged);
            // 
            // SLTon
            // 
            this.SLTon.Location = new System.Drawing.Point(113, 186);
            this.SLTon.Name = "SLTon";
            this.SLTon.Size = new System.Drawing.Size(136, 22);
            this.SLTon.TabIndex = 7;
            this.SLTon.EditValueChanged += new System.EventHandler(this.SLTon_EditValueChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(114, 141);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(136, 22);
            this.txtDonGia.TabIndex = 6;
            this.txtDonGia.EditValueChanged += new System.EventHandler(this.txtDonGia_EditValueChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(114, 95);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(136, 22);
            this.txtTenSP.TabIndex = 5;
            this.txtTenSP.EditValueChanged += new System.EventHandler(this.txtTenSP_EditValueChanged);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(114, 52);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(136, 22);
            this.txtMaSP.TabIndex = 4;
            this.txtMaSP.EditValueChanged += new System.EventHandler(this.txtMaSP_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã SP";
            // 
            // dgvThongTinSP
            // 
            this.dgvThongTinSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaSP,
            this.ColumnTenSP,
            this.ColumnDonGia,
            this.ColumnSLBan,
            this.ColumnThanhTien});
            this.dgvThongTinSP.Location = new System.Drawing.Point(455, 88);
            this.dgvThongTinSP.Name = "dgvThongTinSP";
            this.dgvThongTinSP.RowHeadersWidth = 51;
            this.dgvThongTinSP.RowTemplate.Height = 24;
            this.dgvThongTinSP.Size = new System.Drawing.Size(844, 537);
            this.dgvThongTinSP.TabIndex = 3;
            this.dgvThongTinSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinSP_CellContentClick);
            // 
            // ColumnMaSP
            // 
            this.ColumnMaSP.HeaderText = "Mã SP";
            this.ColumnMaSP.MinimumWidth = 6;
            this.ColumnMaSP.Name = "ColumnMaSP";
            // 
            // ColumnTenSP
            // 
            this.ColumnTenSP.HeaderText = "Tên SP";
            this.ColumnTenSP.MinimumWidth = 6;
            this.ColumnTenSP.Name = "ColumnTenSP";
            // 
            // ColumnDonGia
            // 
            this.ColumnDonGia.HeaderText = "Đơn giá";
            this.ColumnDonGia.MinimumWidth = 6;
            this.ColumnDonGia.Name = "ColumnDonGia";
            // 
            // ColumnSLBan
            // 
            this.ColumnSLBan.HeaderText = "SL bán";
            this.ColumnSLBan.MinimumWidth = 6;
            this.ColumnSLBan.Name = "ColumnSLBan";
            // 
            // ColumnThanhTien
            // 
            this.ColumnThanhTien.HeaderText = "Thành tiền";
            this.ColumnThanhTien.MinimumWidth = 6;
            this.ColumnThanhTien.Name = "ColumnThanhTien";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1001, 649);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tổng tiền phải thanh toán";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(1163, 646);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(136, 22);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.EditValueChanged += new System.EventHandler(this.txtTongTien_EditValueChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(73, 571);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(302, 54);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mã hóa đơn";
            // 
            // txtEMaHoaDon
            // 
            this.txtEMaHoaDon.Location = new System.Drawing.Point(109, 36);
            this.txtEMaHoaDon.Name = "txtEMaHoaDon";
            this.txtEMaHoaDon.Size = new System.Drawing.Size(136, 22);
            this.txtEMaHoaDon.TabIndex = 11;
            this.txtEMaHoaDon.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Ngày lập";
            // 
            // dtENgayLap
            // 
            this.dtENgayLap.EditValue = null;
            this.dtENgayLap.Location = new System.Drawing.Point(339, 36);
            this.dtENgayLap.Name = "dtENgayLap";
            this.dtENgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtENgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtENgayLap.Size = new System.Drawing.Size(125, 22);
            this.dtENgayLap.TabIndex = 13;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 712);
            this.Controls.Add(this.dtENgayLap);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEMaHoaDon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvThongTinSP);
            this.Controls.Add(this.grCtrlThongTinSP);
            this.Controls.Add(this.grCtrlThongtTinKH);
            this.Name = "frmHoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlThongtTinKH)).EndInit();
            this.grCtrlThongtTinKH.ResumeLayout(false);
            this.grCtrlThongtTinKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlThongTinSP)).EndInit();
            this.grCtrlThongTinSP.ResumeLayout(false);
            this.grCtrlThongTinSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMaHoaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtENgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtENgayLap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.GroupControl grCtrlThongtTinKH;
        private System.Windows.Forms.Button btnChonKH;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl grCtrlThongTinSP;
        private DevExpress.XtraEditors.TextEdit txtSLBan;
        private DevExpress.XtraEditors.TextEdit SLTon;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtTenSP;
        private DevExpress.XtraEditors.TextEdit txtMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtThanhTien;
        private System.Windows.Forms.Button btnChonSP;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.DataGridView dgvThongTinSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSLBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnThanhTien;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtEMaHoaDon;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.DateEdit dtENgayLap;
    }
}