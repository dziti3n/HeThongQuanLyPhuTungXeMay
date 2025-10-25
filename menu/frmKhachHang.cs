using DoAnMonHoc.BUS;
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
    public partial class frmKhachHang : Form
    {
        DataTable dtKhachHang = new DataTable();
        private readonly KhachHangService _service = new KhachHangService();

        public frmKhachHang()
        {
            InitializeComponent();
            dtKhachHang.Columns.Add("Mã KH");
            dtKhachHang.Columns.Add("Tên KH");
            dtKhachHang.Columns.Add("SĐT");
            dtKhachHang.Columns.Add("Địa chỉ");

            dgvThongTinKH.DataSource = dtKhachHang;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // Khởi tạo cấu trúc cột cho DataTable
            dtKhachHang.Columns.Add("Mã KH");
            dtKhachHang.Columns.Add("Tên KH");
            dtKhachHang.Columns.Add("SĐT");
            dtKhachHang.Columns.Add("Địa chỉ");
            dtKhachHang.Columns.Add("Email");

            // Gán DataTable vào DataGridView
            dgvThongTinKH.DataSource = dtKhachHang;
        }


        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvThongTinKH.CurrentRow != null)
            {
                int index = dgvThongTinKH.CurrentRow.Index;
                dtKhachHang.Rows[index]["Mã KH"] = txtMaKhachHang.Text;
                dtKhachHang.Rows[index]["Tên KH"] = txtTenKhachHang.Text;
                dtKhachHang.Rows[index]["SĐT"] = txtSDT.Text;
                dtKhachHang.Rows[index]["Địa chỉ"] = txtDiaChi.Text;
                dtKhachHang.Rows[index]["Email"] = txtEmail.Text;

            }
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTenKhachHang.Text.ToLower();

            if (tuKhoa != "")
            {
                var ketQua = dtKhachHang.AsEnumerable()
                    .Where(row => row.Field<string>("Tên KH").ToLower().Contains(tuKhoa));

                if (ketQua.Any())
                    dgvThongTinKH.DataSource = ketQua.CopyToDataTable();
                else
                    MessageBox.Show("Không tìm thấy khách hàng nào phù hợp.");
            }
            else
            {
                dgvThongTinKH.DataSource = dtKhachHang;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text != "" && txtTenKhachHang.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "")
            {
                DataRow row = dtKhachHang.NewRow();
                row["Mã KH"] = txtMaKhachHang.Text;
                row["Tên KH"] = txtTenKhachHang.Text;
                row["SĐT"] = txtSDT.Text;
                row["Địa chỉ"] = txtDiaChi.Text;
                row["Email"] = txtEmail.Text;

                dtKhachHang.Rows.Add(row);
                dgvThongTinKH.DataSource = dtKhachHang;

                // Xóa trống các ô nhập sau khi thêm
                txtMaKhachHang.Clear();
                txtTenKhachHang.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();
                txtEmail.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Nếu không có hàng nào trong bảng
            if (dtKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa!", "Thông báo");
                return;
            }

            // Nếu người dùng chưa chọn dòng nào
            if (dgvThongTinKH.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông báo");
                return;
            }

            // Lấy chỉ số của dòng đang chọn
            int index = dgvThongTinKH.SelectedRows[0].Index;

            // Kiểm tra lại chỉ số hợp lệ
            if (index >= 0 && index < dtKhachHang.Rows.Count)
            {
                dtKhachHang.Rows.RemoveAt(index);
                MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
            }
        }

        private void dgvThongTinKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu dòng được chọn hợp lệ (tránh lỗi khi bấm tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThongTinKH.Rows[e.RowIndex];

                txtMaKhachHang.Text = row.Cells[0].Value?.ToString();
                txtTenKhachHang.Text = row.Cells[1].Value?.ToString();
                txtSDT.Text = row.Cells[2].Value?.ToString();
                txtDiaChi.Text = row.Cells[3].Value?.ToString();
                txtEmail.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void frmKhachHang_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvThongTinKH.DataSource = _service.GetAllKhachHang();
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
