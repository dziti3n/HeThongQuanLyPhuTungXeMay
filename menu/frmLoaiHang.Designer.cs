namespace menu
{
    partial class frmLoaiHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Dọn dẹp tài nguyên đang dùng.
        /// </summary>
        /// <param name="disposing">true nếu cần giải phóng tài nguyên.</param>
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
        ///  Thiết kế giao diện Form Loại Hàng
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvLoaiHang = new System.Windows.Forms.DataGridView();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.grpbxLoaiHang = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).BeginInit();
            this.grpbxLoaiHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(309, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ LOẠI HÀNG";
            // 
            // dgvLoaiHang
            // 
            this.dgvLoaiHang.AllowUserToAddRows = false;
            this.dgvLoaiHang.AllowUserToDeleteRows = false;
            this.dgvLoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiHang.Location = new System.Drawing.Point(57, 267);
            this.dgvLoaiHang.MultiSelect = false;
            this.dgvLoaiHang.Name = "dgvLoaiHang";
            this.dgvLoaiHang.ReadOnly = true;
            this.dgvLoaiHang.RowHeadersWidth = 51;
            this.dgvLoaiHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiHang.Size = new System.Drawing.Size(731, 235);
            this.dgvLoaiHang.TabIndex = 9;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaLoai.Location = new System.Drawing.Point(108, 36);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(228, 30);
            this.txtMaLoai.TabIndex = 1;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenLoai.Location = new System.Drawing.Point(108, 79);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(342, 30);
            this.txtTenLoai.TabIndex = 2;
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaLoai.Location = new System.Drawing.Point(16, 39);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(74, 23);
            this.lblMaLoai.TabIndex = 5;
            this.lblMaLoai.Text = "Mã Loại:";
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenLoai.Location = new System.Drawing.Point(16, 82);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(76, 23);
            this.lblTenLoai.TabIndex = 6;
            this.lblTenLoai.Text = "Tên Loại:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(594, 85);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(697, 85);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 32);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(594, 128);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 32);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(697, 128);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 32);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(594, 171);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 32);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(697, 171);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 32);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(108, 126);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(342, 30);
            this.txtTimKiem.TabIndex = 10;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(594, 213);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(91, 32);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTimKiem.Location = new System.Drawing.Point(16, 131);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(83, 23);
            this.lblTimKiem.TabIndex = 13;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // grpbxLoaiHang
            // 
            this.grpbxLoaiHang.Controls.Add(this.txtTimKiem);
            this.grpbxLoaiHang.Controls.Add(this.lblTimKiem);
            this.grpbxLoaiHang.Controls.Add(this.txtMaLoai);
            this.grpbxLoaiHang.Controls.Add(this.txtTenLoai);
            this.grpbxLoaiHang.Controls.Add(this.lblMaLoai);
            this.grpbxLoaiHang.Controls.Add(this.lblTenLoai);
            this.grpbxLoaiHang.Location = new System.Drawing.Point(83, 85);
            this.grpbxLoaiHang.Name = "grpbxLoaiHang";
            this.grpbxLoaiHang.Size = new System.Drawing.Size(505, 176);
            this.grpbxLoaiHang.TabIndex = 14;
            this.grpbxLoaiHang.TabStop = false;
            this.grpbxLoaiHang.Text = "Thông tin loại hàng";
            // 
            // frmLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(857, 533);
            this.Controls.Add(this.grpbxLoaiHang);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvLoaiHang);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).EndInit();
            this.grpbxLoaiHang.ResumeLayout(false);
            this.grpbxLoaiHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvLoaiHang;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.GroupBox grpbxLoaiHang;
    }
}
