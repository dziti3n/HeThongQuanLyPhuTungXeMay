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
        private List<ChiTietDonDatHang> _chiTietList = new List<ChiTietDonDatHang>();
        private string _maPhieuHienTai = "";

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            
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
       

        // 🔹 Mở form sửa (load dữ liệu phiếu nhập cũ)
       
        
        // 🔹 Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            
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
           
        }

        
    }
}
