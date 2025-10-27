using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
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
    public partial class frmXuatHoaDon : Form
    {

        private readonly HoaDonService hoaDonService = new HoaDonService();
        private readonly ChiTietHoaDonService chiTietService = new ChiTietHoaDonService();


        private string selectedMaHD = null;
        public frmXuatHoaDon()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmXuatHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            dgvChiTietHoaDon.Visible = false;
            
        }

        private void LoadHoaDon()
        {
            dgvThongTin.Rows.Clear();
            var list = hoaDonService.GetAll();

            foreach (var hd in list)
            {
                dgvThongTin.Rows.Add(
                    hd.MaHD,
                    hd.MaKH,
                    hd.MaND,
                    hd.NgayLap?.ToString("dd/MM/yyyy"),
                    hd.TongTien                 
                    
                    
                );
            }

            lblTongSoHD.Text = $"Tổng số hóa đơn: {list.Count}";
        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.Visible = true;
            string maHD = txtMaHD.Text.Trim();
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần xem!");
                return;
            }

            var hoaDon = hoaDonService.GetById(maHD);
            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn này!");
                return;
            }

            // Hiển thị thông tin chung
            txtMaKH.Text = hoaDon.MaKH;
            txtNVLap.Text = hoaDon.MaND;
            dteNgayLap.Text = hoaDon.NgayLap?.ToString("dd/MM/yyyy");
            txtETongTien.Text = hoaDon.TongTien?.ToString("N0");

            // Hiển thị chi tiết hóa đơn
            var chiTiet = chiTietService.GetByMaHD(maHD);

            dgvThongTin.Rows.Clear();
            foreach (var item in chiTiet)
            {
                dgvThongTin.Rows.Add(
                    item.PhuTung?.TenPT,
                    item.SoLuong,
                    item.DonGiaBan,
                    (item.SoLuong * item.DonGiaBan)
                );
            }
            dgvChiTietHoaDon.Rows.Clear();

            var chiTietList = chiTietService.GetByMaHD(maHD);
            foreach (var item in chiTietList)
            {
                string tenPT = item.PhuTung?.TenPT ?? "Chưa cập nhật";
                int soLuong = (int) item.SoLuong;
                decimal donGia = item.DonGiaBan ?? 0;
                decimal thanhTien = soLuong * donGia;

                dgvChiTietHoaDon.Rows.Add(
                    tenPT,
                    soLuong,
                    donGia.ToString("N0"),
                    thanhTien.ToString("N0")
                );
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Vui lòng xem trước hóa đơn trước khi xuất!");
                return;
            }

            try
            {
                XuatHoaDonRaPDF(maHD);
                MessageBox.Show($"Hóa đơn {maHD} đã được xuất thành công!", "Xuất hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaKH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNVLap_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dteNgayLap_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtETongTien_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void XuatHoaDonRaPDF(string maHD)
        {
            try
            {
                // Lấy dữ liệu
                var hoaDon = hoaDonService.GetById(maHD);
                if (hoaDon == null) return;

                var chiTietList = chiTietService.GetByMaHD(maHD);
                var khachHang = new KhachHangService().FindById(hoaDon.MaKH);
                var nhanVien = new NguoiDungService().GetNguoiDungByMaND(hoaDon.MaND);

                // Tạo file PDF trên Desktop, sanitize tên file và đảm bảo thư mục tồn tại
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string fileName = $"HoaDon_{maHD}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                foreach (var c in Path.GetInvalidFileNameChars())
                    fileName = fileName.Replace(c, '_');
                Directory.CreateDirectory(desktopPath);
                string filePath = Path.Combine(desktopPath, fileName);

                // Sử dụng FileStream để nhận lỗi I/O rõ ràng nếu có (quyền, file đang mở, ...)
                using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                using (var writer = new PdfWriter(fs))
                using (var pdf = new PdfDocument(writer))
                using (var doc = new Document(pdf))
                {
                    // Tiêu đề
                    doc.Add(new Paragraph("HÓA ĐƠN BÁN HÀNG")
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetFontSize(18)
                        .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD)));

                    doc.Add(new Paragraph($"Mã hóa đơn: {hoaDon.MaHD}"));
                    doc.Add(new Paragraph($"Ngày lập: {hoaDon.NgayLap:dd/MM/yyyy}"));
                    doc.Add(new Paragraph($"Khách hàng: {khachHang?.TenKH ?? "N/A"}"));
                    doc.Add(new Paragraph($"Nhân viên: {nhanVien?.HoTen ?? "N/A"}"));
                    doc.Add(new Paragraph("--------------------------------------------------"));

                    // Bảng chi tiết
                    var table = new Table(4);
                    table.AddHeaderCell("Phụ tùng");
                    table.AddHeaderCell("Số lượng");
                    table.AddHeaderCell("Đơn giá");
                    table.AddHeaderCell("Thành tiền");

                    foreach (var ct in chiTietList)
                    {
                        table.AddCell(ct.PhuTung?.TenPT ?? "N/A");
                        table.AddCell((ct.SoLuong ?? 0).ToString());
                        table.AddCell((ct.DonGiaBan ?? 0).ToString("N0"));
                        table.AddCell(((ct.SoLuong ?? 0) * (ct.DonGiaBan ?? 0)).ToString("N0"));
                    }

                    doc.Add(table);

                    // Tính lại tổng tiền từ chi tiết
                    decimal tongTienTinhLai = chiTietList.Sum(ct => (ct.SoLuong ?? 0) * (ct.DonGiaBan ?? 0));

                    doc.Add(new Paragraph($"Tổng tiền: {tongTienTinhLai:N0} VNĐ")
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT));

                    doc.Add(new Paragraph("\nCảm ơn quý khách!"));
                }

                MessageBox.Show($"Xuất hóa đơn thành công!\nFile lưu tại: {filePath}", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                // Hiển thị chi tiết ngoại lệ để debug (stack + inner exception)
                MessageBox.Show("Lỗi khi xuất PDF: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
