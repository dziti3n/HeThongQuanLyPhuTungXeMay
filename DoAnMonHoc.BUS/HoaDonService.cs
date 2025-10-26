using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    public class HoaDonService
    {
        public List<HoaDon>GetAll()
        { 
            PhuTungContextDB contextDB = new PhuTungContextDB();
            return contextDB.HoaDons.ToList();
        }
        public HoaDon GetById(string maHD)
        {
            using (var context = new PhuTungContextDB())
            {
                return context.HoaDons.Find(maHD);
            }
        }
        
        public void Add(HoaDon hoaDon)
        {
            using (var context = new PhuTungContextDB())
            {
                context.HoaDons.Add(hoaDon);
                context.SaveChanges();
            }
        }





    }
}
