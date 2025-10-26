namespace DoAnMonHoc.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonDatHang")]
    public partial class DonDatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonDatHang()
        {
            ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaDDH { get; set; }

        [Required]
        [StringLength(5)]
        public string MaND { get; set; }

        [Required]
        [StringLength(5)]
        public string MaNCC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
