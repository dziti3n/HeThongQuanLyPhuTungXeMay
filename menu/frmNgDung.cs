using DoAnMonHoc.BUS;
using DoAnMonHoc.DAL.Model;
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
    public partial class frmNgDung : Form
    {
        private NguoiDungService _service;
        private bool _isAdding = false; // Đang thêm mới?
        private string _currentMaND = ""; // Mã ND đang chọn để sửa/xóa/khóa
        public frmNgDung()
        {
            InitializeComponent();
            _service = new NguoiDungService();
        }

        private void frmNgDung_Load(object sender, EventArgs e)
        {
            LoadDanhSachNguoiDung();
            ResetForm();
        }

        private void LoadDanhSachNguoiDung()
        {
            var list = _service.GetAllNguoiDung()
                .Select(nd => new
                {
                    MaND = nd.MaND,
                    HoTen = nd.HoTen,
                    MatKhau = nd.MatKhau,
                    Admin = nd.Admin,
                    SDT = nd.SDT,
                    Email = nd.Email
                })
                .ToList();

            dgvNguoiDung.DataSource = list;

            // Cấu hình tiêu đề cột
            dgvNguoiDung.Columns["MaND"].HeaderText = "Tài khoản";
            dgvNguoiDung.Columns["HoTen"].HeaderText = "Tên NV";
            dgvNguoiDung.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            dgvNguoiDung.Columns["Admin"].HeaderText = "Quản Trị";
            dgvNguoiDung.Columns["SDT"].HeaderText = "SĐT";
            dgvNguoiDung.Columns["Email"].HeaderText = "Email";

            // Đặt thứ tự cột (nếu cần)
            dgvNguoiDung.Columns["Admin"].DisplayIndex = 3;

            // Ẩn cột "Khoa" nếu có
            if (dgvNguoiDung.Columns.Contains("Khoa"))
                dgvNguoiDung.Columns["Khoa"].Visible = false;

            txtTong.Text = list.Count.ToString();
        }

        // Làm sạch form nhập liệu
        private void ResetForm()
        {
            txtTaiKhoan.Clear();
            txtTenNV.Clear();
            txtMatKhau.Clear();
            chkAdmin.Checked = false;
            txtSDT.Clear();
            txtEmail.Clear();

            txtTaiKhoan.Enabled = true;
            _isAdding = false;
            _currentMaND = "";
        }

        // Lấy dữ liệu từ form để tạo hoặc cập nhật đối tượng NguoiDung
        private NguoiDung GetNguoiDungFromForm()
        {
            return new NguoiDung
            {
                MaND = txtTaiKhoan.Text.Trim(),
                MatKhau = txtMatKhau.Text.Trim(),
                HoTen = txtTenNV.Text.Trim(),
                Admin = chkAdmin.Checked,
                SDT = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (_isAdding || string.IsNullOrEmpty(_currentMaND))
            {
                // Chuyển sang chế độ thêm mới
                ResetForm();
                txtTaiKhoan.Focus();
                _isAdding = true;
                txtTaiKhoan.Enabled = true;
            }
            else
            {
                // Chuyển sang chế độ sửa
                txtTaiKhoan.Enabled = false;
                _isAdding = false;
                txtMatKhau.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentMaND))
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa người dùng '{_currentMaND}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_service.XoaNguoiDung(_currentMaND))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNguoiDung();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Không thể xóa người dùng này! Có thể do đang có hóa đơn hoặc phiếu nhập liên quan.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nguoiDung = GetNguoiDungFromForm();

            if (_isAdding)
            {
                if (_service.ThemNguoiDung(nguoiDung))
                {
                    MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNguoiDung();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại! Mã người dùng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (_service.CapNhatNguoiDung(nguoiDung))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNguoiDung();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadDanhSachNguoiDung();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            var ketQua = _service.TimKiemNguoiDung(tuKhoa)
                .Select(nd => new
                {
                    MaND = nd.MaND,
                    HoTen = nd.HoTen,
                    MatKhau = nd.MatKhau,
                    Admin = nd.Admin,
                    SDT = nd.SDT,
                    Email = nd.Email
                })
                .ToList();

            dgvNguoiDung.DataSource = ketQua;
            txtTong.Text = ketQua.Count.ToString();

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy người dùng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNguoiDung.SelectedRows.Count > 0)
            {
                var row = dgvNguoiDung.SelectedRows[0];
                var nd = row.DataBoundItem as NguoiDung;

                if (nd != null)
                {
                    txtTaiKhoan.Text = nd.MaND;
                    txtTenNV.Text = nd.HoTen;
                    txtMatKhau.Text = nd.MatKhau;
                    chkAdmin.Checked = nd.Admin;
                    txtSDT.Text = nd.SDT;
                    txtEmail.Text = nd.Email;

                    _currentMaND = nd.MaND;
                    txtTaiKhoan.Enabled = false;
                }
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
