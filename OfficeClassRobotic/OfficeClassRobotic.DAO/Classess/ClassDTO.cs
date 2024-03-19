using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.Classess
{
    public class CreateClassesCommand
    {
        public string? ClassName { get; set; }
        public List<string>? DayStudy { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public List<StudentInputData> StudentListId { get; set; }
        public DateTime DateStartClass { get; set; }
        public string SubjectId { get; set; }

        // teacherId
        public string TeacherId { get; set; }
        public string ClassRoomID { get; set; }
    }

    public class CreateClassStudentExcel
    {
        public string? ClassName { get; set; }
        public List<StudentExcelData> StudentListIds { get; set; }
    }
    public class StudentExcelData
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string Score { get; set; }
    }

    public class StudentInputData
    {
        public string StudentId { get; set; }
    }
    public class DateFreeTime
    {
        public DateOnly Date { get; set; }
    }
    public class DateFreeTimeForRoom
    {
        public DateOnly Date { get; set; }
        public List<ClassRoomDataResponse> ClassRoomData { get; set; }
    }
    public class CheckData
    {
        public List<string>? DayStudy { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DateOnly DateStudy { get; set; }
        public string SubjectId { get; set; }
    }
    public class CheckSchedularTeacherResponse
    {
        // subject
        public Guid SubjectId { get; set; }
        public string SubjectName { get; set; }
        //teacher info 
        public Guid Id { get; set; }
        public Guid AppUserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? PhotoUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string? Message { get; set; } = "";
        // ngày rảnh
        public List<DateFreeTime> ListDateFreeTime { get; set; }
    }
    public class CheckDataResponse
    {
        public Guid SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int TotalSlots { get; set; }
        public string? Message { get; set; } = "";
        public List<TeacherDataResponse> TeacherData { get; set; }
        public List<DateFreeTimeForRoom> DateFreeTimeForRoomData { get; set; }
    }
    public class ClassRoomDataResponse
    {
        public Guid Id { get; set; }
        public string ClassRoomName { get; set; }
        public string Description { get; set; }
        public Guid TrungTamRoboticId { get; set; }
    }
    public class TeacherDataResponse
    {
        public Guid Id { get; set; }
        public Guid AppUserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? PhotoUrl { get; set; }
        public string PhoneNumber { get; set; }

        // ngày rảnh
        public List<DateFreeTime> ListDateFreeTime { get; set; }
    }
    public class ClassDTO
    {
        public string? ClassName { get; set; }
        public List<string>? DayStudy { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int TotalStudentInClass { get; set; }
        public Guid SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Guid TeacherId { get;set; }
        public Guid AppUserTeacherId { get; set; }
        public string? TeacherName { get;set; }
    }

    public class ClassDataResponse
    {
        public Guid ClassId { get; set; }
        public string? ClassName { get; set; }
        public List<string>? DayStudy { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public Guid SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Guid TeacherId { get; set; }
        public string? TeacherName { get; set; }
        public Guid StudentId { get; set; }
        public string? StudentName { get; set;}
        public DateTime DateStartStudy { get; set; }
        public DateTime DateEndStudy { get; set; }
    }

    public class StudentsOfClassesResponse
    {
        public int TotalStudentsInClass { get; set; }
        public List<ClassDataResponse> ClassDataResponses { get; set; }
    }
}
