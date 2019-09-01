
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CWS.Models
{
    [Table("Groups")]

    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        [Required]
        public string GroupName { get; set; }
        public DateTime Creaded { get; set; }
        public DateTime Updated { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
