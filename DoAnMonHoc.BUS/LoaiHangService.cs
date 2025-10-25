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
        public List<LoaiHangViewModel> GetLoaiHangWithCount()
        {
            PhuTungContextDB context = new PhuTungContextDB();
            var result = context.LoaiHangs
                .Select(lh => new LoaiHangViewModel
                {
                    MaLoai = lh.MaLoai,
                    TenLoai = lh.TenLoai,
                    SoLuongPhuTung = lh.PhuTungs.Count()
                })
                .ToList();

            return result;
        }


    }
}
