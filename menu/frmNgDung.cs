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
        public frmNgDung()
        {
            InitializeComponent();
        }

        private void frmNgDung_Load(object sender, EventArgs e)
        {
            try
            {
                _service = new NguoiDungService();
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataGrid(string keyword = null)
        {
            var list = _service.GetAllNguoiDung();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.ToLower();
                list = list.Where(nd =>
                    nd.MaND.ToLower().Contains(keyword) ||
                    nd.HoTen?.ToLower().Contains(keyword) == true ||
                    nd.SDT?.Contains(keyword) == true ||
                    nd.Email?.ToLower().Contains(keyword) == true
                ).ToList();
            }

            dgvNguoiDung.Rows.Clear();
            foreach (var nd in list)
            {
                int index = dgvNguoiDung.Rows.Add();
                dgvNguoiDung.Rows[index].Cells["MaND"].Value = nd.MaND;
                dgvNguoiDung.Rows[index].Cells["HoTen"].Value = nd.HoTen;
                dgvNguoiDung.Rows[index].Cells["MatKhau"].Value = nd.MatKhau;
                dgvNguoiDung.Rows[index].Cells["Admin"].Value = nd.Admin;
                dgvNguoiDung.Rows[index].Cells["SDT"].Value = nd.SDT;
                dgvNguoiDung.Rows[index].Cells["Email"].Value = nd.Email;
            }

            txtTong.Text = list.Count.ToString();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtTaiKhoan.Text.Length > 5)
            {
                MessageBox.Show("Mã người dùng không được vượt quá 5 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            txtTaiKhoan.Clear();
            txtTenNV.Clear();
            txtMatKhau.Clear();
            chkAdmin.Checked = false;
            txtSDT.Clear();
            txtEmail.Clear();
        }   

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string maND = txtTaiKhoan.Text.Trim();
            var existing = _service.GetNguoiDungByMaND(maND);

            if (existing == null)
            {
                // ➤ Thêm mới
                var nguoiDung = new NguoiDung
                {
                    MaND = maND,
                    MatKhau = txtMatKhau.Text.Trim(),
                    HoTen = txtTenNV.Text.Trim(),
                    Admin = chkAdmin.Checked,
                    SDT = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                if (_service.ThemNguoiDung(nguoiDung))
                {
                    LoadDataGrid();
                    ResetForm();
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại! Mã người dùng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // ➤ Cập nhật
                existing.MatKhau = txtMatKhau.Text.Trim();
                existing.HoTen = txtTenNV.Text.Trim();
                existing.Admin = chkAdmin.Checked;
                existing.SDT = txtSDT.Text.Trim();
                existing.Email = txtEmail.Text.Trim();

                if (_service.CapNhatNguoiDung(existing))
                {
                    LoadDataGrid();
                    ResetForm();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maND = txtTaiKhoan.Text.Trim();
            if (string.IsNullOrEmpty(maND))
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nguoiDung = _service.GetNguoiDungByMaND(maND);
            if (nguoiDung == null)
            {
                MessageBox.Show("Người dùng cần xóa không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_service.XoaNguoiDung(maND))
                {
                    LoadDataGrid();
                    ResetForm();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xóa! Người dùng này đang liên quan đến hóa đơn hoặc phiếu nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDataGrid(txtTimKiem.Text.Trim());
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvNguoiDung.Rows[e.RowIndex];
            txtTaiKhoan.Text = row.Cells["MaND"].Value?.ToString() ?? "";
            txtTenNV.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
            txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString() ?? "";
            chkAdmin.Checked = row.Cells["Admin"].Value != null && (bool)row.Cells["Admin"].Value;
            txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
        }
    }
}
