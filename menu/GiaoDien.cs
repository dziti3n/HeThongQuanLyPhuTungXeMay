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

        }

        private void btnSup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public event EventHandler DangXuat;

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangXuat?.Invoke(this, new EventArgs());
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
            frmHoaDon f = new frmHoaDon();
            OpenChildForm(f);
        }

        private void btnXuatHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHoaDon f = new frmHoaDon();  
            OpenChildForm(f);
        }

        private void btnTraHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTraHang f = new frmTraHang();
            OpenChildForm(f);
        }

        private void btnLichSuBuonBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLichSuBuonBan f = new frmLichSuBuonBan();
            OpenChildForm(f);
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

        private void btnDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoanhThu f = new frmDoanhThu();
            OpenChildForm(f);
        }

        private void btnLoiNhuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoiNhuan f = new frmLoiNhuan();
            OpenChildForm(f);
        }

        

        private void btnThongTinTonKhoVaSapHet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinTonKho f = new frmThongTinTonKho();
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
            ApplyUserPermissions();
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

        private void ApplyUserPermissions()
        {
            // Nếu không phải admin → ẩn nút "Quản lý tài khoản"
            if (_currentUser == null || !_currentUser.Admin)
            {
                btnQltk.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                // Bạn cũng có thể ẩn các nút khác nếu cần
            }
        }

        private void btnQltk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_currentUser == null || !_currentUser.Admin)
            {
                MessageBox.Show("Chỉ quản trị viên mới được phép truy cập!", "Truy cập bị từ chối",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmNgDung f = new frmNgDung();
            OpenChildForm(f);
        }
    }
}
