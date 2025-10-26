using DoAnMonHoc.BUS;
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
        private NguoiDungService _service;
        public frmDangNhap()
        {
            InitializeComponent();
            _service = new NguoiDungService();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string maND = txtTK.Text.Trim();
            string matKhau = txtMK.Text.Trim();

            if (string.IsNullOrEmpty(maND) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nguoiDung = _service.DangNhap(maND, matKhau);

            if (nguoiDung != null)
            {
                // 👇 Truyền đối tượng người dùng vào form chính
                GiaoDien f = new GiaoDien(nguoiDung); // ✅ Giờ đây KHÔNG LỖI
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as GiaoDien).isThoat = false;
            (sender as GiaoDien).Close();
            this.Show();
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked) { txtMK.UseSystemPasswordChar = false; } else { txtMK.UseSystemPasswordChar = true; }
        }
    }
}
