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
    public partial class frmBaoCaoPTBanCap : Form
    {
        public frmBaoCaoPTBanCap()
        {
            InitializeComponent();
        }

        private void frmBaoCaoPTBanCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPTBanCap.PhuTung' table. You can move, or remove it, as needed.
            this.PhuTungTableAdapter.Fill(this.dsPTBanCap.PhuTung);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
