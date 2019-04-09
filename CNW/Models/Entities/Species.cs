namespace CNW.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Species
    {
        [StringLength(10)]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string categoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Product Product { get; set; }
    }
}
