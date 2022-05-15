using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PathChallange.Entities.Models
{
    public class Users
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AuthorityID { get; set; }
        public virtual Authority Authority { get; set; }
    }
}
