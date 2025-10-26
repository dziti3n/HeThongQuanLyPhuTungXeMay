using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    public class LoiNhuanService
    {
        private PhuTungContextDB context = new PhuTungContextDB();

        public List<LoiNhuanDTO> GetLoiNhuan()
        {
            var result = (from ct in context.ChiTietHoaDons
                          join pt in context.PhuTungs on ct.MaPT equals pt.MaPT
                          select new LoiNhuanDTO
                          {
                              TenPT = pt.TenPT,
                              SoLuong = ct.SoLuong ?? 0,
                              DonGiaBan = ct.DonGiaBan ?? 0,
                              DonGiaNhap = pt.DonGiaNhap ?? 0,
                              LoiNhuan = ((ct.DonGiaBan ?? 0) - (pt.DonGiaNhap ?? 0)) * (ct.SoLuong ?? 0)
                          }).ToList();

            return result;
        }
        public List<LoiNhuanDTO> GetLoiNhuanTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            var result = (from ct in context.ChiTietHoaDons
                          join hd in context.HoaDons on ct.MaHD equals hd.MaHD
                          join pt in context.PhuTungs on ct.MaPT equals pt.MaPT
                          where hd.NgayLap >= tuNgay && hd.NgayLap <= denNgay
                          select new LoiNhuanDTO
                          {
                              TenPT = pt.TenPT,
                              SoLuong = ct.SoLuong ?? 0,
                              DonGiaBan = ct.DonGiaBan ?? 0,
                              DonGiaNhap = pt.DonGiaNhap ?? 0,
                              LoiNhuan = ((ct.DonGiaBan ?? 0) - (pt.DonGiaNhap ?? 0)) * (ct.SoLuong ?? 0),
                              NgayBan = hd.NgayLap ?? DateTime.MinValue
                          }).ToList();

            return result;
        }

    }
}
