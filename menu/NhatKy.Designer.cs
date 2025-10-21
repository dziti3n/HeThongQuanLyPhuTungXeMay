using System;

namespace menu
{
    partial class NhatKy
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dgvNhatKy = new System.Windows.Forms.DataGridView();
            this.MaNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanhDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(23, 16);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(350, 37);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "📜 NHẬT KÝ HOẠT ĐỘNG";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTuKhoa.Location = new System.Drawing.Point(29, 64);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(411, 30);
            this.txtTuKhoa.TabIndex = 1;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTimKiem.Location = new System.Drawing.Point(457, 62);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 30);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "🔍 Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTaiLai.Location = new System.Drawing.Point(583, 62);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(103, 30);
            this.btnTaiLai.TabIndex = 3;
            this.btnTaiLai.Text = "⟳ Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // dgvNhatKy
            // 
            this.dgvNhatKy.AllowUserToAddRows = false;
            this.dgvNhatKy.AllowUserToDeleteRows = false;
            this.dgvNhatKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhatKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhatKy.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhatKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNK,
            this.HoTen,
            this.HanhDong,
            this.ThoiGian});
            this.dgvNhatKy.Location = new System.Drawing.Point(29, 107);
            this.dgvNhatKy.MultiSelect = false;
            this.dgvNhatKy.Name = "dgvNhatKy";
            this.dgvNhatKy.ReadOnly = true;
            this.dgvNhatKy.RowHeadersVisible = false;
            this.dgvNhatKy.RowHeadersWidth = 51;
            this.dgvNhatKy.RowTemplate.Height = 28;
            this.dgvNhatKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhatKy.Size = new System.Drawing.Size(869, 405);
            this.dgvNhatKy.TabIndex = 4;
            this.dgvNhatKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhatKy_CellContentClick);
            // 
            // MaNK
            // 
            this.MaNK.HeaderText = "Mã nhật ký";
            this.MaNK.MinimumWidth = 6;
            this.MaNK.Name = "MaNK";
            this.MaNK.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Tên nhân viên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // HanhDong
            // 
            this.HanhDong.HeaderText = "Hành động";
            this.HanhDong.MinimumWidth = 6;
            this.HanhDong.Name = "HanhDong";
            this.HanhDong.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // NhatKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 544);
            this.Controls.Add(this.dgvNhatKy);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NhatKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhật ký hoạt động hệ thống";
            this.Load += new System.EventHandler(this.frmNhatKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridView dgvNhatKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanhDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
    }
}