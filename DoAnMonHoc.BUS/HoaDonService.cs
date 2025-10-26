using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    internal class HoaDonService
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
    }
}
