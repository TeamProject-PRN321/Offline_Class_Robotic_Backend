using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public DateOnly Birthday { get; set; }
        public string Address { get; set; }
        public string Major { get; set; }
        public string Certification { get; set; }
        public virtual ICollection<FeedBack> Feedbacks { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
