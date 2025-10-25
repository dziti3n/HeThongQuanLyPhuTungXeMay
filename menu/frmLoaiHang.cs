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
    public partial class frmLoaiHang : Form
    {
        private readonly LoaiHangService loaiHangService = new LoaiHangService();
        private string selectedMaLoai = null;

        public frmLoaiHang()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();       
            selectedMaLoai = null;
        }

        private void dgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedMaLoai = dgvLoaiHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaLoai.Text = selectedMaLoai;
                txtTenLoai.Text = dgvLoaiHang.Rows[e.RowIndex].Cells[1].Value.ToString();
               
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            var list = loaiHangService.GetAllLoaiHang()
                .Where(lh => lh.TenLoai.Contains(keyword) || lh.MaLoai.Contains(keyword))
                .ToList();

            dgvLoaiHang.Rows.Clear();
            foreach (var lh in list)
            {
                dgvLoaiHang.Rows.Add(lh.MaLoai, lh.TenLoai);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaLoai == null)
            {
                MessageBox.Show("⚠️ Vui lòng chọn loại hàng cần sửa!");
                return;
            }

            var lh = loaiHangService.GetAllLoaiHang().FirstOrDefault(l => l.MaLoai == selectedMaLoai);
            if (lh != null)
            {
                lh.TenLoai = txtTenLoai.Text.Trim();
              

                loaiHangService.UpdateLoaiHang(lh);
                MessageBox.Show("✅ Cập nhật thành công!");
                LoadLoaiHang();
                ResetForm();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaLoai == null)
            {
                MessageBox.Show("⚠️ Vui lòng chọn loại hàng cần xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                loaiHangService.DeleteLoaiHang(selectedMaLoai);
                MessageBox.Show("✅ Xóa thành công!");
                LoadLoaiHang();
                ResetForm();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void LoadLoaiHang()
        {
            dgvLoaiHang.Rows.Clear();
            var list = loaiHangService.GetAllLoaiHang();

            foreach (var lh in list)
            {
                dgvLoaiHang.Rows.Add(lh.MaLoai, lh.TenLoai);
            }
        }

        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            LoadLoaiHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập mã loại hàng!");
                txtMaLoai.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập tên loại hàng!");
                txtTenLoai.Focus();
                return;
            }

            var lh = new LoaiHang
            {
                MaLoai = txtMaLoai.Text.Trim(),
                TenLoai = txtTenLoai.Text.Trim(),
            };

            try
            {
                loaiHangService.AddLoaiHang(lh);
                MessageBox.Show("✅ Thêm loại hàng thành công!");
                LoadLoaiHang();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi thêm: " + ex.Message);
            }
        }
    }
}
