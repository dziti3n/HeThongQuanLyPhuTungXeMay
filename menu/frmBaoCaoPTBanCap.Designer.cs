namespace menu
{
    partial class frmBaoCaoPTBanCap
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPTBanCap = new menu.dsPTBanCap();
            this.PhuTungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhuTungTableAdapter = new menu.dsPTBanCapTableAdapters.PhuTungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPTBanCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhuTungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.PhuTungBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "menu.rSoLuongPT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPTBanCap
            // 
            this.dsPTBanCap.DataSetName = "dsPTBanCap";
            this.dsPTBanCap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhuTungBindingSource
            // 
            this.PhuTungBindingSource.DataMember = "PhuTung";
            this.PhuTungBindingSource.DataSource = this.dsPTBanCap;
            // 
            // PhuTungTableAdapter
            // 
            this.PhuTungTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoPTBanCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoPTBanCap";
            this.Text = "frmBaoCaoPTBanCap";
            this.Load += new System.EventHandler(this.frmBaoCaoPTBanCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPTBanCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhuTungBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PhuTungBindingSource;
        private dsPTBanCap dsPTBanCap;
        private dsPTBanCapTableAdapters.PhuTungTableAdapter PhuTungTableAdapter;
    }
}