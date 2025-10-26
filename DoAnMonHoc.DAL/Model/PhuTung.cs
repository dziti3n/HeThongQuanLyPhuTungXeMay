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
            ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [StringLength(5)]
        public string MaPT { get; set; }

        [Required]
        [StringLength(145)]
        public string TenPT { get; set; }

        [StringLength(5)]
        public string MaLoai { get; set; }

        [StringLength(5)]
        public string MaNCC { get; set; }

        [StringLength(10)]
        public string DonViTinh { get; set; }

        public decimal? DonGia { get; set; }

        public int? SoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual LoaiHang LoaiHang { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
