using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnMonHoc.DAL.Model
{
    public class LoiNhuanDTO
    {
        public string TenPT { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaBan { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal LoiNhuan { get; set; }
        public DateTime NgayBan { get; set; }
    }
}
