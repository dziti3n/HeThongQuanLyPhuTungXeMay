namespace DoAnMonHoc.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhatKy")]
    public partial class NhatKy
    {
        [Key]
        public int MaNK { get; set; }

        [StringLength(10)]
        public string MaND { get; set; }

        [StringLength(200)]
        public string HanhDong { get; set; }

        public DateTime? ThoiGian { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
