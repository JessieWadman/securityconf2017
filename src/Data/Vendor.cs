using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlatPlanetCafe.Data
{
    [Table("Vendors")]
    public class Vendor
    {
        [Key]
        [Required]
        [MaxLength(5)]
        [Display(Name = "Vendor ID")]
        public string VendorID { get; set; }

        [Required]
        [MaxLength(40)]
        [Display(Name = "Company")]
        public string CompanyName { get; set; }

        [MaxLength(30)]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [MaxLength(30)]
        [Display(Name = "Contact Title")]
        public string ContactTitle { get; set; }

        [MaxLength(60)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [MaxLength(15)]
        [Display(Name = "City")]
        public string City { get; set; }

        [MaxLength(15)]
        [Display(Name = "Region")]
        public string Region { get; set; }

        [MaxLength(10)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [MaxLength(15)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [MaxLength(24)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [MaxLength(24)]
        [Display(Name = "Fax")]
        public string Fax { get; set; }
    }
}
