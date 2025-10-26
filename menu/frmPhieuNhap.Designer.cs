namespace menu
{
    partial class frmPhieuNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDonDatHang = new System.Windows.Forms.DataGridView();
            this.phutung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTenPhuTung = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(90, 30);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(178, 27);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian:";
            // 
            // dgvDonDatHang
            // 
            this.dgvDonDatHang.AllowUserToAddRows = false;
            this.dgvDonDatHang.AllowUserToDeleteRows = false;
            this.dgvDonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phutung,
            this.soluong,
            this.dongia});
            this.dgvDonDatHang.Location = new System.Drawing.Point(12, 125);
            this.dgvDonDatHang.Name = "dgvDonDatHang";
            this.dgvDonDatHang.ReadOnly = true;
            this.dgvDonDatHang.RowHeadersWidth = 51;
            this.dgvDonDatHang.RowTemplate.Height = 24;
            this.dgvDonDatHang.Size = new System.Drawing.Size(481, 419);
            this.dgvDonDatHang.TabIndex = 4;
            // 
            // phutung
            // 
            this.phutung.FillWeight = 146.5241F;
            this.phutung.HeaderText = "Phụ tùng";
            this.phutung.MinimumWidth = 6;
            this.phutung.Name = "phutung";
            this.phutung.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.FillWeight = 53.47594F;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.EditValue = null;
            this.dtpNgayNhap.Location = new System.Drawing.Point(116, 89);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Properties.Appearance.Options.UseFont = true;
            this.dtpNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayNhap.Size = new System.Drawing.Size(339, 28);
            this.dtpNgayNhap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(326, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đơn đặt hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.cmbNhaCungCap);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.lblNhaCungCap);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbTenPhuTung);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(523, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 420);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phụ tùng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.FormattingEnabled = true;
            this.txtDonGia.Location = new System.Drawing.Point(99, 269);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(169, 28);
            this.txtDonGia.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Đơn giá:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(22, 378);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 36);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(153, 378);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 36);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu phiếu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhaCungCap.Location = new System.Drawing.Point(18, 98);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(250, 28);
            this.cmbNhaCungCap.TabIndex = 14;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(153, 323);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 36);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCungCap.Location = new System.Drawing.Point(18, 75);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(117, 20);
            this.lblNhaCungCap.TabIndex = 13;
            this.lblNhaCungCap.Text = "Nhà cung cấp:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 323);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 36);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(99, 220);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(169, 27);
            this.txtSoLuong.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số lượng:";
            // 
            // cmbTenPhuTung
            // 
            this.cmbTenPhuTung.FormattingEnabled = true;
            this.cmbTenPhuTung.Location = new System.Drawing.Point(20, 168);
            this.cmbTenPhuTung.Name = "cmbTenPhuTung";
            this.cmbTenPhuTung.Size = new System.Drawing.Size(250, 28);
            this.cmbTenPhuTung.TabIndex = 16;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(18, 145);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(111, 20);
            this.lblTrangThai.TabIndex = 15;
            this.lblTrangThai.Text = "Tên phụ tùng:";
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDonDatHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayNhap);
            this.Name = "frmPhieuNhap";
            this.Text = "Đơn đặt hàng";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNhap.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtpNgayNhap;
        private System.Windows.Forms.DataGridView dgvDonDatHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTenPhuTung;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn phutung;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.ComboBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}