namespace CNW.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(20)]
        public string username { get; set; }

        [StringLength(20)]
        public string password { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
