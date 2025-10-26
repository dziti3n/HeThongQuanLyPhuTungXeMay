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
    public partial class frmLichSuMuaHang : Form
    {
        public frmLichSuMuaHang()
        {
            InitializeComponent();
        }
        private void LoadTatCaLichSu()
        {
            var service = new LichSuMuaHangService();
            var danhSach = service.GetTatCaLichSu();

            dgvLichSuMuaHang.Rows.Clear();

            decimal tongTien = 0;

            foreach (var item in danhSach)
            {
                dgvLichSuMuaHang.Rows.Add(
                    item.SoDienThoai,
                    item.TenKH,
                    item.TenPT,
                    item.GiaTien.ToString("N0")
                );

                tongTien += item.GiaTien;
            }

            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }

        private void frmLichSuMuaHang_Load(object sender, EventArgs e)
        {           
            btnTimKiem.Click += btnTimKiem_Click;
            LoadTatCaLichSu();
        }

        private void dgvLichSuMuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sdt = txtTimKiemTheoSDT.Text.Trim();
            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var service = new LichSuMuaHangService();
            var danhSach = service.GetLichSuTheoSDT(sdt);

            dgvLichSuMuaHang.Rows.Clear(); // Xóa dữ liệu cũ

            decimal tongTien = 0;

            foreach (var item in danhSach)
            {
                dgvLichSuMuaHang.Rows.Add(
                    item.SoDienThoai,
                    item.TenKH,
                    item.TenPT,
                    item.GiaTien.ToString("N0")
                );

                tongTien += item.GiaTien;
            }

            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }

        private void txtTimKiemTheoSDT_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }
    }
}
