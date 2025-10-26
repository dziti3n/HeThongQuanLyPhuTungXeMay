using DoAnMonHoc.DAL.Model;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DoAnMonHoc.BUS
{
    public class KhachHangService
    {
        public List<KhachHang> GetAllKhachHang()
        {
            PhuTungContextDB context = new PhuTungContextDB();
            return context.KhachHangs.ToList();
        }

        public void AddKhachHang(KhachHang kh)
        {
            PhuTungContextDB context = new PhuTungContextDB();
            context.KhachHangs.Add(kh);
            context.SaveChanges();
        }

        public void UpdateKhachHang(KhachHang kh)
        {
            PhuTungContextDB context = new PhuTungContextDB();
            context.KhachHangs.AddOrUpdate(kh);
            context.SaveChanges();
        }

        public void DeleteKhachHang(string maKH)
        {
            PhuTungContextDB context = new PhuTungContextDB();
            var kh = context.KhachHangs.Find(maKH);
            if (kh != null)
            {
                context.KhachHangs.Remove(kh);
                context.SaveChanges();
            }
        }

        public KhachHang FindById(string maKH)
        {
            PhuTungContextDB context = new PhuTungContextDB();
            return context.KhachHangs.FirstOrDefault(k => k.MaKH == maKH);
        }

        public List<KhachHang> Search(string keyword)
        {
            PhuTungContextDB context = new PhuTungContextDB();
            return context.KhachHangs
                .Where(k => k.TenKH.Contains(keyword) ||
                            k.MaKH.Contains(keyword) ||
                            k.Email.Contains(keyword))
                .ToList();
        }
    }
}
