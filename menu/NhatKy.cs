using DevExpress.Data.NetCompatibility.Extensions;
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
    public partial class NhatKy : Form
    {
        private readonly DoAnMonHoc.BUS.NhatKyService nhatKyService = new DoAnMonHoc.BUS.NhatKyService();
        public NhatKy()
        {
            InitializeComponent();
        }

        private void dgvNhatKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BindGrid(string tuKhoa = "")
        {

        }
        private void frmNhatKy_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
