namespace CNW.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            DetailBills = new HashSet<DetailBill>();
        }

        [StringLength(50)]
        public string id { get; set; }

        [StringLength(20)]
        public string customerID { get; set; }

        [StringLength(10)]
        public string paymentMethod { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string CustomerNameOnline { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CustomerDateOnline { get; set; }

        public bool? CustomerGenerOnline { get; set; }

        public int? CustomerPhoneOnline { get; set; }

        public string CustomerAddressOnline { get; set; }

        public int? TotalOnBill { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailBill> DetailBills { get; set; }
    }
}
