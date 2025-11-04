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
    public partial class frmPTBanCap : Form
    {
        public frmPTBanCap()
        {
            InitializeComponent();
        }

        private void frmPTBanCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPTBanTheoCap.PhuTung' table. You can move, or remove it, as needed.
            this.PhuTungTableAdapter.Fill(this.dsPTBanTheoCap.PhuTung);

            this.reportViewer1.RefreshReport();
        }
    }
}
