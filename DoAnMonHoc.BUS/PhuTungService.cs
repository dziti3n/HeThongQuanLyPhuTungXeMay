using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    public class PhuTungService
    {
        public List<PhuTung> GetAllPhuTung()
        {
            using (var context = new PhuTungContextDB())
            {
                return context.PhuTungs
                    .Include("LoaiHang")       
                    .Include("NhaCungCap")     
                    .ToList();
            }
        }
        public void AddPhuTung(PhuTung phuTung)
        {
            PhuTungContextDB context = new PhuTungContextDB();
            context.PhuTungs.Add(phuTung);
            context.SaveChanges();
        }
        public void UpdatePhuTung(PhuTung phuTung)
        {
            using (var context = new PhuTungContextDB())
            {
                var existing = context.PhuTungs.Find(phuTung.MaPT);
                if (existing != null)
                {
                    context.Entry(existing).CurrentValues.SetValues(phuTung);
                    context.SaveChanges();
                }
            }
        }
        public void DeletePhuTung(string maPT)
        {
            PhuTungContextDB context = new PhuTungContextDB   ();
            var phuTung = context.PhuTungs.Find(maPT);
            if (phuTung != null)
            {
                context.PhuTungs.Remove(phuTung);
                context.SaveChanges();
            }
        }
        public PhuTung FindById(string maPT)
        {
            PhuTungContextDB context = new PhuTungContextDB()   ;
            return context.PhuTungs.FirstOrDefault(pt => pt.MaPT == maPT);
        }
        public List<PhuTung> Search(string keyword)
        {
            using (var context = new PhuTungContextDB())
            {
                return context.PhuTungs
                    .Include("LoaiHang")
                    .Include("NhaCungCap")
                    .Where(pt =>
                        pt.TenPT.Contains(keyword) ||
                        pt.MaPT.Contains(keyword) ||
                        pt.NhaCungCap.TenNCC.Contains(keyword))
                    .ToList();
            }
        }


    }
}
