using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnMonHoc.DAL.Model;

namespace menu
{
    public partial class GiaoDien : Form
    {
        public bool isThoat = true;
        private NguoiDung _currentUser;
        public GiaoDien()
        {
            InitializeComponent();
            SetupMdiBackground();
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.White;
                    break;
                }
            }
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void btnHDSD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string filePath = "README.txt"; // vì đã nằm trong bin\Debug
                if (System.IO.File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(filePath);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file README.txt. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở file hướng dẫn:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string thongTin = "📞 Hotline: 0909 123 456\n📧 Email: support@doanmonhoc.vn\n💬 Zalo: @TeamDoAn\n🕒 Hỗ trợ từ 8h đến 22h mỗi ngày";
            MessageBox.Show(thongTin, "Liên hệ hỗ trợ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public event EventHandler DangXuat;

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangXuat?.Invoke(this, new EventArgs());
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnThongTinPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDonDatHang f = new frmDonDatHang();
            OpenChildForm(f);
        }

        
        private void btnThongTinPhuTung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSanPham f = new frmSanPham();
            OpenChildForm(f);
        }

        private void btnLapHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void btnXuatHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        


        private void btnThongTinKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            OpenChildForm(f);
        }     

        private void btnLichSuMuaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLichSuMuaHang f = new frmLichSuMuaHang();
            OpenChildForm(f);
        }         
        private void btnThietLapTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNgDung f = new frmNgDung();
            OpenChildForm(f);
        }

       

        private void rbcMENU_Click(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form child)
        {
            // Đóng form con cũ (nếu cần)
            foreach (Form f in this.MdiChildren)
                f.Close();

            // 👇 BƯỚC MỚI: Đồng bộ màu nền MdiClient với form con
            var mdiClient = this.Controls.OfType<MdiClient>().FirstOrDefault();
            if (mdiClient != null)
            {
                // Lấy màu nền từ form con (hoặc đặt cứng màu bạn muốn)
                mdiClient.BackColor = child.BackColor; // hoặc Color.White, Color.LightGray, v.v.
            }

            // Cấu hình form con
            child.MdiParent = this;
            child.FormBorderStyle = FormBorderStyle.None;
            child.StartPosition = FormStartPosition.Manual;

            // Căn giữa (nếu bạn vẫn muốn căn giữa)
            if (mdiClient != null)
            {
                int x = Math.Max(0, (mdiClient.Width - child.Width) / 2);
                int y = Math.Max(0, (mdiClient.Height - child.Height) / 2);
                y = Math.Max(0, y - 30);
                child.Location = new Point(x, y);
            }

            child.Show();
        }

        public GiaoDien(NguoiDung currentUser) : this() // Gọi constructor trên
        {
            _currentUser = currentUser;
            // Tùy chọn: Ẩn/mở menu theo quyền ở đây
            //ApplyUserPermissions();
        }

        private void SetupMdiBackground()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.White;
                    break;
                }
            }
        }

        /*private void ApplyUserPermissions()
        {
            // Nếu không phải admin → ẩn nút "Quản lý tài khoản"
            if (_currentUser == null || !_currentUser.Admin)
            {
                btnQltk.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                // Bạn cũng có thể ẩn các nút khác nếu cần
            }
        }*/

        private void btnQltk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng đã đăng nhập.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_currentUser.Admin)
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!\nChỉ quản trị viên mới được phép sử dụng.",
                                "Truy cập bị từ chối",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // 👈 Dừng lại, không mở form
            }

            // Nếu là admin → cho phép mở form
            frmNgDung f = new frmNgDung();
            OpenChildForm(f);
        }

        private bool _isExiting = false;
        private void GiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isExiting) return; // Đã đang thoát → không hỏi lại

            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

                // Đóng form con
                foreach (Form f in this.MdiChildren.ToList())
                    f.Close();

                // Đặt cờ và thoát toàn bộ
                _isExiting = true;
                Application.Exit();
            }
        }

        private void btnLoaiHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoaiHang f = new frmLoaiHang();
            OpenChildForm(f);
        }
    }
}
