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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewThongTin = new System.Windows.Forms.DataGridView();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenPT = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmbLoaiPT = new System.Windows.Forms.ComboBox();
            this.cmbDonViTinh = new System.Windows.Forms.ComboBox();
            this.ColumnMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLoaiPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSLTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1167, 420);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(949, 420);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(370, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(543, 46);
            this.label7.TabIndex = 31;
            this.label7.Text = "Quản Lý Thông Tin Phụ Tùng";
            // 
            // dataGridViewThongTin
            // 
            this.dataGridViewThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaPT,
            this.ColumnTenPT,
            this.ColumnLoaiPT,
            this.ColumnDonViTinh,
            this.ColumnDonGia,
            this.ColumnSLTon});
            this.dataGridViewThongTin.Location = new System.Drawing.Point(426, 144);
            this.dataGridViewThongTin.Name = "dataGridViewThongTin";
            this.dataGridViewThongTin.RowHeadersWidth = 51;
            this.dataGridViewThongTin.RowTemplate.Height = 24;
            this.dataGridViewThongTin.Size = new System.Drawing.Size(833, 257);
            this.dataGridViewThongTin.TabIndex = 30;
            this.dataGridViewThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThongTin_CellClick);
            this.dataGridViewThongTin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThongTin_CellContentClick);
            // 
            // btnThemPT
            // 
            this.btnThemPT.Location = new System.Drawing.Point(699, 420);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(75, 23);
            this.btnThemPT.TabIndex = 29;
            this.btnThemPT.Text = "Thêm Phụ Tùng";
            this.btnThemPT.UseVisualStyleBackColor = true;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(175, 382);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuongTon.TabIndex = 28;
            this.txtSoLuongTon.TextChanged += new System.EventHandler(this.txtSoLuongTon_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Số lượng tồn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Đơn vị tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Loại phụ tùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên phụ tùng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã phụ tùng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(175, 332);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(184, 22);
            this.txtDonGia.TabIndex = 21;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // txtTenPT
            // 
            this.txtTenPT.Location = new System.Drawing.Point(175, 175);
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.Size = new System.Drawing.Size(184, 22);
            this.txtTenPT.TabIndex = 18;
            this.txtTenPT.TextChanged += new System.EventHandler(this.txtTenPT_TextChanged);
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(175, 130);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(100, 22);
            this.txtMaPT.TabIndex = 17;
            this.txtMaPT.TextChanged += new System.EventHandler(this.txtMaPT_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(461, 420);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbLoaiPT
            // 
            this.cmbLoaiPT.FormattingEnabled = true;
            this.cmbLoaiPT.Items.AddRange(new object[] {
            "Nhớt và dầu bôi trơn",
            "Lốp và Ruột xe",
            "Ắc quy và Điện",
            "Hệ thống phanh",
            "Lọc gió và bugi",
            "Ống xả",
            "Giảm xóc",
            "Phụ tùng truyền động",
            "Phụ tùng thân vỏ",
            "Nước làm mát và hóa chất",
            "Khác"});
            this.cmbLoaiPT.Location = new System.Drawing.Point(175, 219);
            this.cmbLoaiPT.Name = "cmbLoaiPT";
            this.cmbLoaiPT.Size = new System.Drawing.Size(121, 24);
            this.cmbLoaiPT.TabIndex = 35;
            this.cmbLoaiPT.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPT_SelectedIndexChanged);
            // 
            // cmbDonViTinh
            // 
            this.cmbDonViTinh.FormattingEnabled = true;
            this.cmbDonViTinh.Items.AddRange(new object[] {
            "Cái",
            "Cặp",
            "Bộ",
            "Chiếc",
            "Chai",
            "Lon",
            "Lít",
            "Thùng",
            "Hộp",
            "Mét",
            "Cuộn",
            "Cây",
            "Miếng",
            "Gói",
            "Túi"});
            this.cmbDonViTinh.Location = new System.Drawing.Point(175, 273);
            this.cmbDonViTinh.Name = "cmbDonViTinh";
            this.cmbDonViTinh.Size = new System.Drawing.Size(121, 24);
            this.cmbDonViTinh.TabIndex = 36;
            this.cmbDonViTinh.SelectedIndexChanged += new System.EventHandler(this.cmbDonViTinh_SelectedIndexChanged);
            // 
            // ColumnMaPT
            // 
            this.ColumnMaPT.DataPropertyName = "MaPT";
            this.ColumnMaPT.HeaderText = "Mã phụ tùng";
            this.ColumnMaPT.MinimumWidth = 6;
            this.ColumnMaPT.Name = "ColumnMaPT";
            this.ColumnMaPT.Width = 125;
            // 
            // ColumnTenPT
            // 
            this.ColumnTenPT.DataPropertyName = "TenPT";
            this.ColumnTenPT.HeaderText = "Tên phụ tùng";
            this.ColumnTenPT.MinimumWidth = 6;
            this.ColumnTenPT.Name = "ColumnTenPT";
            this.ColumnTenPT.Width = 125;
            // 
            // ColumnLoaiPT
            // 
            this.ColumnLoaiPT.DataPropertyName = "LoaiPT";
            this.ColumnLoaiPT.HeaderText = "Loại phụ tùng";
            this.ColumnLoaiPT.MinimumWidth = 6;
            this.ColumnLoaiPT.Name = "ColumnLoaiPT";
            this.ColumnLoaiPT.Width = 125;
            // 
            // ColumnDonViTinh
            // 
            this.ColumnDonViTinh.DataPropertyName = "DonViTinh";
            this.ColumnDonViTinh.HeaderText = "DonViTinh";
            this.ColumnDonViTinh.MinimumWidth = 6;
            this.ColumnDonViTinh.Name = "ColumnDonViTinh";
            this.ColumnDonViTinh.Width = 125;
            // 
            // ColumnDonGia
            // 
            this.ColumnDonGia.DataPropertyName = "DonGia";
            this.ColumnDonGia.HeaderText = "Đơn giá";
            this.ColumnDonGia.MinimumWidth = 6;
            this.ColumnDonGia.Name = "ColumnDonGia";
            this.ColumnDonGia.Width = 125;
            // 
            // ColumnSLTon
            // 
            this.ColumnSLTon.DataPropertyName = "SoLuongTon";
            this.ColumnSLTon.HeaderText = "Số lượng tồn";
            this.ColumnSLTon.MinimumWidth = 6;
            this.ColumnSLTon.Name = "ColumnSLTon";
            this.ColumnSLTon.Width = 125;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 538);
            this.Controls.Add(this.cmbDonViTinh);
            this.Controls.Add(this.cmbLoaiPT);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewThongTin);
            this.Controls.Add(this.btnThemPT);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenPT);
            this.Controls.Add(this.txtMaPT);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewThongTin;
        private System.Windows.Forms.Button btnThemPT;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenPT;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cmbLoaiPT;
        private System.Windows.Forms.ComboBox cmbDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLoaiPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSLTon;
    }
}