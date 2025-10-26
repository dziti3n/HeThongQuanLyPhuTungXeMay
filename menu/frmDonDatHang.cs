using DoAnMonHoc.BUS;
using DoAnMonHoc.DAL.Model;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace menu
{
    public partial class frmDonDatHang : Form
    {
        private readonly DonDatHangService donDatHangService = new DonDatHangService();
        
        private readonly CTDonDatHangService chiTietDonDatHangService = new CTDonDatHangService();
        public frmDonDatHang()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmPhieuNhapHang f = new frmPhieuNhapHang();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form: " + ex.Message);
            }
        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvDonDatHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn đặt hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã đơn đặt hàng từ dòng đang chọn
            string maDDH = dgvDonDatHang.SelectedRows[0].Cells[1].Value?.ToString();

            if (string.IsNullOrEmpty(maDDH))
            {
                MessageBox.Show("Không tìm thấy mã đơn đặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa đơn đặt hàng '{maDDH}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var context = new PhuTungContextDB())
                    {
                        // Xóa chi tiết đơn đặt hàng trước (vì có khóa ngoại)
                        var chiTiet = context.ChiTietDonDatHangs.Where(ct => ct.MaDDH == maDDH).ToList();
                        context.ChiTietDonDatHangs.RemoveRange(chiTiet);

                        // Xóa đơn đặt hàng
                        var donDatHang = context.DonDatHangs.Find(maDDH);
                        if (donDatHang != null)
                        {
                            context.DonDatHangs.Remove(donDatHang);
                            context.SaveChanges();

                            MessageBox.Show("Đã xóa đơn đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh lại grid
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy đơn đặt hàng cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var listDonDatHang = donDatHangService.GetAll();
            var listCT = chiTietDonDatHangService.GetAll();

            // JOIN giữa DonDatHang và ChiTietDonDatHang
            var data = from ddh in listDonDatHang
                       join ct in listCT on ddh.MaDDH equals ct.MaDDH
                       select new
                       {
                           MaDDH = ddh.MaDDH,
                           TenPhuTung = ct.PhuTung.TenPT,
                           SoLuong = ct.SoLuong,
                           DonGia = ct.DonGiaNhap,
                           NgayDat = ddh.NgayDat,
                           NhaCungCap = ddh.NhaCungCap != null ? ddh.NhaCungCap.TenNCC : "(Không có)"
                       };

            dgvDonDatHang.Rows.Clear();
            int stt = 1;

            foreach (var item in data)
            {
                dgvDonDatHang.Rows.Add(stt++, item.MaDDH, item.TenPhuTung, item.SoLuong, item.DonGia, item.NgayDat.HasValue ? item.NgayDat.Value.ToShortDateString() : ""
, item.NhaCungCap);
            }

            txtTongSoDon.Text = listDonDatHang.Count.ToString();
        }
        
    }
}
