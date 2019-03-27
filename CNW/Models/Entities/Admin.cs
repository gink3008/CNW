namespace CNW.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(10)]
        public string nameAdmin { get; set; }

        [StringLength(10)]
        public string ChucVuId { get; set; }

        public virtual ChucVu ChucVu { get; set; }
    }
}
