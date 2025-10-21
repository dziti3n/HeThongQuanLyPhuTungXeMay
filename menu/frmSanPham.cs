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
    public partial class frmSanPham : Form
    {
       private readonly DoAnMonHoc.BUS.PhuTungService phuTungService = new DoAnMonHoc.BUS.PhuTungService();
       private string selectedMaPT = null;
        public frmSanPham()
        {
            InitializeComponent();
            
        }

        private void LoadPhuTung()
        {
            dgvPhuTung.Rows.Clear();
            var list = phuTungService.GetAllPhuTung();

            foreach (var pt in list)
            {
                dgvPhuTung.Rows.Add(pt.MaPT, pt.TenPT, pt.LoaiHang?.TenLoai, pt.DonViTinh, pt.DonGia, pt.SoLuongTon);
            }

            lblTong.Text = $"Tổng hàng tồn: {list.Sum(p => p.SoLuongTon)}";
        }
        private void LoadLoaiPhuTung()
        {
            XeMayContextDB context = new XeMayContextDB();
            var loaiList = context.LoaiHangs.ToList();
            cmbLoaiPT.DataSource = loaiList;
            cmbLoaiPT.DisplayMember = "TenLoai";
            cmbLoaiPT.ValueMember = "MaLoai";
        }

        private void LoadDonViTinh()
        {
            cmbDonViTinh.Items.Clear();
            cmbDonViTinh.Items.AddRange(new string[] { "Cái", "Chai", "Cặp", "Bộ", "Lít" });
        }


        private void txtMaPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoaiPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonViTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuongTon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã phụ tùng
            if (string.IsNullOrWhiteSpace(txtMaPT.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập mã phụ tùng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPT.Focus();
                return;
            }

            // Kiểm tra tên phụ tùng
            if (string.IsNullOrWhiteSpace(txtTenPT.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập tên phụ tùng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPT.Focus();
                return;
            }

            // Kiểm tra đơn vị tính
            if (string.IsNullOrWhiteSpace(cmbDonViTinh.Text))
            {
                MessageBox.Show("⚠️ Vui lòng chọn đơn vị tính!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDonViTinh.Focus();
                return;
            }

            // Kiểm tra loại phụ tùng
            if (cmbLoaiPT.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Vui lòng chọn loại phụ tùng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoaiPT.Focus();
                return;
            }

            // Kiểm tra đơn giá
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia <= 0)
            {
                MessageBox.Show("⚠️ Đơn giá phải là số lớn hơn 0!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // Kiểm tra số lượng tồn
            if (!int.TryParse(txtSoLuongTon.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("⚠️ Số lượng tồn phải là số nguyên ≥ 0!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongTon.Focus();
                return;
            }

            // Tạo đối tượng phụ tùng
            var pt = new PhuTung
            {
                MaPT = txtMaPT.Text.Trim(),
                TenPT = txtTenPT.Text.Trim(),
                DonViTinh = cmbDonViTinh.Text,
                DonGia = donGia,
                SoLuongTon = soLuong,
                MaLoai = cmbLoaiPT.SelectedValue.ToString()
            };

            // Thêm vào CSDL
            try
            {
                phuTungService.AddPhuTung(pt);
                MessageBox.Show("✅ Thêm phụ tùng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhuTung();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi thêm phụ tùng: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaPT == null)
            {
                MessageBox.Show("Vui lòng chọn phụ tùng cần xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                phuTungService.DeletePhuTung(selectedMaPT);
                MessageBox.Show("Xóa thành công!");
                LoadPhuTung();
                ResetForm();
            }   
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }
        private void ResetForm()
        {
            txtMaPT.Clear();
            txtTenPT.Clear();
            txtDonGia.Clear();
            txtSoLuongTon.Clear();
            cmbDonViTinh.SelectedIndex = -1;
            cmbLoaiPT.SelectedIndex = -1;
            selectedMaPT = null;
        }

        private void cmbDonViTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLoaiPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            var list = phuTungService.GetAllPhuTung()
                .Where(pt => pt.TenPT.Contains(keyword) || pt.MaPT.Contains(keyword))
                .ToList();

            dgvPhuTung.Rows.Clear();
            foreach (var pt in list)
            {
                dgvPhuTung.Rows.Add(pt.MaPT, pt.TenPT, pt.LoaiHang?.TenLoai, pt.DonViTinh, pt.DonGia, pt.SoLuongTon);
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "DanhSachPhuTung.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("MaPT,TenPT,LoaiPT,DonViTinh,DonGia,SoLuongTon");
                    foreach (DataGridViewRow row in dgvPhuTung.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sw.WriteLine($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value},{row.Cells[4].Value},{row.Cells[5].Value}");
                        }
                    }
                }

                MessageBox.Show("Xuất CSV thành công!");
            }
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadPhuTung();
            LoadLoaiPhuTung();
            LoadDonViTinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaPT == null)
            {
                MessageBox.Show("Vui lòng chọn phụ tùng cần sửa!");
                return;
            }

            var pt = phuTungService.GetAllPhuTung().FirstOrDefault(p => p.MaPT == selectedMaPT);
            if (pt != null)
            {
                pt.TenPT = txtTenPT.Text.Trim();
                pt.DonViTinh = cmbDonViTinh.Text;
                pt.DonGia = decimal.Parse(txtDonGia.Text);
                pt.SoLuongTon = int.Parse(txtSoLuongTon.Text);
                pt.MaLoai = cmbLoaiPT.SelectedValue.ToString();

                phuTungService.UpdatePhuTung(pt);
                MessageBox.Show("Cập nhật thành công!");
                LoadPhuTung();
                ResetForm();
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            var list = phuTungService.GetAllPhuTung()
                .Where(pt => pt.TenPT.Contains(keyword) || pt.MaPT.Contains(keyword))
                .ToList();

            dgvPhuTung.Rows.Clear();
            foreach (var pt in list)
            {
                dgvPhuTung.Rows.Add(pt.MaPT, pt.TenPT, pt.LoaiHang?.TenLoai, pt.DonViTinh, pt.DonGia, pt.SoLuongTon);
            }
        }

        private void dgvPhuTung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedMaPT = dgvPhuTung.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaPT.Text = selectedMaPT;
                txtTenPT.Text = dgvPhuTung.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbLoaiPT.Text = dgvPhuTung.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbDonViTinh.Text = dgvPhuTung.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDonGia.Text = dgvPhuTung.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSoLuongTon.Text = dgvPhuTung.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (selectedMaPT == null)
            {
                MessageBox.Show("Không có phụ tùng nào được chọn để lưu!");
                return;
            }

            var pt = phuTungService.GetAllPhuTung().FirstOrDefault(p => p.MaPT == selectedMaPT);
            if (pt != null)
            {
                pt.TenPT = txtTenPT.Text.Trim();
                pt.DonViTinh = cmbDonViTinh.Text;
                pt.DonGia = decimal.Parse(txtDonGia.Text);
                pt.SoLuongTon = int.Parse(txtSoLuongTon.Text);
                pt.MaLoai = cmbLoaiPT.SelectedValue.ToString();

                phuTungService.UpdatePhuTung(pt);
                MessageBox.Show("Lưu thành công!");
                LoadPhuTung();
                ResetForm();

            }
        }
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
