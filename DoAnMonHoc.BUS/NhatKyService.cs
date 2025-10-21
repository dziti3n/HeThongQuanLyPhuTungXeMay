using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    public class NhatKyService
    {
        private readonly XeMayContextDB context;

        public NhatKyService()
        {
            context = new XeMayContextDB();
        }

        // Lấy toàn bộ nhật ký
        public List<NhatKy> GetAll()
        {
            return context.NhatKies.OrderByDescending(nk => nk.ThoiGian).ToList();
        }

        // Lọc theo mã người dùng
        public List<NhatKy> GetByNhanVien(string maND)
        {
            return context.NhatKies
                .Where(nk => nk.MaND == maND)
                .OrderByDescending(nk => nk.ThoiGian)
                .ToList();
        }

        // Lọc theo khoảng thời gian
        public List<NhatKy> GetByDateRange(DateTime from, DateTime to)
        {
            return context.NhatKies
                .Where(nk => nk.ThoiGian >= from && nk.ThoiGian <= to)
                .OrderByDescending(nk => nk.ThoiGian)
                .ToList();
        }

        // Thêm mới nhật ký
        public void Add(string maND, string hanhDong)
        {
            var nk = new NhatKy
            {
                MaND = maND,
                HanhDong = hanhDong,
                ThoiGian = DateTime.Now
            };
            context.NhatKies.Add(nk);
            context.SaveChanges();
        }
    }
}
