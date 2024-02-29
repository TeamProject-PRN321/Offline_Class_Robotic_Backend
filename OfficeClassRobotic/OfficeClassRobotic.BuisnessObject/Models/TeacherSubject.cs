using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models.Common;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    public class TeacherSubject : ISoftDelete
    {
        public Guid SubjectId { get; set; }
        public Guid TeacherId { get; set; }
        public bool IsDeleted { get; set; } = false;

        public virtual Teacher? Teacher { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
