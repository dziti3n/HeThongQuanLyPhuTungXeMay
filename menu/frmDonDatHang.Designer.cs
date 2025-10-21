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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewAltRowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTongDon = new System.Windows.Forms.Label();

            this.dgvDonDatHang = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanhDong = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaDon = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();

            // 
            // frmDonDatHang (form settings)
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text = "QUẢN LÝ ĐƠN ĐẶT HÀNG";

            // =========================
            // Toolbar buttons & search
            // =========================
            // btnThem
            this.btnThem.Location = new System.Drawing.Point(12, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(108, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(204, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;

            // btnXuatExcel
            this.btnXuatExcel.Location = new System.Drawing.Point(300, 12);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(110, 30);
            this.btnXuatExcel.TabIndex = 3;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;

            // txtTimKiem
            this.txtTimKiem.Location = new System.Drawing.Point(620, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(180, 23);
            this.txtTimKiem.TabIndex = 4;
            // (no runtime placeholder logic here — add in code-behind if desired)
            this.txtTimKiem.Text = "";

            // btnTimKiem
            this.btnTimKiem.Location = new System.Drawing.Point(806, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(82, 30);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;

            // lblTongDon
            this.lblTongDon.AutoSize = true;
            this.lblTongDon.Location = new System.Drawing.Point(760, 468);
            this.lblTongDon.Name = "lblTongDon";
            this.lblTongDon.Size = new System.Drawing.Size(120, 15);
            this.lblTongDon.TabIndex = 6;
            this.lblTongDon.Text = "Tổng số đơn: 0";

            // =========================
            // DataGridView dgvDonDatHang
            // =========================
            this.dgvDonDatHang.Location = new System.Drawing.Point(12, 56);
            this.dgvDonDatHang.Name = "dgvDonDatHang";
            this.dgvDonDatHang.ReadOnly = true;
            this.dgvDonDatHang.AllowUserToAddRows = false;
            this.dgvDonDatHang.AllowUserToDeleteRows = false;
            this.dgvDonDatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonDatHang.RowHeadersVisible = false;
            this.dgvDonDatHang.Size = new System.Drawing.Size(580, 400);
            this.dgvDonDatHang.TabIndex = 7;
            this.dgvDonDatHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // header style
            dataGridViewHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHeaderStyle.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            dataGridViewHeaderStyle.ForeColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvDonDatHang.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle;
            this.dgvDonDatHang.EnableHeadersVisualStyles = false;

            // alternating rows style
            dataGridViewAltRowStyle.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.dgvDonDatHang.AlternatingRowsDefaultCellStyle = dataGridViewAltRowStyle;

            // columns
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.FillWeight = 35F;

            this.MaDonHang.HeaderText = "Mã đơn";
            this.MaDonHang.Name = "MaDonHang";
            this.MaDonHang.ReadOnly = true;

            this.TenKhachHang.HeaderText = "Khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;

            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.ReadOnly = true;

            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;

            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;

            this.HanhDong.HeaderText = "Hành động";
            this.HanhDong.Name = "HanhDong";
            this.HanhDong.ReadOnly = true;

            this.dgvDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.stt,
                this.MaDonHang,
                this.TenKhachHang,
                this.NgayDat,
                this.TongTien,
                this.TrangThai,
                this.HanhDong
            });

            // =========================
            // GroupBox Thông tin đơn hàng (right side)
            // =========================
            this.grbThongTin.Location = new System.Drawing.Point(602, 56);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(286, 400);
            this.grbThongTin.TabIndex = 8;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin đơn hàng";

            // lblMaDon + txtMaDonHang
            this.lblMaDon.AutoSize = true;
            this.lblMaDon.Location = new System.Drawing.Point(16, 30);
            this.lblMaDon.Name = "lblMaDon";
            this.lblMaDon.Size = new System.Drawing.Size(64, 15);
            this.lblMaDon.Text = "Mã đơn hàng:";

            this.txtMaDonHang.Location = new System.Drawing.Point(16, 48);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(250, 23);
            this.txtMaDonHang.ReadOnly = true;

            // lblKhachHang + cboKhachHang
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(16, 85);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(79, 15);
            this.lblKhachHang.Text = "Khách hàng:";

            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Location = new System.Drawing.Point(16, 103);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(250, 23);

            // lblNgayDat + dtpNgayDat
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(16, 140);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(60, 15);
            this.lblNgayDat.Text = "Ngày đặt:";

            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDat.Location = new System.Drawing.Point(16, 158);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(250, 23);

            // lblTongTien + txtTongTien
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(16, 195);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(61, 15);
            this.lblTongTien.Text = "Tổng tiền:";

            this.txtTongTien.Location = new System.Drawing.Point(16, 213);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(250, 23);
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // lblTrangThai + cboTrangThai
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(16, 250);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(63, 15);
            this.lblTrangThai.Text = "Trạng thái:";

            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Location = new System.Drawing.Point(16, 268);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(250, 23);
            this.cboTrangThai.Items.AddRange(new object[] {
                "Đang xử lý",
                "Đã xác nhận",
                "Đã giao",
                "Đã hủy"
            });

            // btnLuu
            this.btnLuu.Location = new System.Drawing.Point(40, 320);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 32);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;

            // btnHuy
            this.btnHuy.Location = new System.Drawing.Point(160, 320);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 32);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;

            // add controls to groupbox
            this.grbThongTin.Controls.Add(this.lblMaDon);
            this.grbThongTin.Controls.Add(this.txtMaDonHang);
            this.grbThongTin.Controls.Add(this.lblKhachHang);
            this.grbThongTin.Controls.Add(this.cboKhachHang);
            this.grbThongTin.Controls.Add(this.lblNgayDat);
            this.grbThongTin.Controls.Add(this.dtpNgayDat);
            this.grbThongTin.Controls.Add(this.lblTongTien);
            this.grbThongTin.Controls.Add(this.txtTongTien);
            this.grbThongTin.Controls.Add(this.lblTrangThai);
            this.grbThongTin.Controls.Add(this.cboTrangThai);
            this.grbThongTin.Controls.Add(this.btnLuu);
            this.grbThongTin.Controls.Add(this.btnHuy);

            // =========================
            // Add all controls to form
            // =========================
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvDonDatHang);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lblTongDon);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // toolbar controls
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTongDon;

        // data grid
        private System.Windows.Forms.DataGridView dgvDonDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanhDong;

        // groupbox controls (right)
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label lblMaDon;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
