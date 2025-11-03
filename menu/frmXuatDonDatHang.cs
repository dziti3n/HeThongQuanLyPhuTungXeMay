using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class frmXuatDonDatHang : Form
    {
        public frmXuatDonDatHang()
        {
            InitializeComponent();
        }

        private void frmXuatDonDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'XuatPhieuNhap.DonDatHang' table. You can move, or remove it, as needed.
            this.DonDatHangTableAdapter.Fill(this.XuatPhieuNhap.DonDatHang);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
