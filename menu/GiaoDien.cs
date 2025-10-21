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
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.White;
                    break;
                }
            }
        }


private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmNgDung f = new frmNgDung();
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmLoaiHang f = new frmLoaiHang();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmDonDatHang f = new frmDonDatHang();
            f.ShowDialog();
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void btnSaoLuuKhoiPhuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHDSD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            frmDangNhap f = new frmDangNhap();
            
            
            f.Show();
            this.Hide();
            this.Close();

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

        private void btnTinhTrangPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTrangThaiPhieuNhap f = new frmTrangThaiPhieuNhap();
            OpenChildForm(f);
        }

        private void btnXuatPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
            frmXuatHoaDon f = new frmXuatHoaDon();  
            OpenChildForm(f);
        }

        private void btnTraHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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

        private void btnLichHen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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

        }

        private void btnMatHangBanChay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThongTinTonKhoVaSapHet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThietLapTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNgDung f = new frmNgDung();
            OpenChildForm(f);
        }

        private void btnNhatKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
                child.Location = new Point(x, y);
            }

            child.Show();
        }
    }
}
