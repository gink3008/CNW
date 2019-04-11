namespace CNW.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Image
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(200)]
        public string url { get; set; }

        [Required]
        [StringLength(10)]
        public string ProductID { get; set; }

        public bool? Official { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }
    }
}
