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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string username = txtTK.Text.Trim();
            string password = txtMK.Text.Trim();
            string confirm = txtXN.Text.Trim();
            if (username == "" || password == "" || confirm == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new frmDangNhap().ShowDialog();
            this.Close();
        }

        private void lblDN_Click(object sender, EventArgs e)
        {
            new frmDangNhap().ShowDialog();
            this.Close();
        }

        private void lblDN_MouseHover(object sender, EventArgs e)
        {
            lblDN.Font = new Font(lblDN.Font, FontStyle.Underline);
            lblDN.Cursor = Cursors.Hand;
        }

        private void lblDN_MouseLeave(object sender, EventArgs e)
        {
            lblDN.Font = new Font(lblDN.Font, FontStyle.Regular);
            lblDN.Cursor = Cursors.Default;
        }
    }
}
