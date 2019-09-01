
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CWS.Models
{
    [Table("ToDos")]
    public class ToDo
    {
        [Key]
        public int TaskID { get; set; }
        [Required]
        public string TasKContent { get; set; }
        [Required]
        public DateTime TaskDateTime { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
