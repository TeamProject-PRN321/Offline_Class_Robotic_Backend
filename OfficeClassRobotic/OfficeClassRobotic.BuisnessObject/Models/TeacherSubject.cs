using Models.OfficeClassRobotic.BuisnessObject;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    public class TeacherSubject
    {
        public Guid SubjectId { get; set; }
        public Guid TeacherId { get; set; }

        public virtual Teacher? Teacher { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
