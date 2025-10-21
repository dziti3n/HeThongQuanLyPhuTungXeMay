namespace menu
{
    partial class frmDoanhThu
    {
        private DevExpress.XtraEditors.LabelControl lblTieuDe;
        private DevExpress.XtraEditors.DateEdit dateTuNgay;
        private DevExpress.XtraEditors.DateEdit dateDenNgay;
        private DevExpress.XtraEditors.LabelControl lblTuNgay;
        private DevExpress.XtraEditors.LabelControl lblDenNgay;
        private DevExpress.XtraEditors.SimpleButton btnXemBaoCao;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcel;
        private DevExpress.XtraEditors.SimpleButton btnXuatPDF;
        private DevExpress.XtraGrid.GridControl gridDoanhThu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDoanhThu;
        private DevExpress.XtraEditors.LabelControl lblTongDoanhThu;
        private DevExpress.XtraEditors.LabelControl lblGiaTriTong;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new DevExpress.XtraEditors.LabelControl();
            this.dateTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.dateDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.lblTuNgay = new DevExpress.XtraEditors.LabelControl();
            this.lblDenNgay = new DevExpress.XtraEditors.LabelControl();
            this.btnXemBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatPDF = new DevExpress.XtraEditors.SimpleButton();
            this.gridDoanhThu = new DevExpress.XtraGrid.GridControl();
            this.gridViewDoanhThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblTongDoanhThu = new DevExpress.XtraEditors.LabelControl();
            this.lblGiaTriTong = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Appearance.Options.UseFont = true;
            this.lblTieuDe.Location = new System.Drawing.Point(300, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(220, 27);
            this.lblTieuDe.Text = "BÁO CÁO DOANH THU";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.Location = new System.Drawing.Point(40, 65);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(45, 13);
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.Location = new System.Drawing.Point(260, 65);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(51, 13);
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.EditValue = null;
            this.dateTuNgay.Location = new System.Drawing.Point(95, 62);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTuNgay.Size = new System.Drawing.Size(150, 20);
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.EditValue = null;
            this.dateDenNgay.Location = new System.Drawing.Point(320, 62);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDenNgay.Size = new System.Drawing.Size(150, 20);
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(500, 60);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(100, 25);
            this.btnXemBaoCao.Text = "Xem báo cáo";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(610, 60);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(80, 25);
            this.btnXuatExcel.Text = "Xuất Excel";
            // 
            // btnXuatPDF
            // 
            this.btnXuatPDF.Location = new System.Drawing.Point(700, 60);
            this.btnXuatPDF.Name = "btnXuatPDF";
            this.btnXuatPDF.Size = new System.Drawing.Size(80, 25);
            this.btnXuatPDF.Text = "Xuất PDF";
            // 
            // gridDoanhThu
            // 
            this.gridDoanhThu.Location = new System.Drawing.Point(25, 100);
            this.gridDoanhThu.MainView = this.gridViewDoanhThu;
            this.gridDoanhThu.Name = "gridDoanhThu";
            this.gridDoanhThu.Size = new System.Drawing.Size(750, 300);
            this.gridDoanhThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDoanhThu});
            // 
            // gridViewDoanhThu
            // 
            this.gridViewDoanhThu.GridControl = this.gridDoanhThu;
            this.gridViewDoanhThu.Name = "gridViewDoanhThu";
            this.gridViewDoanhThu.OptionsBehavior.Editable = false;
            this.gridViewDoanhThu.OptionsView.ShowGroupPanel = false;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.Appearance.Options.UseFont = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(450, 420);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(120, 17);
            this.lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // lblGiaTriTong
            // 
            this.lblGiaTriTong.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblGiaTriTong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblGiaTriTong.Appearance.Options.UseFont = true;
            this.lblGiaTriTong.Appearance.Options.UseForeColor = true;
            this.lblGiaTriTong.Location = new System.Drawing.Point(580, 420);
            this.lblGiaTriTong.Name = "lblGiaTriTong";
            this.lblGiaTriTong.Size = new System.Drawing.Size(70, 17);
            this.lblGiaTriTong.Text = "0 VNĐ";
            // 
            // frmDoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.lblGiaTriTong);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.gridDoanhThu);
            this.Controls.Add(this.btnXuatPDF);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.dateDenNgay);
            this.Controls.Add(this.dateTuNgay);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "frmDoanhThu";
            this.Text = "Báo cáo doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
