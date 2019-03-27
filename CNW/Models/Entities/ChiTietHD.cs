namespace CNW.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHD")]
    public partial class ChiTietHD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string HoaDonID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string SanPhamID { get; set; }

        public int? DonGia { get; set; }

        public int? Tong { get; set; }

        public DateTime? NgayMua { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
