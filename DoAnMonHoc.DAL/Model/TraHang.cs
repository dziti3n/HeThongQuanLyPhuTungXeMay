namespace DoAnMonHoc.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraHang")]
    public partial class TraHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TraHang()
        {
            ChiTietTraHangs = new HashSet<ChiTietTraHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaTra { get; set; }

        [Required]
        [StringLength(5)]
        public string MaHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        [StringLength(200)]
        public string LyDo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietTraHang> ChiTietTraHangs { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
