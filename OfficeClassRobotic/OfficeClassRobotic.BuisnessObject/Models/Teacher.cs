using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Teacher : BaseAuditableEntity
    {
        public string Name { get; set; } = null!;
        public DateOnly Birthday { get; set; }
        public string Address { get; set; }
        public string Major { get; set; }
        public string Certification { get; set; }
        [Required]
        public Guid AppUserId { get; set; }

        public virtual IList<FeedBack> Feedbacks { get; set; }
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }

    }
}
