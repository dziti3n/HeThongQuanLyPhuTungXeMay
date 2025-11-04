namespace menu
{
    partial class frmPTBanCap
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
            this.dsPTBanTheoCap = new menu.dsPTBanTheoCap();
            this.PhuTungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhuTungTableAdapter = new menu.dsPTBanTheoCapTableAdapters.PhuTungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPTBanTheoCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhuTungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 73;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PhuTungBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "menu.rBaoCaoPTBanCap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPTBanTheoCap
            // 
            this.dsPTBanTheoCap.DataSetName = "dsPTBanTheoCap";
            this.dsPTBanTheoCap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhuTungBindingSource
            // 
            this.PhuTungBindingSource.DataMember = "PhuTung";
            this.PhuTungBindingSource.DataSource = this.dsPTBanTheoCap;
            // 
            // PhuTungTableAdapter
            // 
            this.PhuTungTableAdapter.ClearBeforeFill = true;
            // 
            // frmPTBanCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmPTBanCap";
            this.Text = "frmPTBanCap";
            this.Load += new System.EventHandler(this.frmPTBanCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPTBanTheoCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhuTungBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PhuTungBindingSource;
        private dsPTBanTheoCap dsPTBanTheoCap;
        private dsPTBanTheoCapTableAdapters.PhuTungTableAdapter PhuTungTableAdapter;
    }
}