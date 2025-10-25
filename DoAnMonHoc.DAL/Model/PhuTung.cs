namespace DoAnMonHoc.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhuTung")]
    public partial class PhuTung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhuTung()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
            ChiTietTraHangs = new HashSet<ChiTietTraHang>();
        }

        [Key]
        [StringLength(5)]
        public string MaPT { get; set; }

        [Required]
        [StringLength(145)]
        public string TenPT { get; set; }

        [StringLength(5)]
        public string MaLoai { get; set; }

        [StringLength(6)]
        public string DonViTinh { get; set; }

        public decimal? DonGia { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietTraHang> ChiTietTraHangs { get; set; }

        public virtual LoaiHang LoaiHang { get; set; }
    }
}
