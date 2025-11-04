using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace menu
{
    public partial class frmThongKeTonKho : Form
    {
        public frmThongKeTonKho()
        {
            InitializeComponent();
        }

        private void frmThongKeTonKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TonKhoDataSet.PhuTung' table. You can move, or remove it, as needed.
            this.PhuTungTableAdapter.Fill(this.TonKhoDataSet.PhuTung);
            int tongSoLuong = 0;
            foreach (TonKhoDataSet.PhuTungRow row in TonKhoDataSet.PhuTung.Rows)
            {
                tongSoLuong += row.SoLuong;
            }

            ReportParameter para = new ReportParameter("txtSoLgTon", tongSoLuong.ToString());
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
