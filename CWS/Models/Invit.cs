
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CWS.Models
{
    [Table("Invits")]
    public class Invit
    {
        [Key]
        public int InvitID { get; set; }
        [Required]
        public DateTime InvitDate { get; set; }
        [Required]
        public string Status { get; set; }
        public virtual ApplicationUser ApplicationUserR { get; set; }
        public virtual ApplicationUser ApplicationUserS { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

    }
}
