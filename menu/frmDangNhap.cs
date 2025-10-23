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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            GiaoDien f = new GiaoDien();
            f.Show();
            this.Hide();
            f.DangXuat += F_DangXuat;
        }

        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as GiaoDien).isThoat = false;
            (sender as GiaoDien).Close();
            this.Show();
        }

        //bool KiemTraDangNhap(string TaiKhoan, string MatKhau)
        //{
            
        //}

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked) { txtMK.UseSystemPasswordChar = false; } else { txtMK.UseSystemPasswordChar = true; }
        }
    }
}
