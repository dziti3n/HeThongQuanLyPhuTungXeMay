using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    public class DonDatHangService
    {
        public List<PhieuNhap> GetAll()
        {
            PhuTungContextDB contextDB = new PhuTungContextDB();
            return contextDB.PhieuNhaps.ToList();
        }
        public List<ChiTietPhieuNhap> GetChiTietByMaPhieu(string maPhieu)
        {
            using (var context = new PhuTungContextDB())
            {
                return context.ChiTietPhieuNhaps
                              .Where(ct => ct.MaPN == maPhieu)
                              .ToList();
            }
        }
        public bool KiemTraMaPhieuTonTai(string maPhieu)
        {
            using (var context = new PhuTungContextDB())
            {
                return context.PhieuNhaps.Any(p => p.MaPN == maPhieu);
            }
        }
        public string SinhMaPhieuMoi()
        {
            string ngayHienTai = DateTime.Now.ToString("yyyyMMdd");
            string prefix = "PN" + ngayHienTai;

            using (var context = new PhuTungContextDB())
            {
                var maLonNhat = context.PhieuNhaps
                    .Where(p => p.MaPN.StartsWith(prefix))
                    .OrderByDescending(p => p.MaPN)
                    .Select(p => p.MaPN)
                    .FirstOrDefault();

                int soThuTu = 1;
                if (maLonNhat != null)
                {
                    if (maLonNhat.Contains('-'))
                    {
                        var phanSo = maLonNhat.Split('-').Last();
                        if (int.TryParse(phanSo, out int so))
                        {
                            soThuTu = so + 1;
                        }
                    }
                }
                return $"{prefix}-{soThuTu:D3}";
            }
        }
        public bool LuuPhieuNhap(PhieuNhap phieu, List<ChiTietPhieuNhap> chiTietList)
        {
            using (var context = new PhuTungContextDB())
            {
                try
                {
                    if (KiemTraMaPhieuTonTai(phieu.MaPN))
                    {
                        var phieuCu = context.PhieuNhaps.Find(phieu.MaPN);
                        if (phieuCu == null) return false;

                        phieuCu.NgayNhap = phieu.NgayNhap;
                        phieuCu.MaNCC = phieu.MaNCC;
                        

                        var chiTietCu = context.ChiTietPhieuNhaps
                            .Where(ct => ct.MaPN == phieu.MaPN);
                        context.ChiTietPhieuNhaps.RemoveRange(chiTietCu);
                    }
                    else
                    {
                        context.PhieuNhaps.Add(phieu);
                    }

                    foreach (var ct in chiTietList)
                    {
                        ct.MaPN = phieu.MaPN;
                        context.ChiTietPhieuNhaps.Add(ct);
                    }

                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public bool XoaPhieuNhap(string maPhieu)
        {
            using (var context = new PhuTungContextDB())
            {
                try
                {
                    var phieu = context.PhieuNhaps.Find(maPhieu);
                    if (phieu == null) return false;                  
                    var chiTiet = context.ChiTietPhieuNhaps
                        .Where(ct => ct.MaPN == maPhieu);
                    context.ChiTietPhieuNhaps.RemoveRange(chiTiet);

                    context.PhieuNhaps.Remove(phieu);
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
