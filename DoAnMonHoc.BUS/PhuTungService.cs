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
            XeMayContextDB context = new XeMayContextDB();
            return context.PhuTungs.ToList();
        }
        public void AddPhuTung(PhuTung phuTung)
        {
            XeMayContextDB context = new XeMayContextDB();
            context.PhuTungs.Add(phuTung);
            context.SaveChanges();
        }
        public void UpdatePhuTung(PhuTung phuTung)
        {
            XeMayContextDB context = new XeMayContextDB();
            context.PhuTungs.AddOrUpdate(phuTung);
            context.SaveChanges();
        }
        public void DeletePhuTung(string maPT)
        {
            XeMayContextDB context = new XeMayContextDB();
            var phuTung = context.PhuTungs.Find(maPT);
            if (phuTung != null)
            {
                context.PhuTungs.Remove(phuTung);
                context.SaveChanges();
            }
        }
        public PhuTung FindById(string maPT)
        {
            XeMayContextDB context = new XeMayContextDB();
            return context.PhuTungs.FirstOrDefault(pt => pt.MaPT == maPT);
        }
        public List<PhuTung> Search(string keyword)
        {
            XeMayContextDB context = new XeMayContextDB();
            return context.PhuTungs
                .Where(pt => pt.TenPT.Contains(keyword) || pt.MaPT.Contains(keyword))
                .ToList();
        }


    }
}
