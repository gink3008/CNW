namespace CNW.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductDetail")]
    public partial class ProductDetail
    {
        [Required]
        [StringLength(10)]
        public string ProductID { get; set; }

        [Required]
        [StringLength(3)]
        public string SizeID { get; set; }

        [Required]
        [StringLength(3)]
        public string ColorID { get; set; }

        public string Description { get; set; }

        public string Overview { get; set; }

        public int? Quality { get; set; }

        [StringLength(10)]
        public string Price { get; set; }

        [StringLength(10)]
        public string ID { get; set; }

        public virtual Image Image { get; set; }

        public virtual Product Product { get; set; }

        public virtual Size Size { get; set; }
    }
}
