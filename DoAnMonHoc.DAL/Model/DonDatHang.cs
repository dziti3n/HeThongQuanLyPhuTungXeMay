using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnMonHoc.DAL.Model
{
    [Table("DonDatHang")]
    public class DonDatHang
    {
        public DonDatHang()
        {
            ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaDDH { get; set; }

        [StringLength(5)]
        public string MaNCC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDat { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
    }
}
