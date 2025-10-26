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

namespace menu
{
    public partial class frmDonDatHang : Form
    {
        private readonly DonDatHangService donDatHangService = new DonDatHangService();
        private readonly NhaCungCapService nhaCungCapService = new NhaCungCapService();
        private readonly PhuTungService sanPhamService = new PhuTungService();
        public frmDonDatHang()
        {
            InitializeComponent();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            try
            {

                var listDonDatHang = donDatHangService.GetAll();
                var listNhaCungCap = nhaCungCapService.GetAll();
                FillcmbNhaCungCap(listNhaCungCap);
                bindGrid(listDonDatHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillcmbNhaCungCap(List<NhaCungCap> listNhaCungCap)
        {

        }
        private void bindGrid(List<DonDatHang> listDonDatHang)
        {
            dgvDonDatHang.Rows.Clear();
            foreach (var donDatHang in listDonDatHang)
            {
                int index = dgvDonDatHang.Rows.Add();
                dgvDonDatHang.Rows[index].Cells[1].Value = donDatHang.MaDDH;
            //    dgvDonDatHang.Rows[index].Cells[2].Value = donDatHang.TenPT;
            }
        }
    }
}
