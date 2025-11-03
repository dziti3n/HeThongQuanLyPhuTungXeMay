using DoAnMonHoc.DAL.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        public class ThongKeDoanhThuViewModel
        {
            public DateTime NgayLap { get; set; }
            public decimal DoanhThu { get; set; }
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new PhuTungContextDB())
                {
                    // ✅ Lấy dữ liệu từ bảng Hóa Đơn, nhóm theo ngày
                    var list = context.HoaDons
                        .GroupBy(hd => hd.NgayLap)
                        .Select(g => new ThongKeDoanhThuViewModel
                        {
                            NgayLap = g.Key.Value,
                            DoanhThu = g.Sum(x => x.TongTien ?? 0)
                        })
                        .OrderBy(x => x.NgayLap)
                        .ToList();

                    // ✅ Xác định đường dẫn RDLC
                    string reportPath = @"C:\Users\ASUS\source\repos\HeThongQuanLyPhuTungXeMay\menu\ThongKeDoanhThu.rdlc";
                    if (!File.Exists(reportPath))
                    {
                        MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ✅ Cấu hình ReportViewer
                    reportViewer1.LocalReport.ReportPath = reportPath;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(
                        new ReportDataSource("DataSet1", list)
                    );

                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
