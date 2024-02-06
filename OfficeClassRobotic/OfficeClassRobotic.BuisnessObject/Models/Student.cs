using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateOnly Birthday { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
        [ForeignKey("Parent")]
        public int ParentID { get; set; }

        public virtual Parent Parent { get; set; }
        public virtual IList<Subject> Subjects { get; set; }
        public virtual IList<FeedBack> Feedbacks { get; set; }
    }
}
