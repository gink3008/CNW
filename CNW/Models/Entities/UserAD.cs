namespace CNW.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserAD")]
    public partial class UserAD
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(10)]
        public string AdminID { get; set; }

        [StringLength(40)]
        public string username { get; set; }

        [StringLength(40)]
        public string password { get; set; }

        public virtual Admin Admin { get; set; }
    }
}
