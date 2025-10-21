using System.Windows.Forms;

namespace menu
{
    partial class frmLichHen
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblNgayHen = new System.Windows.Forms.Label();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvLichHen = new System.Windows.Forms.DataGridView();
            this.colMaLichHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.grpThongTin.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.txtMaKH);
            this.grpThongTin.Controls.Add(this.lblMaKH);
            this.grpThongTin.Controls.Add(this.lblNgayHen);
            this.grpThongTin.Controls.Add(this.dtpNgayHen);
            this.grpThongTin.Controls.Add(this.lblGhiChu);
            this.grpThongTin.Controls.Add(this.txtGhiChu);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.cmbTrangThai);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(30, 20);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(740, 160);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin lịch hẹn";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Location = new System.Drawing.Point(30, 35);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(100, 25);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Khách hàng:";
            // 
            // lblNgayHen
            // 
            this.lblNgayHen.Location = new System.Drawing.Point(393, 35);
            this.lblNgayHen.Name = "lblNgayHen";
            this.lblNgayHen.Size = new System.Drawing.Size(97, 25);
            this.lblNgayHen.TabIndex = 2;
            this.lblNgayHen.Text = "Ngày hẹn:";
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.Location = new System.Drawing.Point(500, 32);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(200, 30);
            this.dtpNgayHen.TabIndex = 3;
            this.dtpNgayHen.ValueChanged += new System.EventHandler(this.dtpNgayHen_ValueChanged);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Location = new System.Drawing.Point(30, 80);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(80, 25);
            this.lblGhiChu.TabIndex = 4;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(150, 77);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(550, 30);
            this.txtGhiChu.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Location = new System.Drawing.Point(30, 120);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(100, 25);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.Items.AddRange(new object[] {
            "Chờ",
            "Đã đến",
            "Hủy"});
            this.cmbTrangThai.Location = new System.Drawing.Point(150, 117);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(200, 31);
            this.cmbTrangThai.TabIndex = 7;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnLamMoi);
            this.grpChucNang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChucNang.Location = new System.Drawing.Point(30, 190);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(740, 70);
            this.grpChucNang.TabIndex = 1;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "➕ Thêm";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(210, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✏️ Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(380, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "🗑️ Xóa";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(550, 25);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(150, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "🔄 Làm mới";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvLichHen);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(30, 270);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(740, 300);
            this.grpDanhSach.TabIndex = 2;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách lịch hẹn";
            // 
            // dgvLichHen
            // 
            this.dgvLichHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLichHen,
            this.colTenKH,
            this.colNgayHen,
            this.colGhiChu,
            this.colTrangThai});
            this.dgvLichHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHen.Location = new System.Drawing.Point(3, 26);
            this.dgvLichHen.Name = "dgvLichHen";
            this.dgvLichHen.RowHeadersWidth = 51;
            this.dgvLichHen.Size = new System.Drawing.Size(734, 271);
            this.dgvLichHen.TabIndex = 0;
            this.dgvLichHen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichHen_CellContentClick);
            // 
            // colMaLichHen
            // 
            this.colMaLichHen.HeaderText = "Mã lịch hẹn";
            this.colMaLichHen.MinimumWidth = 6;
            this.colMaLichHen.Name = "colMaLichHen";
            // 
            // colTenKH
            // 
            this.colTenKH.HeaderText = "Khách hàng";
            this.colTenKH.MinimumWidth = 6;
            this.colTenKH.Name = "colTenKH";
            // 
            // colNgayHen
            // 
            this.colNgayHen.HeaderText = "Ngày hẹn";
            this.colNgayHen.MinimumWidth = 6;
            this.colNgayHen.Name = "colNgayHen";
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(150, 35);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(200, 30);
            this.txtMaKH.TabIndex = 8;
            // 
            // frmLichHen
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpDanhSach);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmLichHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch hẹn khách hàng";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grpThongTin;
        private Label lblMaKH;
        private Label lblNgayHen;
        private DateTimePicker dtpNgayHen;
        private Label lblGhiChu;
        private TextBox txtGhiChu;
        private Label lblTrangThai;
        private ComboBox cmbTrangThai;

        private GroupBox grpChucNang;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        private GroupBox grpDanhSach;
        private DataGridView dgvLichHen;
        private DataGridViewTextBoxColumn colMaLichHen;
        private DataGridViewTextBoxColumn colTenKH;
        private DataGridViewTextBoxColumn colNgayHen;
        private DataGridViewTextBoxColumn colGhiChu;
        private DataGridViewTextBoxColumn colTrangThai;
        private TextBox txtMaKH;
    }
}