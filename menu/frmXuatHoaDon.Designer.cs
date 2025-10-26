namespace menu
{
    partial class frmXuatHoaDon
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
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnXemTruoc = new System.Windows.Forms.Button();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.ColumnMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNVLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtETongTien = new DevExpress.XtraEditors.TextEdit();
            this.dteNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNVLap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaHD = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongSoHD = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.ColumnTenPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtETongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNVLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(1131, 455);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 8;
            this.btnXuat.Text = "📄 Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnXemTruoc
            // 
            this.btnXemTruoc.Location = new System.Drawing.Point(977, 455);
            this.btnXemTruoc.Name = "btnXemTruoc";
            this.btnXemTruoc.Size = new System.Drawing.Size(93, 23);
            this.btnXemTruoc.TabIndex = 7;
            this.btnXemTruoc.Text = "👁️ Xem trước ";
            this.btnXemTruoc.UseVisualStyleBackColor = true;
            this.btnXemTruoc.Click += new System.EventHandler(this.btnXemTruoc_Click);
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaHD,
            this.Column1,
            this.ColumnNVLap,
            this.ColumnNgayLap,
            this.ColumnTongTien});
            this.dgvThongTin.Location = new System.Drawing.Point(364, 83);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.RowTemplate.Height = 24;
            this.dgvThongTin.Size = new System.Drawing.Size(842, 330);
            this.dgvThongTin.TabIndex = 6;
            this.dgvThongTin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTin_CellContentClick);
            // 
            // ColumnMaHD
            // 
            this.ColumnMaHD.HeaderText = "Mã hóa đơn";
            this.ColumnMaHD.MinimumWidth = 6;
            this.ColumnMaHD.Name = "ColumnMaHD";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // ColumnNVLap
            // 
            this.ColumnNVLap.HeaderText = "Nhân viên lập";
            this.ColumnNVLap.MinimumWidth = 6;
            this.ColumnNVLap.Name = "ColumnNVLap";
            // 
            // ColumnNgayLap
            // 
            this.ColumnNgayLap.HeaderText = "Ngày lập";
            this.ColumnNgayLap.MinimumWidth = 6;
            this.ColumnNgayLap.Name = "ColumnNgayLap";
            // 
            // ColumnTongTien
            // 
            this.ColumnTongTien.HeaderText = "Tổng tiền";
            this.ColumnTongTien.MinimumWidth = 6;
            this.ColumnTongTien.Name = "ColumnTongTien";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtETongTien);
            this.groupControl1.Controls.Add(this.dteNgayLap);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtNVLap);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtMaKH);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtMaHD);
            this.groupControl1.Location = new System.Drawing.Point(32, 83);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(314, 330);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin hóa đơn";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(72, 281);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Tổng tiền";
            // 
            // txtETongTien
            // 
            this.txtETongTien.Location = new System.Drawing.Point(161, 278);
            this.txtETongTien.Name = "txtETongTien";
            this.txtETongTien.Size = new System.Drawing.Size(125, 22);
            this.txtETongTien.TabIndex = 8;
            this.txtETongTien.EditValueChanged += new System.EventHandler(this.txtETongTien_EditValueChanged);
            // 
            // dteNgayLap
            // 
            this.dteNgayLap.EditValue = null;
            this.dteNgayLap.Location = new System.Drawing.Point(161, 223);
            this.dteNgayLap.Name = "dteNgayLap";
            this.dteNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayLap.Size = new System.Drawing.Size(125, 22);
            this.dteNgayLap.TabIndex = 2;
            this.dteNgayLap.EditValueChanged += new System.EventHandler(this.dteNgayLap_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(72, 227);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Ngày lập";
            // 
            // txtNVLap
            // 
            this.txtNVLap.Location = new System.Drawing.Point(161, 165);
            this.txtNVLap.Name = "txtNVLap";
            this.txtNVLap.Size = new System.Drawing.Size(125, 22);
            this.txtNVLap.TabIndex = 6;
            this.txtNVLap.EditValueChanged += new System.EventHandler(this.txtNVLap_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(72, 168);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nhân viên lập";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(161, 106);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(125, 22);
            this.txtMaKH.TabIndex = 4;
            this.txtMaKH.EditValueChanged += new System.EventHandler(this.txtMaKH_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(72, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mã khách hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(72, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(161, 46);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(125, 22);
            this.txtMaHD.TabIndex = 0;
            this.txtMaHD.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(502, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hóa đơn mua hàng";
            // 
            // lblTongSoHD
            // 
            this.lblTongSoHD.AutoSize = true;
            this.lblTongSoHD.Location = new System.Drawing.Point(370, 432);
            this.lblTongSoHD.Name = "lblTongSoHD";
            this.lblTongSoHD.Size = new System.Drawing.Size(0, 16);
            this.lblTongSoHD.TabIndex = 10;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTenPT,
            this.ColumnSoLuong,
            this.ColumnDonGia,
            this.ColumnThanhTien});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(364, 83);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(842, 330);
            this.dgvChiTietHoaDon.TabIndex = 11;
            // 
            // ColumnTenPT
            // 
            this.ColumnTenPT.HeaderText = "Tên phụ tùng";
            this.ColumnTenPT.MinimumWidth = 6;
            this.ColumnTenPT.Name = "ColumnTenPT";
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.HeaderText = "Số lượng";
            this.ColumnSoLuong.MinimumWidth = 6;
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            // 
            // ColumnDonGia
            // 
            this.ColumnDonGia.HeaderText = "Đơn giá";
            this.ColumnDonGia.MinimumWidth = 6;
            this.ColumnDonGia.Name = "ColumnDonGia";
            // 
            // ColumnThanhTien
            // 
            this.ColumnThanhTien.HeaderText = "Thành tiền";
            this.ColumnThanhTien.MinimumWidth = 6;
            this.ColumnThanhTien.Name = "ColumnThanhTien";
            // 
            // frmXuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 547);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Controls.Add(this.lblTongSoHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnXemTruoc);
            this.Controls.Add(this.dgvThongTin);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmXuatHoaDon";
            this.Text = "frmXuatHoaDon";
            this.Load += new System.EventHandler(this.frmXuatHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtETongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNVLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnXemTruoc;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNVLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTongTien;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtETongTien;
        private DevExpress.XtraEditors.DateEdit dteNgayLap;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNVLap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongSoHD;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnThanhTien;
    }
}