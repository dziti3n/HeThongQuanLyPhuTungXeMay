using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    public class LichSuMuaHangService
    {
        private PhuTungContextDB context = new PhuTungContextDB();
        public List<LichSuMuaHangDTO> GetTatCaLichSu()
        {
            var result = (from kh in context.KhachHangs
                          join hd in context.HoaDons on kh.MaKH equals hd.MaKH
                          join ct in context.ChiTietHoaDons on hd.MaHD equals ct.MaHD
                          join pt in context.PhuTungs on ct.MaPT equals pt.MaPT
                          select new LichSuMuaHangDTO
                          {
                              SoDienThoai = kh.DienThoai,
                              TenKH = kh.TenKH,
                              TenPT = pt.TenPT,
                              GiaTien = ct.DonGiaBan ?? 0
                          }).ToList();

            return result;
        }

        public List<LichSuMuaHangDTO> GetLichSuTheoSDT(string sdt)
        {
            var result = (from kh in context.KhachHangs
                          join hd in context.HoaDons on kh.MaKH equals hd.MaKH
                          join ct in context.ChiTietHoaDons on hd.MaHD equals ct.MaHD
                          join pt in context.PhuTungs on ct.MaPT equals pt.MaPT
                          where kh.DienThoai == sdt
                          select new LichSuMuaHangDTO
                          {
                              SoDienThoai = kh.DienThoai,
                              TenKH = kh.TenKH,
                              TenPT = pt.TenPT,
                              GiaTien = ct.DonGiaBan ?? 0
                          }).ToList();

            return result;
        }
    }

}
