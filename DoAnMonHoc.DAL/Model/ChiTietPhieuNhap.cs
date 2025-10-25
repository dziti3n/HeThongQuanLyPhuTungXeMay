namespace DoAnMonHoc.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhap")]
    public partial class ChiTietPhieuNhap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaPT { get; set; }

        public int? SoLuong { get; set; }

        public decimal? DonGiaNhap { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }

        public virtual PhuTung PhuTung { get; set; }
    }
}
