namespace menu
{
    partial class frmLoiNhuan
    {
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
            this.gridLoiNhuan = new DevExpress.XtraGrid.GridControl();
            this.viewLoiNhuan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnXemBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.dtTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.dtDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelTuNgay = new DevExpress.XtraEditors.LabelControl();
            this.labelDenNgay = new DevExpress.XtraEditors.LabelControl();
            this.lblTongLoiNhuan = new DevExpress.XtraEditors.LabelControl();
            this.txtTongLoiNhuan = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoiNhuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLoiNhuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongLoiNhuan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLoiNhuan
            // 
            this.gridLoiNhuan.Location = new System.Drawing.Point(20, 90);
            this.gridLoiNhuan.MainView = this.viewLoiNhuan;
            this.gridLoiNhuan.Name = "gridLoiNhuan";
            this.gridLoiNhuan.Size = new System.Drawing.Size(760, 300);
            this.gridLoiNhuan.TabIndex = 0;
            this.gridLoiNhuan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewLoiNhuan});
            // 
            // viewLoiNhuan
            // 
            this.viewLoiNhuan.GridControl = this.gridLoiNhuan;
            this.viewLoiNhuan.Name = "viewLoiNhuan";
            this.viewLoiNhuan.OptionsBehavior.Editable = false;
            this.viewLoiNhuan.OptionsView.ShowGroupPanel = false;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.Appearance.Options.UseFont = true;
            this.btnXemBaoCao.Location = new System.Drawing.Point(600, 30);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(150, 30);
            this.btnXemBaoCao.TabIndex = 1;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.EditValue = null;
            this.dtTuNgay.Location = new System.Drawing.Point(90, 35);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtTuNgay.Properties.Appearance.Options.UseFont = true;
            this.dtTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTuNgay.Size = new System.Drawing.Size(150, 20);
            this.dtTuNgay.TabIndex = 2;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.EditValue = null;
            this.dtDenNgay.Location = new System.Drawing.Point(370, 35);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtDenNgay.Properties.Appearance.Options.UseFont = true;
            this.dtDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDenNgay.Size = new System.Drawing.Size(150, 20);
            this.dtDenNgay.TabIndex = 3;
            // 
            // labelTuNgay
            // 
            this.labelTuNgay.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelTuNgay.Location = new System.Drawing.Point(30, 38);
            this.labelTuNgay.Name = "labelTuNgay";
            this.labelTuNgay.Size = new System.Drawing.Size(50, 14);
            this.labelTuNgay.TabIndex = 4;
            this.labelTuNgay.Text = "Từ ngày:";
            // 
            // labelDenNgay
            // 
            this.labelDenNgay.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelDenNgay.Location = new System.Drawing.Point(300, 38);
            this.labelDenNgay.Name = "labelDenNgay";
            this.labelDenNgay.Size = new System.Drawing.Size(58, 14);
            this.labelDenNgay.TabIndex = 5;
            this.labelDenNgay.Text = "Đến ngày:";
            // 
            // lblTongLoiNhuan
            // 
            this.lblTongLoiNhuan.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongLoiNhuan.Location = new System.Drawing.Point(450, 410);
            this.lblTongLoiNhuan.Name = "lblTongLoiNhuan";
            this.lblTongLoiNhuan.Size = new System.Drawing.Size(118, 16);
            this.lblTongLoiNhuan.TabIndex = 6;
            this.lblTongLoiNhuan.Text = "Tổng lợi nhuận:";
            // 
            // txtTongLoiNhuan
            // 
            this.txtTongLoiNhuan.Location = new System.Drawing.Point(580, 407);
            this.txtTongLoiNhuan.Name = "txtTongLoiNhuan";
            this.txtTongLoiNhuan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtTongLoiNhuan.Properties.Appearance.Options.UseFont = true;
            this.txtTongLoiNhuan.Properties.ReadOnly = true;
            this.txtTongLoiNhuan.Size = new System.Drawing.Size(200, 22);
            this.txtTongLoiNhuan.TabIndex = 7;
            // 
            // frmLoiNhuan
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.txtTongLoiNhuan);
            this.Controls.Add(this.lblTongLoiNhuan);
            this.Controls.Add(this.labelDenNgay);
            this.Controls.Add(this.labelTuNgay);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.gridLoiNhuan);
            this.Name = "frmLoiNhuan";
            this.Text = "Báo cáo lợi nhuận";
            ((System.ComponentModel.ISupportInitialize)(this.gridLoiNhuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLoiNhuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongLoiNhuan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridLoiNhuan;
        private DevExpress.XtraGrid.Views.Grid.GridView viewLoiNhuan;
        private DevExpress.XtraEditors.SimpleButton btnXemBaoCao;
        private DevExpress.XtraEditors.DateEdit dtTuNgay;
        private DevExpress.XtraEditors.DateEdit dtDenNgay;
        private DevExpress.XtraEditors.LabelControl labelTuNgay;
        private DevExpress.XtraEditors.LabelControl labelDenNgay;
        private DevExpress.XtraEditors.LabelControl lblTongLoiNhuan;
        private DevExpress.XtraEditors.TextEdit txtTongLoiNhuan;
    }
}
