namespace CNW.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Bills = new HashSet<Bill>();
        }

        [Display ( Name = "ID")]
        [StringLength(20)]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "DateofBirth")]
        public DateTime? DateofBirth { get; set; }

        [Display(Name = "password")]
        [StringLength(20, MinimumLength = 8 , ErrorMessage = "Password ban nhap chua dung yeu cau")]
        public string password { get; set; }

        [Display(Name = "Repeat Password")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Confirm Password ban nhap chua dung yeu cau")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Gender")]
        public bool? Sex { get; set; }

        [Display(Name = "Repeat Phone")]
        public int? Phone { get; set; }

        [Display(Name = "Repeat Address")]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
