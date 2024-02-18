using Models.OfficeClassRobotic.BuisnessObject;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OfficeClassRobotic.BuisnessObject.Models.Common;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    /// <summary>
    /// Dùng để lưu sinh viên học tại lớp nào
    /// Khác với Class - dùng để lưu schedule của 1 classroom
    /// Thì ở đây ClassSubject dùng để lưu lớp của 1 môn
    /// Ví dụ. Tại ClassRoom 001 sẽ có time Schedule là Class :
    /// Ở thời gian từ 7:00 tới 9:30 sẽ có 1 ClassSubject học (NET1602)
    /// </summary>
    public class ClassSubject : BaseAuditableEntity
    {
        public string? ClassSubjectName { get; set;}

        [ForeignKey("Teacher")]
        public Guid TeacherID { get; set; }

        // Quan hệ
        public virtual Teacher Teacher { get; set; }
        public IList<StudentSubject> StudentSubjects { get; set; }
        public IList<ClassSchedule> ClassSchedules { get; set; }
    }
}
