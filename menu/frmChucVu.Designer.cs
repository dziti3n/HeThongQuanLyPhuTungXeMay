namespace menu
{
    partial class frmChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnQLCV = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemSua,
            this.btnXoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(962, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemSua
            // 
            this.btnThemSua.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSua.Image")));
            this.btnThemSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(109, 24);
            this.btnThemSua.Text = "Thêm / Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 24);
            this.btnXoa.Text = "Xoá";
            // 
            // btnQLCV
            // 
            this.btnQLCV.Location = new System.Drawing.Point(-156, 389);
            this.btnQLCV.Name = "btnQLCV";
            this.btnQLCV.Size = new System.Drawing.Size(134, 23);
            this.btnQLCV.TabIndex = 17;
            this.btnQLCV.Text = "Quản Lý Chức Vụ";
            this.btnQLCV.UseVisualStyleBackColor = true;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.btnHuy);
            this.grbThongTin.Controls.Add(this.btnLuu);
            this.grbThongTin.Controls.Add(this.txtTenNV);
            this.grbThongTin.Controls.Add(this.txtTaiKhoan);
            this.grbThongTin.Location = new System.Drawing.Point(638, 40);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(312, 297);
            this.grbThongTin.TabIndex = 16;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Nhập thông tin chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Chức Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Chức Vụ";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(202, 254);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(121, 254);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(115, 61);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(185, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(115, 23);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(185, 22);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoiDung.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV,
            this.Quyen});
            this.dgvNguoiDung.Location = new System.Drawing.Point(0, 40);
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.ReadOnly = true;
            this.dgvNguoiDung.RowHeadersWidth = 51;
            this.dgvNguoiDung.RowTemplate.Height = 24;
            this.dgvNguoiDung.Size = new System.Drawing.Size(616, 333);
            this.dgvNguoiDung.TabIndex = 12;
            // 
            // MaCV
            // 
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            // 
            // TenCV
            // 
            this.TenCV.HeaderText = "Tên Chức Vụ";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            this.TenCV.ReadOnly = true;
            // 
            // Quyen
            // 
            this.Quyen.HeaderText = "Quyền ?";
            this.Quyen.MinimumWidth = 6;
            this.Quyen.Name = "Quyen";
            this.Quyen.ReadOnly = true;
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 381);
            this.Controls.Add(this.btnQLCV);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.dgvNguoiDung);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chức Vụ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.Button btnQLCV;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Quyen;
    }
}