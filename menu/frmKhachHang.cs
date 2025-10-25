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
    public partial class frmKhachHang : Form
    {
       
        private readonly KhachHangService _service = new KhachHangService();
        private readonly KhachHangService khachHangService = new KhachHangService();
        private string selectedMaKH = null;

        public frmKhachHang()
        {
            InitializeComponent();
            
        }  
        private void frmKhachHang_Load_1(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            dgvThongTinKH.Rows.Clear();
            var list = khachHangService.GetAllKhachHang();

            foreach (var kh in list)
            {
                dgvThongTinKH.Rows.Add(kh.MaKH, kh.TenKH, kh.DienThoai, kh.DiaChi, kh.Email);
            }

            lblTongKH.Text = $"Tổng số khách hàng: {list.Count}";
        }



        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            var list = khachHangService.Search(keyword);

            dgvThongTinKH.Rows.Clear();
            foreach (var kh in list)
            {
                dgvThongTinKH.Rows.Add(kh.MaKH, kh.TenKH, kh.DiaChi, kh.DienThoai, kh.Email);
            }

            lblTongKH.Text = $"Tìm thấy: {list.Count}";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(txtMaKhachHang.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập mã khách hàng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập tên khách hàng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhachHang.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập số điện thoại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (!txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("⚠️ Số điện thoại chỉ được chứa chữ số!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("⚠️ Vui lòng nhập email hợp lệ!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (khachHangService.FindById(txtMaKhachHang.Text) != null)
            {
                MessageBox.Show("❌ Mã khách hàng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng
            var kh = new KhachHang
            {
                MaKH = txtMaKhachHang.Text.Trim(),
                TenKH = txtTenKhachHang.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                DienThoai = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            // Thêm vào DB
            try
            {
                khachHangService.AddKhachHang(kh);
                MessageBox.Show("✅ Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (selectedMaKH == null)
            {
                MessageBox.Show("⚠️ Vui lòng chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kh = khachHangService.FindById(selectedMaKH);
            if (kh != null)
            {
                kh.TenKH = txtTenKhachHang.Text.Trim();
                kh.DiaChi = txtDiaChi.Text.Trim();
                kh.DienThoai = txtSDT.Text.Trim();
                kh.Email = txtEmail.Text.Trim();

                khachHangService.UpdateKhachHang(kh);
                MessageBox.Show("✅ Cập nhật khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
                ResetForm();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (selectedMaKH == null)
            {
                MessageBox.Show("⚠️ Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                khachHangService.DeleteKhachHang(selectedMaKH);
                MessageBox.Show("✅ Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
                ResetForm();
            }
        }

        private void dgvThongTinKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThongTinKH.Rows[e.RowIndex];
                txtMaKhachHang.Text = row.Cells[0].Value.ToString();
                txtTenKhachHang.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                selectedMaKH = row.Cells[0].Value.ToString();
            }
        }
        private void ResetForm()
        {
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtTimKiem.Clear();
            selectedMaKH = null;
        }
    }
}
