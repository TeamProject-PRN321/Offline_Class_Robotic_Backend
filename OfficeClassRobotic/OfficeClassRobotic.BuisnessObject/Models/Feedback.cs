using OfficeClassRobotic.BuisnessObject.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class FeedBack : BaseAuditableEntity
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        //public int FeedbackID { get; set; }
        public string FeedBackName { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Student")]
        public Guid StudentId { get; set; }
        [ForeignKey("Teacher")]
        public Guid TeacherId { get; set; }
 
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
