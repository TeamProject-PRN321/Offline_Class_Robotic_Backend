using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateOnly Birthday { get; set; }
        [ForeignKey("Parent")]
        public int ParentID { get; set; }
        public virtual Parent Parent { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<FeedBack> Feedbacks { get; set; }
    }
}
