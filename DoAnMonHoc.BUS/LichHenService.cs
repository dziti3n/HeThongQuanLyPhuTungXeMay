using System;
using System.Collections.Generic;
using System.Linq;
using DoAnMonHoc.DAL.Model;

namespace DoAnMonHoc.BUS
{
    public class LichHenService
    {
        private readonly XeMayContextDB context;

        public LichHenService()
        {
            context = new XeMayContextDB();
        }

        public List<LichHen> GetAll()
        {
            // Include KhachHang để dễ hiển thị tên KH trong DataGridView (nếu có)
            return context.LichHens
                          .OrderByDescending(lh => lh.NgayHen)
                          .ToList();
        }

        public List<LichHen> GetByKhachHang(string maKH)
        {
            return context.LichHens
                          .Where(lh => lh.MaKH == maKH)
                          .OrderByDescending(lh => lh.NgayHen)
                          .ToList();
        }

        public bool Add(LichHen lichHen)
        {
            try
            {
                context.LichHens.Add(lichHen);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm lịch hẹn: " + ex.Message);
                return false;
            }
        }

        public bool Update(LichHen lichHen)
        {
            try
            {
                var existing = context.LichHens.FirstOrDefault(lh => lh.MaLichHen == lichHen.MaLichHen);
                if (existing == null) return false;

                existing.NgayHen = lichHen.NgayHen;
                existing.GhiChu = lichHen.GhiChu;
                existing.TrangThai = lichHen.TrangThai;
                existing.MaKH = lichHen.MaKH;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật lịch hẹn: " + ex.Message);
                return false;
            }
        }

        public bool Delete(string maLichHen)
        {
            try
            {
                var lh = context.LichHens.FirstOrDefault(l => l.MaLichHen == maLichHen);
                if (lh == null) return false;

                context.LichHens.Remove(lh);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa lịch hẹn: " + ex.Message);
                return false;
            }
        }
    }
}
