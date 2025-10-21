using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    internal class PhuTungService
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
            context.PhuTungs.Update(phuTung);
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

    }
}
