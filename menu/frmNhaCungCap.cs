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
    public partial class frmNhaCungCap : Form
    {
        private readonly DoAnMonHoc.BUS.NhaCungCapService nccService = new DoAnMonHoc.BUS.NhaCungCapService();
        private string selectedMaNCC = null;

        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
        }
        private void LoadNhaCungCap()
        {
            dgvNhaCungCap.Rows.Clear();
            var list = nccService.GetAll();

            foreach (var ncc in list)
            {
                dgvNhaCungCap.Rows.Add(ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.DienThoai, ncc.Email);
            }
        }
        private void btnAddorUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text) || string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập đầy đủ mã và tên nhà cung cấp!");
                return;
            }

            var ncc = new NhaCungCap
            {
                MaNCC = txtMaNCC.Text.Trim(),
                TenNCC = txtTenNCC.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                DienThoai = txtDT.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            try
            {
                if (selectedMaNCC == null || nccService.GetById(ncc.MaNCC) == null)
                {
                    nccService.Add(ncc);
                    MessageBox.Show("✅ Thêm nhà cung cấp thành công!");
                }
                else
                {
                    nccService.Update(ncc);
                    MessageBox.Show("✅ Cập nhật nhà cung cấp thành công!");
                }

                LoadNhaCungCap();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaNCC == null)
            {
                MessageBox.Show("⚠️ Vui lòng chọn nhà cung cấp cần xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                nccService.Delete(selectedMaNCC);
                MessageBox.Show("✅ Xóa thành công!");
                LoadNhaCungCap();
                ResetForm();
            }
        }
        private void ResetForm()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtDT.Clear();
            txtEmail.Clear();
            selectedMaNCC = null;
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedMaNCC = dgvNhaCungCap.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaNCC.Text = selectedMaNCC;
                txtTenNCC.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDT.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void grpbxThongTinNCC_Enter(object sender, EventArgs e)
        {

        }
    }
}
