using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PathChallange.Entities.Models
{
    public class Authority
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorityID { get; set; }
        public string AuthorityName { get; set; }
        public List<Users> Users { get; set; }
    }
}
