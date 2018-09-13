using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace applicationProject.Models
{
    public class Admin
    {
        public string AdminId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required, Display(Name = "Email*"), EmailAddress]
        public string Email { get; set; }
  
        

    }
}