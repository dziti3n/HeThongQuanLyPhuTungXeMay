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
        public List<DonDatHang> GetAll()
        {
            PhuTungContextDB contextDB = new PhuTungContextDB();
            return contextDB.DonDatHangs.ToList();
        }
        public DonDatHang GetById(string maDDH)
        {
            using (var context = new PhuTungContextDB())
            {
                return context.DonDatHangs.Find(maDDH);
            }
        }
        public void Add(DonDatHang donDatHang)
        {
            using (var context = new PhuTungContextDB())
            {
                context.DonDatHangs.Add(donDatHang);
                context.SaveChanges();
            }
        }
        public void Update(DonDatHang donDatHang)
        {
            using (var context = new PhuTungContextDB())
            {
                context.Entry(donDatHang).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(string maDDH)
        {
            using (var context = new PhuTungContextDB())
            {
                var donDatHang = context.DonDatHangs.Find(maDDH);
                if (donDatHang != null)
                {
                    context.DonDatHangs.Remove(donDatHang);
                    context.SaveChanges();
                }
            }
        }
        public List<DonDatHang> SearchByNhaCungCap(string maNCC)
        {
            using (var context = new PhuTungContextDB())
            {
                return context.DonDatHangs
                    .Where(ddh => ddh.MaNCC == maNCC)
                    .ToList();
            }
        }
    }
}
