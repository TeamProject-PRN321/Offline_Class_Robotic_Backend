using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Teacher : BaseAuditableEntity
    {
        [ForeignKey("AppUser")]
        public Guid AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual IList<FeedBack> Feedbacks { get; set; }
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }

    }
}
