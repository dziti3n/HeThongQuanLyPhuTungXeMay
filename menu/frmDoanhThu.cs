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

        public class ThongKeDoanhThuThangViewModel
        {
            public int Thang { get; set; }
            public int Nam { get; set; }
            public decimal DoanhThu { get; set; }
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new PhuTungContextDB())
                {
                    // ✅ Thống kê theo ngày
                    var listNgay = context.HoaDons
                        .GroupBy(hd => hd.NgayLap)
                        .Select(g => new ThongKeDoanhThuViewModel
                        {
                            NgayLap = g.Key.Value,
                            DoanhThu = g.Sum(x => x.TongTien ?? 0)
                        })
                        .OrderBy(x => x.NgayLap)
                        .ToList();

                    // ✅ Thống kê theo tháng
                    var listThang = context.HoaDons
                        .Where(hd => hd.NgayLap != null)
                        .GroupBy(hd => new { hd.NgayLap.Value.Year, hd.NgayLap.Value.Month })
                        .Select(g => new ThongKeDoanhThuThangViewModel
                        {
                            Nam = g.Key.Year,
                            Thang = g.Key.Month,
                            DoanhThu = g.Sum(x => x.TongTien ?? 0)
                        })
                        .OrderBy(x => x.Nam)
                        .ThenBy(x => x.Thang)
                        .ToList();

                    // ✅ Đường dẫn file RDLC
                    string reportPath = Path.Combine(Application.StartupPath, "ThongKeDoanhThu.rdlc");
                    if (!File.Exists(reportPath))
                    {
                        MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ✅ Gán dữ liệu cho ReportViewer
                    reportViewer1.LocalReport.ReportPath = reportPath;
                    reportViewer1.LocalReport.DataSources.Clear();

                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetNgay", listNgay));
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetThang", listThang));

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
