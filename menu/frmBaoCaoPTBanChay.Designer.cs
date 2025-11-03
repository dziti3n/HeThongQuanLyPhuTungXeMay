namespace menu
{
    partial class frmBaoCaoPTBanChay
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
            this.dgvBanChay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1070, 49);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BÁO CÁO PHỤ TÙNG BÁN CHẠY TRONG TUẦN NÀY";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvBanChay
            // 
            this.dgvBanChay.AllowUserToAddRows = false;
            this.dgvBanChay.AllowUserToDeleteRows = false;
            this.dgvBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanChay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanChay.Location = new System.Drawing.Point(0, 49);
            this.dgvBanChay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBanChay.Name = "dgvBanChay";
            this.dgvBanChay.ReadOnly = true;
            this.dgvBanChay.RowHeadersVisible = false;
            this.dgvBanChay.RowHeadersWidth = 51;
            this.dgvBanChay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanChay.Size = new System.Drawing.Size(1070, 505);
            this.dgvBanChay.TabIndex = 1;
            // 
            // frmBaoCaoPTBanChay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 554);
            this.Controls.Add(this.dgvBanChay);
            this.Controls.Add(this.lblTieuDe);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBaoCaoPTBanChay";
            this.Text = "Báo cáo phụ tùng bán chạy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dgvBanChay;
    }
}