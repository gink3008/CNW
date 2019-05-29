using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CNW.Models.Entities
{
    public class User
    {
        [Display(Name = "ID")]
        [StringLength(20)]
        [Required(ErrorMessage = "Can nhap ID dang nhap")]
        public string id { get; set; }

        [StringLength(50)]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Ban chua nhap ten")]
        public string Name { get; set; }

        [Display(Name = "DateofBirth")]
        [Required(ErrorMessage = "Ban chua dien ngay sinh")]
        public DateTime? DateofBirth { get; set; }

        [Display(Name = "password")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Password ban nhap chua dung yeu cau")]
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
    }
}