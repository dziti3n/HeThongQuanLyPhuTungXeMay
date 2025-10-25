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

            // THÊM: Gọi service để kiểm tra đăng nhập
            var nguoiDung = _service.DangNhap(maND, matKhau);

            if (nguoiDung != null)
            {
                // THÊM: Kiểm tra tài khoản có bị khoá không (nếu bạn có cột KhoaTaiKhoan)
                // Nếu chưa có, bỏ qua dòng dưới
                // if (nguoiDung.KhoaTaiKhoan) { ... }

                // THAY THẾ: Mở GiaoDien như cũ
                GiaoDien f = new GiaoDien();
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
            }
            else
            {
                // THÊM: Thông báo sai mật khẩu
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
