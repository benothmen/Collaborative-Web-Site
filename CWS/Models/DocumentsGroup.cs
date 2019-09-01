
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CWS.Models
{
    [Table("DocumentsGroups")]
    public class DocumentsGroup
    {
        [Key]
        public int DocumentsGroupsID { get; set; }
        [Required]
        public DateTime DocumentsGroupsDate { get; set; }
        [Required]
        public string DocumentsGroupsName { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
