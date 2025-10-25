namespace DoAnMonHoc.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietTraHang")]
    public partial class ChiTietTraHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaTra { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaPT { get; set; }

        public int? SoLuongTra { get; set; }

        public virtual TraHang TraHang { get; set; }

        public virtual PhuTung PhuTung { get; set; }
    }
}
