
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CWS.Models
{
    [Table("Messages")]
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        [Required]
        public string MessageContent { get; set; }
        [Required]
        public DateTime MessageDate { get; set; }
        public string ApplicationUserIdR { get; set; }
        public virtual ApplicationUser ApplicationUserR { get; set; }
        public string ApplicationUserIdS { get; set; }
        public virtual ApplicationUser ApplicationUserS { get; set; }
   
    }
}
