using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace CWS.Models
{
    [Table("ApplicationUsers")]
    public class ApplicationUser : IdentityUser
    {
  
        public string ImageName { get; set; }
        public virtual ICollection<ToDo> ToDos { get; set; }
        public virtual ICollection<Document> Documents { get; set; }

    }
}
