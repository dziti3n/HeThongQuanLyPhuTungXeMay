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
        // Khai báo danh sách để lưu trữ phụ tùng
        private List<PhuTung> dsPhuTung = new List<PhuTung>();
        public frmSanPham()
        {
            InitializeComponent();
            dataGridViewThongTin.AutoGenerateColumns = false;
            dataGridViewThongTin.DataSource = dsPhuTung;
        }

        public class PhuTung
        {
            public string MaPT { get; set; }
            public string TenPT { get; set; }
            public string LoaiPT { get; set; }
            public string DonViTinh { get; set; }
            public decimal DonGia { get; set; }
            public int SoLuongTon { get; set; }
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
            PhuTung pt = new PhuTung
            {
                MaPT = txtMaPT.Text,
                TenPT = txtTenPT.Text,
                LoaiPT = txtLoaiPT.Text,
                DonViTinh = txtDonViTinh.Text,
                DonGia = decimal.TryParse(txtDonGia.Text, out decimal gia) ? gia : 0,
                SoLuongTon = int.TryParse(txtSoLuongTon.Text, out int sl) ? sl : 0
            };

            dsPhuTung.Add(pt);

            // Refresh lại bảng
            dataGridViewThongTin.DataSource = null;

            dataGridViewThongTin.DataSource = dsPhuTung;

            MessageBox.Show("Thêm phụ tùng thành công!", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewThongTin.CurrentRow != null) // kiểm tra có chọn dòng chưa
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phụ tùng này không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int index = dataGridViewThongTin.CurrentRow.Index;
                    dsPhuTung.RemoveAt(index);

                    dataGridViewThongTin.DataSource = null;
                    dataGridViewThongTin.DataSource = dsPhuTung;

                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phụ tùng cần xóa!", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                                 "Xác nhận thoát",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
