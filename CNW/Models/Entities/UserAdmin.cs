namespace CNW.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserAdmin")]
    public partial class UserAdmin
    {
        [StringLength(50)]
        public string id { get; set; }

        [StringLength(10)]
        public string AdminID { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public virtual Admin Admin { get; set; }
    }
}
