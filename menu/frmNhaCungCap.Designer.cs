namespace menu
{
    partial class frmNhaCungCap
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
            this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblTenNhaCC = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddorUpdate = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.grpbxThongTinNCC = new System.Windows.Forms.GroupBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.grpbxThongTinNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(373, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm nhà cung cấp";
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.AllowUserToAddRows = false;
            this.dgvNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNCC,
            this.colTenNCC,
            this.colSDT,
            this.colDiaChi,
            this.colEmail});
            this.dgvNhaCungCap.Location = new System.Drawing.Point(12, 107);
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.RowHeadersWidth = 51;
            this.dgvNhaCungCap.RowTemplate.Height = 24;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(793, 423);
            this.dgvNhaCungCap.TabIndex = 1;
            this.dgvNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCungCap_CellClick);
            // 
            // colMaNCC
            // 
            this.colMaNCC.HeaderText = "Mã NCC";
            this.colMaNCC.MinimumWidth = 6;
            this.colMaNCC.Name = "colMaNCC";
            // 
            // colTenNCC
            // 
            this.colTenNCC.HeaderText = "Tên nhà cung cấp";
            this.colTenNCC.MinimumWidth = 6;
            this.colTenNCC.Name = "colTenNCC";
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(6, 40);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(142, 20);
            this.lblMaNCC.TabIndex = 0;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // lblTenNhaCC
            // 
            this.lblTenNhaCC.AutoSize = true;
            this.lblTenNhaCC.Location = new System.Drawing.Point(6, 115);
            this.lblTenNhaCC.Name = "lblTenNhaCC";
            this.lblTenNhaCC.Size = new System.Drawing.Size(142, 20);
            this.lblTenNhaCC.TabIndex = 1;
            this.lblTenNhaCC.Text = "Tên nhà cung cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNCC.Location = new System.Drawing.Point(10, 63);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(293, 27);
            this.txtMaNCC.TabIndex = 2;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNCC.Location = new System.Drawing.Point(10, 138);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(322, 27);
            this.txtTenNCC.TabIndex = 3;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(6, 247);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(84, 20);
            this.lblDienThoai.TabIndex = 4;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 309);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(10, 332);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(322, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // btnAddorUpdate
            // 
            this.btnAddorUpdate.AutoSize = true;
            this.btnAddorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddorUpdate.Location = new System.Drawing.Point(10, 365);
            this.btnAddorUpdate.Name = "btnAddorUpdate";
            this.btnAddorUpdate.Size = new System.Drawing.Size(105, 34);
            this.btnAddorUpdate.TabIndex = 8;
            this.btnAddorUpdate.Text = "Thêm/Sửa";
            this.btnAddorUpdate.UseVisualStyleBackColor = true;
            this.btnAddorUpdate.Click += new System.EventHandler(this.btnAddorUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(132, 365);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 34);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(6, 180);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 20);
            this.lblDiaChi.TabIndex = 10;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Location = new System.Drawing.Point(10, 203);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(322, 27);
            this.txtDiaChi.TabIndex = 11;
            // 
            // grpbxThongTinNCC
            // 
            this.grpbxThongTinNCC.Controls.Add(this.txtDiaChi);
            this.grpbxThongTinNCC.Controls.Add(this.lblDiaChi);
            this.grpbxThongTinNCC.Controls.Add(this.btnXoa);
            this.grpbxThongTinNCC.Controls.Add(this.btnAddorUpdate);
            this.grpbxThongTinNCC.Controls.Add(this.txtEmail);
            this.grpbxThongTinNCC.Controls.Add(this.lblEmail);
            this.grpbxThongTinNCC.Controls.Add(this.txtDT);
            this.grpbxThongTinNCC.Controls.Add(this.lblDienThoai);
            this.grpbxThongTinNCC.Controls.Add(this.txtTenNCC);
            this.grpbxThongTinNCC.Controls.Add(this.txtMaNCC);
            this.grpbxThongTinNCC.Controls.Add(this.lblTenNhaCC);
            this.grpbxThongTinNCC.Controls.Add(this.lblMaNCC);
            this.grpbxThongTinNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxThongTinNCC.Location = new System.Drawing.Point(811, 107);
            this.grpbxThongTinNCC.Name = "grpbxThongTinNCC";
            this.grpbxThongTinNCC.Size = new System.Drawing.Size(350, 423);
            this.grpbxThongTinNCC.TabIndex = 2;
            this.grpbxThongTinNCC.TabStop = false;
            this.grpbxThongTinNCC.Text = "Nhập thông tin nhà cung cấp";
            this.grpbxThongTinNCC.Enter += new System.EventHandler(this.grpbxThongTinNCC_Enter);
            // 
            // txtDT
            // 
            this.txtDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDT.Location = new System.Drawing.Point(10, 270);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(322, 27);
            this.txtDT.TabIndex = 5;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 553);
            this.Controls.Add(this.grpbxThongTinNCC);
            this.Controls.Add(this.dgvNhaCungCap);
            this.Controls.Add(this.label1);
            this.Name = "frmNhaCungCap";
            this.Text = "frmNhaCungCap";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.grpbxThongTinNCC.ResumeLayout(false);
            this.grpbxThongTinNCC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblTenNhaCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddorUpdate;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox grpbxThongTinNCC;
        private System.Windows.Forms.TextBox txtDT;
    }
}