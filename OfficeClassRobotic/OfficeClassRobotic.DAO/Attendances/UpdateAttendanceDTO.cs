namespace OfficeClassRobotic.DAO.Attendances
{
    public class UpdateAttendanceDTO
    {
        public string ClassName { get; set; } = null!;
        public List<AttendenceStudentOfClass>? AttendanceOfStudentInClass { get; set; } 
    }
    public class AttendenceStudentOfClass
    {
        public string DateStudy { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public string StudentName { get; set; } = null!;    
        public Guid StudentId { get; set; } 
        public int AttendanceStatus { get; set; } 
        public Guid AttendanceId { get; set; }  
    }
}
