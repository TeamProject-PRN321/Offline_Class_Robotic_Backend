using OfficeClassRobotic.DAO.Accounts;

namespace OfficeClassRobotic.DAO.Students
{
    public class StudentDTO : AccountDTO
    {
        public Guid StudentId { get; set; }
        public ParentDTO? Parent { get; set; }
    }
    public class ParentDTO : AccountDTO
    {
        public Guid ParentId { get; set; }
    }
    public class CreateStudentCommand
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public DateOnly Birthday { get; set; }

        public string ParentID { get; set; }
    }
    public class GetStudentScheduleByStudentIdRequest
    {
        public Guid StudentId { get; set; }
    }
    public class ScheduleOfStudent
    {
        public Guid SubjectId { get; set; }
        public string SubjectName { get; set; } = null!;
        public string TimeStart { get; set; } = null!;
        public string TimeEnd { get; set; } = null!;
        public Guid TeacherId { get; set; }
        public string TeacherName { get; set; } = null!;
        public string DateLearn { get; set; } = null!;
        public int SlotRemaining { get; set; } 
        public string SlotAttendanceStatus { get; set; } = null!;
    }
    public class DeleteStudentCommand
    {
        public string StudentId { get; set; }
    }

    public class UpdateStudentCommand
    {
        public string StudentId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public DateOnly Birthday { get; set; }

        public string ParentID { get; set; }
    }

    public class StudentResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public DateOnly Birthday { get; set; }

        public Guid ParentId { get; set; }
        public DateTime? Created { get; set; }
    }
}
