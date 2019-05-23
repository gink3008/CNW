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
        [Required(ErrorMessage = "Can nhap ID dang nhap")]
        public string id { get; set; }

        [StringLength(50)]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Ban chua nhap ten")]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "DateofBirth")]
        [Required(ErrorMessage = "Ban chua dien ngay sinh")]
        public DateTime? DateofBirth { get; set; }

        [Display(Name = "password")]
        [StringLength(20, MinimumLength = 8 , ErrorMessage = "Password ban nhap chua dung yeu cau")]
        [Required(ErrorMessage = "yeu cau dien Password")]
        public string password { get; set; }

        [Display(Name = "Repeat Password")]
        [Compare("password", ErrorMessage = "Confirm Password chua khop Password da nhap")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Ban chua chon gioi tinh")]
        public bool? Sex { get; set; }

        [Display(Name = "Phone")]
        public int? Phone { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
