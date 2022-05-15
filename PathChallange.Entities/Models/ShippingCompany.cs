using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PathChallange.Entities.Models
{
    public class ShippingCompany
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
