namespace CNW.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Anh")]
    public partial class Anh
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(200)]
        public string url { get; set; }

        [Required]
        [StringLength(10)]
        public string SanPhamID { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
