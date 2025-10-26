using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnMonHoc.DAL.Model;

namespace DoAnMonHoc.BUS
{
    public class CTDonDatHangService
    {
        public List<ChiTietDonDatHang> GetAll()
        {
            using (var context = new PhuTungContextDB())
            {
                return context.ChiTietDonDatHangs.Include("PhuTung").ToList();
            }
        }
        public ChiTietDonDatHang GetById(string maDDH, string maPT)
        {
            using (var context = new PhuTungContextDB())
            {
                return context.ChiTietDonDatHangs.Find(maDDH, maPT);
            }
        }
        
    }
}
