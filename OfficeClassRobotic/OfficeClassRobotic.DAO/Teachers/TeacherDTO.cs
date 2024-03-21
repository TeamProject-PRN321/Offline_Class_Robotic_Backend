using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models;

namespace OfficeClassRobotic.DAO.Teachers
{
    public class GetSubjectOfTeacher
    {
        public Guid SubjectId { get; set; }
        public string? SubjectName { get; set; }
    }

    public class ConnectTeacherWithListSubjectRequest
    {
        public Guid TeacherId { get; set; }
        public List<Guid> ListSubjectId { get; set; } = null!;
    }
    public class TeacherDTO
    {
        public Guid TeacherId { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly Birthday { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public List<GetSubjectOfTeacher> ListSubjectOfTeacher { get; set; }
    }
    public class CreateTeacherDTO
    {
        public string Name { get; set; } = null!;
        public DateOnly Birthday { get; set; }
        public string? Address { get; set; }/*
        public string? Major { get; set; }
        public string? Certification { get; set; }*/
        public List<Guid>? ListSubjectId { get; set; }
    }

    public class UpdateTeacherDTO : CreateTeacherDTO
    {
        public Guid TeacherId { get; set; }
    }

    public class GetTeacherOrDeleteTeacherByTeacherId
    {
        public Guid TeacherId { get; set; }
    }
    public class GetTeacherBySubjectId
    {
        public Guid SubjectId { get; set; }
    }

    public class TeacherScheduleRequest
    {
        public string? Keyword { get; set; }
        public Guid AppUserId { get; set; }
        public DateTime DateStartOfWeek { get; set; }
        public DateTime DateEndOfWeek { get; set; }
    }
    public class TeacherSchedule
    {
        /// <summary>
        /// Tên Lớp
        /// </summary>
        public string ClassName { get; set; } = null!;
        /// <summary>
        /// Vị trí phòng học - Tên Phòng Học
        /// </summary>
        public string ClassroomName { get; set; } = null!;
        public string DayStudy { get; set; } = null!;
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string TimeDetail { get; set; } = null!;
        public int TotalStudentInClass { get; set; }
        /// <summary>
        /// 0. Là chưa
        /// 1. Là rồi
        /// </summary>
        public int ClassWasCheckedAttendant { get; set; }
    }

    public class TeacherSubjectResponse
    {
        public Guid SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public int TotalSlots { get; set; }
        //public Guid GiaoTrinhId { get; set; }

        public List<TeacherData> TeacherResponse { get; set; }
    }

    public class TeacherData
    {
        public Guid TeacherId { get; set; }
        public Guid AppUserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string? PhotoUrl { get; set; }
    }

}
