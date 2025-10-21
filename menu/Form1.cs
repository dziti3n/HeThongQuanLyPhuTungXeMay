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

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked)
            {
                txtMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtMK.UseSystemPasswordChar = true;
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string username = txtTK.Text.Trim();
            string password = txtMK.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblDK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui Lòng Liên Hệ Chủ Sở Hữu", "Thông báo");
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hết Cứu!", "Thông báo");
        }

        private void lblDK_MouseHover(object sender, EventArgs e)
        {
            lblDK.Font = new Font(lblDK.Font, FontStyle.Underline);
            lblDK.Cursor = Cursors.Hand;
        }

        private void lblDK_MouseLeave(object sender, EventArgs e)
        {
            lblDK.Font = new Font(lblDK.Font, FontStyle.Regular);
            lblDK.Cursor = Cursors.Default;
        }
    }
}
