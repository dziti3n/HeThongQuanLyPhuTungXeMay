namespace menu
{
    partial class frmThongKeTonKho
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
            this.TonKhoDataSet = new menu.TonKhoDataSet();
            this.PhuTungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhuTungTableAdapter = new menu.TonKhoDataSetTableAdapters.PhuTungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TonKhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhuTungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PhuTungBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "menu.TonKhoReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TonKhoDataSet
            // 
            this.TonKhoDataSet.DataSetName = "TonKhoDataSet";
            this.TonKhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhuTungBindingSource
            // 
            this.PhuTungBindingSource.DataMember = "PhuTung";
            this.PhuTungBindingSource.DataSource = this.TonKhoDataSet;
            // 
            // PhuTungTableAdapter
            // 
            this.PhuTungTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmThongKeTonKho";
            this.Text = "frmThongKeTonKho";
            this.Load += new System.EventHandler(this.frmThongKeTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TonKhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhuTungBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PhuTungBindingSource;
        private TonKhoDataSet TonKhoDataSet;
        private TonKhoDataSetTableAdapters.PhuTungTableAdapter PhuTungTableAdapter;
    }
}