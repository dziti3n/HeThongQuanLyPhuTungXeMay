using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    public class LoaiHangService
    {
        public List<LoaiHang> GetAllLoaiHang()
        {
            PhuTungContextDB context = new PhuTungContextDB();
            return context.LoaiHangs.ToList();
        }
        public void AddLoaiHang(LoaiHang loaiHang)
        {
            PhuTungContextDB context = new PhuTungContextDB();
            context.LoaiHangs.Add(loaiHang);
            context.SaveChanges();
        }
        public void UpdateLoaiHang(LoaiHang loaiHang)
        {
            PhuTungContextDB context = new PhuTungContextDB();
            var existingLoaiHang = context.LoaiHangs.Find(loaiHang.MaLoai);
            if (existingLoaiHang != null)
            {
                existingLoaiHang.TenLoai = loaiHang.TenLoai;
                context.SaveChanges();
            }
        }
        public void DeleteLoaiHang(string maLH)
        {
            PhuTungContextDB context = new PhuTungContextDB();
            var loaiHang = context.LoaiHangs.Find(maLH);
            if (loaiHang != null)
            {
                context.LoaiHangs.Remove(loaiHang);
                context.SaveChanges();
            }
        }
    }
}
