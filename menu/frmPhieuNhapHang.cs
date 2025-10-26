using DoAnMonHoc.BUS;
using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace menu
{
    public partial class frmPhieuNhapHang : Form
    {
        private readonly NhaCungCapService nhaCungCapService = new NhaCungCapService();
        private readonly PhuTungService phuTungService = new PhuTungService();
        private readonly DonDatHangService donDatHangService = new DonDatHangService();


        private readonly List<ChiTietDonDatHang> chiTietTam = new List<ChiTietDonDatHang>();
        public frmPhieuNhapHang()
        {
            InitializeComponent();
        }

        private void frmPhieuNhapHang_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            dgvDonDatHang.Rows.Clear();
        }
        private void LoadNhaCungCap()
        {
            var listNCC = nhaCungCapService.GetAll();
            cmbNhaCungCap.DataSource = listNCC;
            cmbNhaCungCap.DisplayMember = "TenNCC";
            cmbNhaCungCap.ValueMember = "MaNCC";
            cmbNhaCungCap.SelectedIndex = -1;
        }
        private void cmbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNhaCungCap.SelectedIndex >= 0)
            {
                string maNCC = cmbNhaCungCap.SelectedValue.ToString();
                var listPhuTung = phuTungService.GetAllPhuTung()
                                                .Where(pt => pt.MaNCC == maNCC)
                                                .ToList();

                cmbTenPhuTung.DataSource = listPhuTung;
                cmbTenPhuTung.DisplayMember = "TenPT";
                cmbTenPhuTung.ValueMember = "MaPT";
                cmbTenPhuTung.SelectedIndex = -1;

                txtDonGia.Text = "";
            }
        }
        private void cmbTenPhuTung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenPhuTung.SelectedIndex >= 0)
            {
                var pt = (PhuTung)cmbTenPhuTung.SelectedItem;
                txtDonGia.Text = pt.DonGia.ToString(); // Lấy giá bán hoặc giá nhập tùy DB
            }
        }
        public string GenerateNewMaDDH()
        {
            using (var context = new PhuTungContextDB())
            {
                // Lấy mã lớn nhất hiện có (ví dụ PN001, PN002, ...)
                var last = context.DonDatHangs
                    .OrderByDescending(p => p.MaDDH)
                    .Select(p => p.MaDDH)
                    .FirstOrDefault();

                int number = 0;
                if (!string.IsNullOrEmpty(last) && last.Length > 2)
                {
                    int.TryParse(last.Substring(2), out number);
                }

                // Tăng số lên 1
                number++;

                // Sinh mã mới: PN + số có 3 chữ số
                return $"PN{number:D3}";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbTenPhuTung.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phụ tùng!");
                return;
            }

            var pt = (PhuTung)cmbTenPhuTung.SelectedItem;
            int soLuong;
            if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            decimal donGia = pt.DonGia ?? 0;
            

            // Thêm vào DataGridView
            int index = dgvDonDatHang.Rows.Add();
            dgvDonDatHang.Rows[index].Cells[0].Value = pt.TenPT;
            dgvDonDatHang.Rows[index].Cells[1].Value = soLuong;
            dgvDonDatHang.Rows[index].Cells[2].Value = donGia;

            // Lưu tạm để sau ghi xuống DB
            chiTietTam.Add(new ChiTietDonDatHang
            {
                MaPT = pt.MaPT,
                SoLuong = soLuong,
                DonGiaNhap = donGia
            });

            // reset
            cmbTenPhuTung.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            GenerateNewMaDDH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDonDatHang.CurrentRow != null)
            {
                int index = dgvDonDatHang.CurrentRow.Index;
                if (index >= 0 && index < chiTietTam.Count)
                {
                    chiTietTam.RemoveAt(index);
                    dgvDonDatHang.Rows.RemoveAt(index);
                }
            }
            if (dgvDonDatHang.CurrentRow != null)
            {
                int index = dgvDonDatHang.CurrentRow.Index;
                if (index >= 0 && index < chiTietTam.Count)
                {
                    chiTietTam.RemoveAt(index);
                    dgvDonDatHang.Rows.RemoveAt(index);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbNhaCungCap.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
                return;
            }

            if (chiTietTam.Count == 0)
            {
                MessageBox.Show("Chưa có chi tiết để lưu!");
                return;
            }

            string maDDH = GenerateNewMaDDH();

            DonDatHang donDatHang = new DonDatHang
            {
                MaDDH = maDDH,
                MaNCC = cmbNhaCungCap.SelectedValue.ToString(),
                
            };

            // Lưu đơn đặt hàng
            donDatHangService.Add(donDatHang);

            // Lưu chi tiết
            using (var context = new PhuTungContextDB())
            {
                foreach (var ct in chiTietTam)
                {
                    ct.MaDDH = maDDH;
                    context.ChiTietDonDatHangs.Add(ct);
                }
                context.SaveChanges();
            }

            MessageBox.Show($"Lưu thành công! Mã phiếu: {maDDH}");
            chiTietTam.Clear();
            dgvDonDatHang.Rows.Clear();
        }
    }
    
}


