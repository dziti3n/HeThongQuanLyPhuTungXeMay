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
        private readonly CTDonDatHangService CTDonDatHangService = new CTDonDatHangService();
        private readonly List<ChiTietDonDatHang> chiTietTam = new List<ChiTietDonDatHang>();
        private string _nccDangChon = null;
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
                if (cmbNhaCungCap.SelectedValue == null) return;

                string maNCCMoi = cmbNhaCungCap.SelectedValue.ToString();

                // Nếu chưa chọn NCC nào trước đó, gán luôn
                if (_nccDangChon == null)
                {
                    _nccDangChon = maNCCMoi;
                    LoadPhuTungTheoNCC(maNCCMoi);
                    return;
                }

                // Nếu đổi NCC khi đã có dữ liệu trong giỏ hàng
                if (maNCCMoi != _nccDangChon)
                {
                    if (dgvDonDatHang.Rows.Count > 0)
                    {
                        var result = MessageBox.Show(
                            "Bạn đang có dữ liệu trong giỏ hàng. Đổi nhà cung cấp sẽ xóa toàn bộ dữ liệu này. Bạn có chắc không?",
                            "Xác nhận đổi nhà cung cấp",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.No)
                        {
                            // Giữ nguyên NCC cũ
                            cmbNhaCungCap.SelectedValue = _nccDangChon;
                            return;
                        }
                    }

                    // Nếu đồng ý đổi → reset giỏ hàng & load lại phụ tùng
                    dgvDonDatHang.Rows.Clear();
                    _nccDangChon = maNCCMoi;
                    LoadPhuTungTheoNCC(maNCCMoi);
                }
            }
        }
        private void cmbTenPhuTung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenPhuTung.SelectedIndex >= 0)
            {
                var pt = (PhuTung)cmbTenPhuTung.SelectedItem; // ✅ đúng kiểu

                using (var context = new PhuTungContextDB())
                {
                    // Lấy đơn giá nhập mới nhất của phụ tùng đó
                    var giaNhapGanNhat = (from ct in context.ChiTietDonDatHangs
                                          join ddh in context.DonDatHangs on ct.MaDDH equals ddh.MaDDH
                                          where ct.MaPT == pt.MaPT
                                          orderby ddh.NgayDat descending
                                          select ct.DonGiaNhap)
                                          .FirstOrDefault();

                    txtDonGia.Text = giaNhapGanNhat != null ? giaNhapGanNhat.ToString() : "0";
                }
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

        private void LoadPhuTungTheoNCC(string maNCC)
        {
            // Lấy danh sách phụ tùng của NCC được chọn
            var listPhuTung = phuTungService.GetAllPhuTung()
                                            .Where(pt => pt.MaNCC == maNCC)
                                            .ToList();

            // Gán vào combobox phụ tùng
            cmbTenPhuTung.DataSource = listPhuTung;
            cmbTenPhuTung.DisplayMember = "TenPT";
            cmbTenPhuTung.ValueMember = "MaPT";
            cmbTenPhuTung.SelectedIndex = -1;

            // Xóa thông tin đơn giá cũ
            txtDonGia.Text = "";
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

            decimal donGiaNhap;
            if (!decimal.TryParse(txtDonGia.Text, out donGiaNhap))
            {
                MessageBox.Show("Đơn giá nhập không hợp lệ!");
                return;
            }


            // Thêm vào DataGridView
            int index = dgvDonDatHang.Rows.Add();
            dgvDonDatHang.Rows[index].Cells[0].Value = pt.TenPT;
            dgvDonDatHang.Rows[index].Cells[1].Value = soLuong;
            dgvDonDatHang.Rows[index].Cells[2].Value = donGiaNhap;

            // Lưu tạm để sau ghi xuống DB
            chiTietTam.Add(new ChiTietDonDatHang
            {
                MaPT = pt.MaPT,
                SoLuong = soLuong,
                DonGiaNhap = donGiaNhap
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
                MaND = LuuNV.MaNguoiDung,
                NgayDat = DateTime.Now,
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


