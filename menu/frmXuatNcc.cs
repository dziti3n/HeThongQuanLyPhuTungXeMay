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
    public partial class frmXuatNcc : Form
    {
        public frmXuatNcc()
        {
            InitializeComponent();
        }

        private void frmXuatNcc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'XuatNcc.NhaCungCap' table. You can move, or remove it, as needed.
            this.NhaCungCapTableAdapter.Fill(this.XuatNcc.NhaCungCap);

            this.reportViewer1.RefreshReport();
        }
    }
}
