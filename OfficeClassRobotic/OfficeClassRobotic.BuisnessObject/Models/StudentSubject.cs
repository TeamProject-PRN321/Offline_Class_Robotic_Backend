using System.ComponentModel.DataAnnotations.Schema;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class StudentSubject
    {
        //[ForeignKey(nameof(Subject))]
        public Guid SubjectId { get; set; }
        //[ForeignKey(nameof(Student))]
        public Guid StudentId { get; set; }

        public virtual Student? Student { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
