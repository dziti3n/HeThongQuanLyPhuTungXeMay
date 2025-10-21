namespace menu
{
    partial class frmTraHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLiDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaHD,
            this.ColumnTenSP,
            this.ColumnLiDo,
            this.ColumnNgayTra});
            this.dataGridView1.Location = new System.Drawing.Point(329, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 312);
            this.dataGridView1.TabIndex = 8;
            // 
            // ColumnMaHD
            // 
            this.ColumnMaHD.HeaderText = "Mã hóa đơn";
            this.ColumnMaHD.MinimumWidth = 6;
            this.ColumnMaHD.Name = "ColumnMaHD";
            this.ColumnMaHD.Width = 125;
            // 
            // ColumnTenSP
            // 
            this.ColumnTenSP.HeaderText = "Tên sản phẩm";
            this.ColumnTenSP.MinimumWidth = 6;
            this.ColumnTenSP.Name = "ColumnTenSP";
            this.ColumnTenSP.Width = 125;
            // 
            // ColumnLiDo
            // 
            this.ColumnLiDo.HeaderText = "Lí do";
            this.ColumnLiDo.MinimumWidth = 6;
            this.ColumnLiDo.Name = "ColumnLiDo";
            this.ColumnLiDo.Width = 125;
            // 
            // ColumnNgayTra
            // 
            this.ColumnNgayTra.HeaderText = "Ngày trả";
            this.ColumnNgayTra.MinimumWidth = 6;
            this.ColumnNgayTra.Name = "ColumnNgayTra";
            this.ColumnNgayTra.Width = 125;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.dateEdit2);
            this.groupControl1.Controls.Add(this.textEdit4);
            this.groupControl1.Controls.Add(this.textEdit5);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Location = new System.Drawing.Point(33, 64);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(251, 273);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Thông tin trả hàng";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(113, 213);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(125, 22);
            this.dateEdit2.TabIndex = 15;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(113, 155);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(125, 22);
            this.textEdit4.TabIndex = 14;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(113, 96);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(125, 22);
            this.textEdit5.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 216);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 16);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Ngày trả";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(34, 158);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(27, 16);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Lí do";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 99);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 16);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Tên sản phẩm";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(28, 44);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(67, 16);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Mã hóa đơn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(834, 392);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 16);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Số tiền trả cho khách";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(962, 389);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(125, 22);
            this.textEdit1.TabIndex = 14;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(112, 42);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(125, 22);
            this.textEdit2.TabIndex = 16;
            // 
            // frmTraHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 450);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTraHang";
            this.Text = "frmTraHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLiDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgayTra;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}