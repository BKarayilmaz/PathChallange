using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathChallange.Entities
{
    public class Products
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        public string ProdcutName { get; set; }
        public int CategoryID { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public int ShippingCompanyId { get; set; }
        public bool IsDeleted{ get; set; }
        public bool IsDeletedConfirmaiton{ get; set; }

    }
}
