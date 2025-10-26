namespace menu
{
    partial class frmLichSuMuaHang
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
            this.dgvLichSuMuaHang = new System.Windows.Forms.DataGridView();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphutung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemTheoSDT = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuMuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSuMuaHang
            // 
            this.dgvLichSuMuaHang.AllowUserToAddRows = false;
            this.dgvLichSuMuaHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSuMuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuMuaHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sodienthoai,
            this.tenkhachhang,
            this.tenphutung,
            this.giatien});
            this.dgvLichSuMuaHang.Location = new System.Drawing.Point(44, 159);
            this.dgvLichSuMuaHang.Name = "dgvLichSuMuaHang";
            this.dgvLichSuMuaHang.RowHeadersWidth = 51;
            this.dgvLichSuMuaHang.RowTemplate.Height = 24;
            this.dgvLichSuMuaHang.Size = new System.Drawing.Size(651, 327);
            this.dgvLichSuMuaHang.TabIndex = 0;
            this.dgvLichSuMuaHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSuMuaHang_CellClick);
            // 
            // sodienthoai
            // 
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.MinimumWidth = 6;
            this.sodienthoai.Name = "sodienthoai";
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.HeaderText = "Tên khách hàng";
            this.tenkhachhang.MinimumWidth = 6;
            this.tenkhachhang.Name = "tenkhachhang";
            // 
            // tenphutung
            // 
            this.tenphutung.HeaderText = "Tên Phụ Tùng";
            this.tenphutung.MinimumWidth = 6;
            this.tenphutung.Name = "tenphutung";
            // 
            // giatien
            // 
            this.giatien.HeaderText = "Giá Tiền";
            this.giatien.MinimumWidth = 6;
            this.giatien.Name = "giatien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm theo số điện thoại:";
            // 
            // txtTimKiemTheoSDT
            // 
            this.txtTimKiemTheoSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTheoSDT.Location = new System.Drawing.Point(445, 52);
            this.txtTimKiemTheoSDT.Name = "txtTimKiemTheoSDT";
            this.txtTimKiemTheoSDT.Size = new System.Drawing.Size(244, 30);
            this.txtTimKiemTheoSDT.TabIndex = 2;
            this.txtTimKiemTheoSDT.TextChanged += new System.EventHandler(this.txtTimKiemTheoSDT_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(594, 88);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 35);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(270, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lịch sử mua hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(546, 501);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(149, 30);
            this.txtTongTien.TabIndex = 6;
            // 
            // frmLichSuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 561);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiemTheoSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLichSuMuaHang);
            this.Name = "frmLichSuMuaHang";
            this.Text = "frmLichSuMuaHang";
            this.Load += new System.EventHandler(this.frmLichSuMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuMuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichSuMuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphutung;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemTheoSDT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}