namespace menu
{
    partial class frmDonDatHang
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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTongDon = new System.Windows.Forms.Label();
            this.dgvDonDatHang = new System.Windows.Forms.DataGridView();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaDon = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphutung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(43, 404);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm/sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(198, 404);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // lblTongDon
            // 
            this.lblTongDon.AutoSize = true;
            this.lblTongDon.Location = new System.Drawing.Point(478, 485);
            this.lblTongDon.Name = "lblTongDon";
            this.lblTongDon.Size = new System.Drawing.Size(95, 20);
            this.lblTongDon.TabIndex = 6;
            this.lblTongDon.Text = "Tổng số đơn:";
            // 
            // dgvDonDatHang
            // 
            this.dgvDonDatHang.AllowUserToAddRows = false;
            this.dgvDonDatHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvDonDatHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvDonDatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonDatHang.ColumnHeadersHeight = 29;
            this.dgvDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.MaDonHang,
            this.tenphutung,
            this.soluong,
            this.NgayDat,
            this.TongTien});
            this.dgvDonDatHang.EnableHeadersVisualStyles = false;
            this.dgvDonDatHang.Location = new System.Drawing.Point(41, 69);
            this.dgvDonDatHang.Name = "dgvDonDatHang";
            this.dgvDonDatHang.ReadOnly = true;
            this.dgvDonDatHang.RowHeadersVisible = false;
            this.dgvDonDatHang.RowHeadersWidth = 51;
            this.dgvDonDatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonDatHang.Size = new System.Drawing.Size(580, 400);
            this.dgvDonDatHang.TabIndex = 7;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnThem);
            this.grbThongTin.Controls.Add(this.btnXoa);
            this.grbThongTin.Controls.Add(this.comboBox1);
            this.grbThongTin.Controls.Add(this.lblMaDon);
            this.grbThongTin.Controls.Add(this.txtMaDonHang);
            this.grbThongTin.Controls.Add(this.lblNhaCungCap);
            this.grbThongTin.Controls.Add(this.cboKhachHang);
            this.grbThongTin.Controls.Add(this.lblTongTien);
            this.grbThongTin.Controls.Add(this.lblNgayDat);
            this.grbThongTin.Controls.Add(this.dtpNgayDat);
            this.grbThongTin.Controls.Add(this.txtTongTien);
            this.grbThongTin.Controls.Add(this.lblTrangThai);
            this.grbThongTin.Location = new System.Drawing.Point(658, 39);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(335, 466);
            this.grbThongTin.TabIndex = 8;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin nhập hàng";
            // 
            // lblMaDon
            // 
            this.lblMaDon.AutoSize = true;
            this.lblMaDon.Location = new System.Drawing.Point(34, 30);
            this.lblMaDon.Name = "lblMaDon";
            this.lblMaDon.Size = new System.Drawing.Size(100, 20);
            this.lblMaDon.TabIndex = 0;
            this.lblMaDon.Text = "Mã đơn hàng:";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(38, 53);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.ReadOnly = true;
            this.txtMaDonHang.Size = new System.Drawing.Size(250, 27);
            this.txtMaDonHang.TabIndex = 1;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Location = new System.Drawing.Point(34, 85);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(103, 20);
            this.lblNhaCungCap.TabIndex = 2;
            this.lblNhaCungCap.Text = "Nhà cung cấp:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Location = new System.Drawing.Point(38, 108);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(250, 28);
            this.cboKhachHang.TabIndex = 3;
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(39, 243);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(73, 20);
            this.lblNgayDat.TabIndex = 4;
            this.lblNgayDat.Text = "Ngày đặt:";
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDat.Location = new System.Drawing.Point(38, 256);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(250, 27);
            this.dtpNgayDat.TabIndex = 5;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(39, 328);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(75, 20);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(120, 325);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(168, 27);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(39, 157);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(98, 20);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Tên phụ tùng:";
            // 
            // stt
            // 
            this.stt.FillWeight = 35F;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // MaDonHang
            // 
            this.MaDonHang.HeaderText = "Mã đơn";
            this.MaDonHang.MinimumWidth = 6;
            this.MaDonHang.Name = "MaDonHang";
            this.MaDonHang.ReadOnly = true;
            // 
            // tenphutung
            // 
            this.tenphutung.HeaderText = "Tên phụ tùng";
            this.tenphutung.MinimumWidth = 6;
            this.tenphutung.Name = "tenphutung";
            this.tenphutung.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // NgayDat
            // 
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(579, 481);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 27);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(254, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Phiếu nhập";
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvDonDatHang);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lblTongDon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐƠN ĐẶT HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // toolbar controls
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTongDon;

        // data grid
        private System.Windows.Forms.DataGridView dgvDonDatHang;

        // groupbox controls (right)
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label lblMaDon;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphutung;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
