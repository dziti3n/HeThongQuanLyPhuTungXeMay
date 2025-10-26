using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    public class ChiTietHoaDonService
    {

        public List<ChiTietHoaDon> GetByMaHD(string maHD)
        {
            using (var context = new PhuTungContextDB())
            {
                // Include để lấy luôn tên phụ tùng (sản phẩm)
                var chiTiet = context.ChiTietHoaDons
                    .Include("PhuTung")
                    .Where(ct => ct.MaHD == maHD)
                    .ToList();

                return chiTiet;
            }
        }
    }
}
