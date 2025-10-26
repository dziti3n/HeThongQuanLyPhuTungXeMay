using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnMonHoc.DAL.Model
{
    [Table("ChiTietDonDatHang")]
    public class ChiTietDonDatHang
    {
        [Key, Column(Order = 0)]
        [StringLength(10)]
        public string MaDDH { get; set; }

        [Key, Column(Order = 1)]
        [StringLength(5)]
        public string MaPT { get; set; }

        public int? SoLuong { get; set; }

        public decimal? DonGiaNhap { get; set; }

        public virtual DonDatHang DonDatHang { get; set; }

        public virtual PhuTung PhuTung { get; set; }
    }
}
