using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PathChallange.Entities.Models
{
    public class Orders
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //Same Random Letter And Number For Each Product In Order
        public string OrderID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
    }
}
