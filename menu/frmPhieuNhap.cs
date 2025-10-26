using DoAnMonHoc.BUS;
using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace menu
{
    public partial class frmPhieuNhap : Form
    {
        private DonDatHangService _service = new DonDatHangService();
        private List<ChiTietPhieuNhap> _chiTietList = new List<ChiTietPhieuNhap>();
        private string _maPhieuHienTai = "";

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maPhieuHienTai))
                MoFormMoi();
            else
                MoFormSua(_maPhieuHienTai);
        }

        // 🔹 Load danh sách Nhà cung cấp
        private void LoadDanhSachNhaCungCap()
        {
            using (var context = new PhuTungContextDB())
            {
                var dsNCC = context.NhaCungCaps
                    .OrderBy(n => n.TenNCC)
                    .Select(n => new { n.MaNCC, n.TenNCC })
                    .ToList();

                cmbNhaCungCap.DataSource = dsNCC;
                cmbNhaCungCap.DisplayMember = "TenNCC";
                cmbNhaCungCap.ValueMember = "MaNCC";
            }

            // tránh SelectedIndexChanged chạy khi chưa có dữ liệu Phụ tùng
            cmbNhaCungCap.SelectedIndexChanged -= cmbNhaCungCap_SelectedIndexChanged;
            cmbNhaCungCap.SelectedIndexChanged += cmbNhaCungCap_SelectedIndexChanged;
        }

        // Load danh sách phụ tùng theo MaNCC (gán cho cmbTenPhuTung)
        private void LoadDanhSachPhuTung(string maNCC)
        {
            if (string.IsNullOrEmpty(maNCC))
            {
                cmbTenPhuTung.DataSource = null;
                return;
            }

            using (var context = new PhuTungContextDB())
            {
                var dsPhuTung = context.PhuTungs
                    .Where(pt => pt.MaNCC == maNCC)
                    .OrderBy(pt => pt.TenPT)          // lưu ý tên property là TenPT
                    .Select(pt => new { pt.MaPT, pt.TenPT })
                    .ToList();

                cmbTenPhuTung.DataSource = dsPhuTung;
                cmbTenPhuTung.DisplayMember = "TenPT"; // phải đúng tên property
                cmbTenPhuTung.ValueMember = "MaPT";
            }
        }

        // 🔹 Khi chọn Nhà cung cấp → load lại danh sách phụ tùng
        private void cmbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Guard: event có thể chạy khi DataSource vừa thiết lập
            if (cmbNhaCungCap.SelectedValue == null) return;

            // Nếu SelectedValue là DataRowView thì ép kiểu cho đúng
            string maNCC = cmbNhaCungCap.SelectedValue.ToString();
            LoadDanhSachPhuTung(maNCC);
        }


        // 🔹 Mở form mới (tạo phiếu nhập mới)
        public void MoFormMoi()
        {
            _maPhieuHienTai = "";
            txtMaPhieu.Text = _service.SinhMaPhieuMoi();
            dtpNgayNhap.EditValue = DateTime.Now;
            _chiTietList.Clear();

            dgvDonDatHang.DataSource = null;
            dgvDonDatHang.DataSource = _chiTietList;

            LoadDanhSachNhaCungCap();
        }

        // 🔹 Mở form sửa (load dữ liệu phiếu nhập cũ)
        public void MoFormSua(string maPhieu)
        {
            _maPhieuHienTai = maPhieu;

            using (var context = new PhuTungContextDB())
            {
                var phieu = context.PhieuNhaps
                    .FirstOrDefault(p => p.MaPN == maPhieu);

                if (phieu == null) return;

                txtMaPhieu.Text = phieu.MaPN;
                dtpNgayNhap.EditValue = phieu.NgayNhap;
                cmbNhaCungCap.SelectedValue = phieu.MaNCC;

                _chiTietList = context.ChiTietPhieuNhaps
                    .Where(ct => ct.MaPN == maPhieu)
                    .ToList();

                dgvDonDatHang.DataSource = null;
                dgvDonDatHang.DataSource = _chiTietList;

                LoadDanhSachPhuTung(phieu.MaNCC);
            }
        }
        private void RefreshGrid()
        {
            // Nếu bạn muốn hiển thị tên phụ tùng trong DGV, join với PhuTung để lấy TenPT
            using (var context = new PhuTungContextDB())
            {
                var lookup = context.PhuTungs
                    .Select(p => new { p.MaPT, p.TenPT })
                    .ToDictionary(x => x.MaPT, x => x.TenPT);

                var source = _chiTietList.Select(ct => new
                {
                    ct.MaPN,
                    ct.MaPT,
                    TenPT = lookup.ContainsKey(ct.MaPT) ? lookup[ct.MaPT] : "",
                    ct.SoLuong,
                    ct.DonGiaNhap,
                    ThanhTien = ct.SoLuong * ct.DonGiaNhap
                }).ToList();

                dgvDonDatHang.AutoGenerateColumns = true; // hoặc false nếu bạn tự tạo cột
                dgvDonDatHang.DataSource = null;
                dgvDonDatHang.DataSource = source;
            }

            // cập nhật tổng tiền nếu cần
            // txtTongTien.Text = _chiTietList.Sum(x => x.SoLuong * x.DonGiaNhap).ToString("N0");
        }
        // 🔹 Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPT = cmbTenPhuTung.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maPT))
            {
                MessageBox.Show("Vui lòng chọn phụ tùng cần nhập.", "Thông báo");
                return;
            }

            if (_chiTietList.Any(x => x.MaPT == maPT))
            {
                MessageBox.Show("Phụ tùng đã có trong danh sách.", "Thông báo");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ.");
                return;
            }

            _chiTietList.Add(new ChiTietPhieuNhap
            {
                MaPN = txtMaPhieu.Text,
                MaPT = maPT,
                SoLuong = soLuong,
                DonGiaNhap = donGia
            });

            RefreshGrid();
        }

        // 🔹 Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDonDatHang.CurrentRow != null)
            {
                string maPT = dgvDonDatHang.CurrentRow.Cells["MaPT"].Value.ToString();
                var item = _chiTietList.FirstOrDefault(x => x.MaPT == maPT);
                if (item != null)
                {
                    _chiTietList.Remove(item);
                    dgvDonDatHang.DataSource = null;
                    dgvDonDatHang.DataSource = _chiTietList;
                }
            }
        }

        // 🔹 Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 🔹 Nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (_chiTietList.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm ít nhất 1 phụ tùng vào phiếu nhập.");
                    return;
                }

                using (var context = new PhuTungContextDB())
                {
                    var phieu = new PhieuNhap
                    {
                        MaPN = txtMaPhieu.Text,
                        NgayNhap = Convert.ToDateTime(dtpNgayNhap.EditValue),
                        MaNCC = cmbNhaCungCap.SelectedValue.ToString(),
                        TongTien = _chiTietList.Sum(x => x.SoLuong * x.DonGiaNhap)
                    };

                    context.PhieuNhaps.Add(phieu);

                    foreach (var ct in _chiTietList)
                    {
                        context.ChiTietPhieuNhaps.Add(ct);

                        var phuTung = context.PhuTungs.FirstOrDefault(p => p.MaPT == ct.MaPT);
                        if (phuTung != null)
                            phuTung.SoLuong += ct.SoLuong;
                    }

                    context.SaveChanges();
                }

                MessageBox.Show("Đã lưu phiếu nhập thành công!", "Thành công");
                MoFormMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu nhập: " + ex.Message);
            }
        }

        
    }
}
