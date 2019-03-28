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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Admin()
        {
            UserADs = new HashSet<UserAD>();
        }

        [StringLength(10)]
        public string id { get; set; }

        [StringLength(10)]
        public string nameAdmin { get; set; }

        [StringLength(10)]
        public string ChucVuId { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAD> UserADs { get; set; }
    }
}
