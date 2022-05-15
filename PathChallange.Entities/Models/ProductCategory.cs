using PathChallange.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PathChallange.Entities
{
    public class ProductCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Products> Products { get; set; }
        public int CompanyID { get; set; }
        public virtual ShippingCompany ShippingCompany { get; set; }
    }
}
