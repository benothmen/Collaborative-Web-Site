using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CWS.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [Required]
        public string CommentContent { get; set; }
        [Required]
        public DateTime CommentDate { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
