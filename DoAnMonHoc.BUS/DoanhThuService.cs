using DoAnMonHoc.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.BUS
{
    public class DoanhThuService
    {
        public List<View_DoanhThu> GetAll()
        {
            using (var context = new PhuTungContextDB())
            {
                return context.View_DoanhThu.ToList();
            }
        }
    }
}
