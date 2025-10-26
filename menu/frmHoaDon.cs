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
    public partial class frmBanHang : Form
    {
        private readonly KhachHangService khachHangService = new KhachHangService();
        private readonly PhuTungService phuTungService = new PhuTungService();
        private readonly HoaDonService hoaDonService = new HoaDonService();
        private readonly ChiTietHoaDonService chiTietHoaDonService = new ChiTietHoaDonService();
        public class GioHangItem
        {
            public string MaPT { get; set; }
            public string TenPT { get; set; }
            public int SoLuong { get; set; }
            public decimal DonGiaBan { get; set; }
        }

        private List<GioHangItem> gioHang = new List<GioHangItem>();

        public frmBanHang()
        {
            InitializeComponent();
        }
        private void LoadKhachHang()
        {
            var list = khachHangService.GetAllKhachHang();
            cmbMaKH.DataSource = list;
            cmbMaKH.DisplayMember = "TenKH";
            cmbMaKH.ValueMember = "MaKH";
        }
        private void LoadPhuTung()
        {
            dgvPhuTung.Rows.Clear();
            var list = phuTungService.GetAllPhuTung();

            foreach (var pt in list)
            {
                dgvPhuTung.Rows.Add(
            pt.MaPT,
            pt.TenPT,
            pt.SoLuong,
            pt.DonGia
                 );
            }     
        }
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadPhuTung();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadPhuTung(txtTimKiem.Text.Trim());
        }
        private void LoadPhuTung(string keyword)
        {
            var list = phuTungService.GetAllPhuTung()
                .Where(pt => pt.SoLuong > 0 &&
                             (pt.TenPT.Contains(keyword) || pt.MaPT.Contains(keyword)))
                .ToList();

            dgvPhuTung.Rows.Clear();
            foreach (var pt in list)
            {
                dgvPhuTung.Rows.Add(pt.MaPT, pt.TenPT, pt.SoLuong, pt.DonGia);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dgvPhuTung.SelectedRows.Count == 0) return;

            var row = dgvPhuTung.SelectedRows[0];
            string maPT = row.Cells[0].Value.ToString();
            string tenPT = row.Cells[1].Value.ToString();
            int soLuongTon = Convert.ToInt32(row.Cells[2].Value);
            decimal donGia = Convert.ToDecimal(row.Cells[3].Value);

            if (!int.TryParse(txtSoLuong.Text, out int soLuongChon) || soLuongChon <= 0 || soLuongChon > soLuongTon)
            {
                MessageBox.Show("⚠️ Số lượng không hợp lệ!");
                return;
            }

            gioHang.Add(new GioHangItem
            {
                MaPT = maPT,
                TenPT = tenPT,
                SoLuong = soLuongChon,
                DonGiaBan = donGia
            });

            LoadGioHang();
        }
        private void LoadGioHang()
        {
            dgvGioHang.Rows.Clear();
            foreach (var item in gioHang)
            {
                dgvGioHang.Rows.Add(item.MaPT, item.TenPT, item.SoLuong, item.DonGiaBan);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.SelectedRows.Count == 0) return;

            string maPT = dgvGioHang.SelectedRows[0].Cells[0].Value.ToString();
            gioHang.RemoveAll(x => x.MaPT == maPT);
            LoadGioHang();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            string maKH = cmbMaKH.SelectedValue.ToString();
            string maHD = "HD" + DateTime.Now.Ticks.ToString().Substring(10);
            decimal tongTien = gioHang.Sum(x => x.SoLuong * x.DonGiaBan);

            var hoaDon = new HoaDon
            {
                MaHD = maHD,
                MaKH = maKH,
                MaND = LuuNV.MaNguoiDung, 
                NgayLap = DateTime.Now,
                TongTien = tongTien
            };

            hoaDonService.Add(hoaDon);

            foreach (var item in gioHang)
            {
                var ct = new ChiTietHoaDon
                {
                    MaHD = maHD,
                    MaPT = item.MaPT,
                    SoLuong = item.SoLuong,
                    DonGiaBan = item.DonGiaBan
                };

                chiTietHoaDonService.Add(ct);

                var pt = phuTungService.FindById(item.MaPT);
                pt.SoLuong -= item.SoLuong;
                phuTungService.UpdatePhuTung(pt);
            }

            MessageBox.Show("✅ Thanh toán thành công!");
            gioHang.Clear();
            LoadGioHang();
            LoadPhuTung("");
        }
    }
}
