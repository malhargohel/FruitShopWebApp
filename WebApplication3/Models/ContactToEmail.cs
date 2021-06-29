using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class ContactToEmail
    {
        [Required, Display(Name = "Your name")]
        public string Name { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        //public HttpPostedFileBase Upload { get; set; }

        
        [Required]
        public string Subject { get; set; }

    }
}
