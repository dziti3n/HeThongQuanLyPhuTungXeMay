namespace menu
{
    partial class frmSanPham
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
            this.grbThongTinSP = new System.Windows.Forms.GroupBox();
            this.cmbNCC = new System.Windows.Forms.ComboBox();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.lblTenPT = new System.Windows.Forms.Label();
            this.txtTenPT = new System.Windows.Forms.TextBox();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.cmbDonViTinh = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblLoaiPT = new System.Windows.Forms.Label();
            this.cmbLoaiPT = new System.Windows.Forms.ComboBox();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvPhuTung = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTinSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinSP
            // 
            this.grbThongTinSP.Controls.Add(this.label1);
            this.grbThongTinSP.Controls.Add(this.cmbNCC);
            this.grbThongTinSP.Controls.Add(this.lblMaPT);
            this.grbThongTinSP.Controls.Add(this.txtMaPT);
            this.grbThongTinSP.Controls.Add(this.lblTenPT);
            this.grbThongTinSP.Controls.Add(this.txtTenPT);
            this.grbThongTinSP.Controls.Add(this.lblSoLuongTon);
            this.grbThongTinSP.Controls.Add(this.txtSoLuongTon);
            this.grbThongTinSP.Controls.Add(this.lblDonViTinh);
            this.grbThongTinSP.Controls.Add(this.cmbDonViTinh);
            this.grbThongTinSP.Controls.Add(this.lblDonGia);
            this.grbThongTinSP.Controls.Add(this.txtDonGia);
            this.grbThongTinSP.Controls.Add(this.lblLoaiPT);
            this.grbThongTinSP.Controls.Add(this.cmbLoaiPT);
            this.grbThongTinSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbThongTinSP.Location = new System.Drawing.Point(25, 102);
            this.grbThongTinSP.Name = "grbThongTinSP";
            this.grbThongTinSP.Size = new System.Drawing.Size(360, 355);
            this.grbThongTinSP.TabIndex = 1;
            this.grbThongTinSP.TabStop = false;
            this.grbThongTinSP.Text = "Thông tin phụ tùng";
            // 
            // cmbNCC
            // 
            this.cmbNCC.Location = new System.Drawing.Point(140, 281);
            this.cmbNCC.Name = "cmbNCC";
            this.cmbNCC.Size = new System.Drawing.Size(190, 31);
            this.cmbNCC.TabIndex = 13;
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(16, 35);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(114, 23);
            this.lblMaPT.TabIndex = 0;
            this.lblMaPT.Text = "Mã phụ tùng:";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(140, 32);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(190, 30);
            this.txtMaPT.TabIndex = 1;
            // 
            // lblTenPT
            // 
            this.lblTenPT.AutoSize = true;
            this.lblTenPT.Location = new System.Drawing.Point(16, 75);
            this.lblTenPT.Name = "lblTenPT";
            this.lblTenPT.Size = new System.Drawing.Size(116, 23);
            this.lblTenPT.TabIndex = 2;
            this.lblTenPT.Text = "Tên phụ tùng:";
            // 
            // txtTenPT
            // 
            this.txtTenPT.Location = new System.Drawing.Point(140, 72);
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.Size = new System.Drawing.Size(190, 30);
            this.txtTenPT.TabIndex = 3;
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Location = new System.Drawing.Point(16, 115);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(82, 23);
            this.lblSoLuongTon.TabIndex = 4;
            this.lblSoLuongTon.Text = "Số lượng:";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(140, 112);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(120, 30);
            this.txtSoLuongTon.TabIndex = 5;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(16, 155);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(98, 23);
            this.lblDonViTinh.TabIndex = 6;
            this.lblDonViTinh.Text = "Đơn vị tính:";
            // 
            // cmbDonViTinh
            // 
            this.cmbDonViTinh.Location = new System.Drawing.Point(140, 152);
            this.cmbDonViTinh.Name = "cmbDonViTinh";
            this.cmbDonViTinh.Size = new System.Drawing.Size(120, 31);
            this.cmbDonViTinh.TabIndex = 7;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(16, 195);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(74, 23);
            this.lblDonGia.TabIndex = 8;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(140, 192);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(190, 30);
            this.txtDonGia.TabIndex = 9;
            // 
            // lblLoaiPT
            // 
            this.lblLoaiPT.AutoSize = true;
            this.lblLoaiPT.Location = new System.Drawing.Point(16, 235);
            this.lblLoaiPT.Name = "lblLoaiPT";
            this.lblLoaiPT.Size = new System.Drawing.Size(121, 23);
            this.lblLoaiPT.TabIndex = 10;
            this.lblLoaiPT.Text = "Loại phụ tùng:";
            // 
            // cmbLoaiPT
            // 
            this.cmbLoaiPT.Location = new System.Drawing.Point(140, 232);
            this.cmbLoaiPT.Name = "cmbLoaiPT";
            this.cmbLoaiPT.Size = new System.Drawing.Size(190, 31);
            this.cmbLoaiPT.TabIndex = 11;
            // 
            // btnThemPT
            // 
            this.btnThemPT.Location = new System.Drawing.Point(30, 493);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(110, 35);
            this.btnThemPT.TabIndex = 5;
            this.btnThemPT.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(150, 493);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 35);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(270, 493);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(390, 493);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 35);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(517, 493);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(988, 68);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(120, 30);
            this.btnXuatExcel.TabIndex = 10;
            this.btnXuatExcel.Text = "Xuất CSV";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(998, 498);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 30);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // dgvPhuTung
            // 
            this.dgvPhuTung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuTung.ColumnHeadersHeight = 29;
            this.dgvPhuTung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colLoai,
            this.colDonVi,
            this.colDonGia,
            this.colTon,
            this.nhacungcap});
            this.dgvPhuTung.Location = new System.Drawing.Point(408, 104);
            this.dgvPhuTung.Name = "dgvPhuTung";
            this.dgvPhuTung.ReadOnly = true;
            this.dgvPhuTung.RowHeadersVisible = false;
            this.dgvPhuTung.RowHeadersWidth = 51;
            this.dgvPhuTung.Size = new System.Drawing.Size(693, 353);
            this.dgvPhuTung.TabIndex = 2;
            this.dgvPhuTung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuTung_CellClick);
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã phụ tùng";
            this.colMa.MinimumWidth = 6;
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên phụ tùng";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            // 
            // colLoai
            // 
            this.colLoai.HeaderText = "Loại phụ tùng";
            this.colLoai.MinimumWidth = 6;
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            // 
            // colDonVi
            // 
            this.colDonVi.HeaderText = "Đơn vị tính";
            this.colDonVi.MinimumWidth = 6;
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá (VNĐ)";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colTon
            // 
            this.colTon.HeaderText = "Số lượng";
            this.colTon.MinimumWidth = 6;
            this.colTon.Name = "colTon";
            this.colTon.ReadOnly = true;
            // 
            // nhacungcap
            // 
            this.nhacungcap.HeaderText = "Nhà cung cấp";
            this.nhacungcap.MinimumWidth = 6;
            this.nhacungcap.Name = "nhacungcap";
            this.nhacungcap.ReadOnly = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(582, 72);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 22);
            this.txtTimKiem.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(888, 68);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 30);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTieuDe.Location = new System.Drawing.Point(320, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(404, 41);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Quản lý thông tin phụ tùng";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(995, 462);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(106, 16);
            this.lblTong.TabIndex = 12;
            this.lblTong.Text = "Tổng hàng tồn: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhà cung cấp:";
            // 
            // frmSanPham
            // 
            this.ClientSize = new System.Drawing.Size(1120, 551);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grbThongTinSP);
            this.Controls.Add(this.dgvPhuTung);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemPT);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý phụ tùng";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.grbThongTinSP.ResumeLayout(false);
            this.grbThongTinSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinSP;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.Label lblTenPT;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblLoaiPT;

        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.TextBox txtTenPT;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.ComboBox cmbDonViTinh;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cmbLoaiPT;
        private System.Windows.Forms.Button btnThemPT;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.DataGridView dgvPhuTung;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhacungcap;
        private System.Windows.Forms.ComboBox cmbNCC;
        private System.Windows.Forms.Label label1;
    }
}