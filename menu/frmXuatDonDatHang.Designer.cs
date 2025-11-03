namespace menu
{
    partial class frmXuatDonDatHang
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.XuatPhieuNhap = new menu.XuatPhieuNhap();
            this.DonDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DonDatHangTableAdapter = new menu.XuatPhieuNhapTableAdapters.DonDatHangTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XuatPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonDatHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DonDatHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "menu.XuatPhieuNhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(988, 496);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // XuatPhieuNhap
            // 
            this.XuatPhieuNhap.DataSetName = "XuatPhieuNhap";
            this.XuatPhieuNhap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DonDatHangBindingSource
            // 
            this.DonDatHangBindingSource.DataMember = "DonDatHang";
            this.DonDatHangBindingSource.DataSource = this.XuatPhieuNhap;
            // 
            // DonDatHangTableAdapter
            // 
            this.DonDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xuất thông tin phiếu nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmXuatDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmXuatDonDatHang";
            this.Text = "frmXuatDonDatHang";
            this.Load += new System.EventHandler(this.frmXuatDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XuatPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonDatHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DonDatHangBindingSource;
        private XuatPhieuNhap XuatPhieuNhap;
        private XuatPhieuNhapTableAdapters.DonDatHangTableAdapter DonDatHangTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}