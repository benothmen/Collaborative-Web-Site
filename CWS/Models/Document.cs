using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CWS.Models
{
    [Table("Documents")]
    public class Document
    {
        [Key]
        public int DocumentsID { get; set; }
        [Required]
        public DateTime DocumentsDate { get; set; }
        [Required]
        public string DocumentsName { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
