using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public DateOnly Birthday { get; set; }
        public string Address { get; set; }
        public string Major { get; set; }
        public string Certification { get; set; }

        public virtual IList<FeedBack> Feedbacks { get; set; }
        public virtual IList<Class> Classes { get; set; }
    }
}
