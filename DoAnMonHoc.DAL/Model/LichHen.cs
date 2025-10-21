using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnMonHoc.DAL.Model
{
    [Table("LichHen")]
    public class LichHen
    {
        [Key]
        [StringLength(10)]
        public string MaLichHen { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Required]
        public DateTime NgayHen { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        // Navigation property
        [ForeignKey("MaKH")]
        public virtual KhachHang KhachHang { get; set; }
    }
}
