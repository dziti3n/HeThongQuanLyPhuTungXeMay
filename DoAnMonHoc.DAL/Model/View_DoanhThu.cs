using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnMonHoc.DAL.Model
{
    [Table("View_DoanhThu")]
    public class View_DoanhThu
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaHoaDon { get; set; }

        [StringLength(50)]
        public string TenKhachHang { get; set; }

        public decimal? TongDoanhThu { get; set; }

        public DateTime? NgayLap { get; set; }
    }
}
