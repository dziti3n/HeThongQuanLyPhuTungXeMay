namespace DoAnMonHoc.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaPT { get; set; }

        public int? SoLuong { get; set; }

        public decimal? DonGiaBan { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual PhuTung PhuTung { get; set; }
    }
}
