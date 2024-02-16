using Models.OfficeClassRobotic.BuisnessObject;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    /// <summary>
    /// Dùng để lưu sinh viên học tại lớp nào
    /// Khác với Class - dùng để lưu schedule của 1 classroom
    /// Thì ở đây ClassSubject dùng để lưu lớp của 1 môn
    /// Ví dụ. Tại ClassRoom 001 sẽ có time Schedule là Class :
    /// Ở thời gian từ 7:00 tới 9:30 sẽ có 1 ClassSubject học (NET1602)
    /// </summary>
    public class ClassSubject
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassSubjectID { get; set; } 
        public string? ClassSubjectName { get; set;}
        public bool IsDeleted { get; set; } = false;
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }

        // Quan hệ
        public virtual Teacher Teacher { get; set; }
        public IList<StudentSubject> StudentSubjects { get; set; }
        public IList<ClassSchedule> ClassSchedules { get; set; }
        public IList<Attendance> Attendances { get; set; }
    }
}
