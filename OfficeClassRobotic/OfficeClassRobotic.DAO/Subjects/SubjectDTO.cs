using OfficeClassRobotic.DAO.GiaoTrinhs;

namespace OfficeClassRobotic.DAO.Subjects
{
    /// <summary>
    /// tạo môn học với giáo trình cho 1 list sinh viên mới đăng ký khóa học
    /// </summary>
    public class SubjectDTO
    {
        public string? SubjectName { get; set; }
        public int TotalSlots { get; set; }
        public List<StudentData>? StudentList { get; set; }
        public GiaoTrinhDTO? GiaoTrinhDTO { get; set; }
    }

    /// <summary>
    /// Update giáo trình lại cho list sinh viên với môn học này
    /// </summary>
    public class UpdateSubjectDTO
    {
        public string SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public int TotalSlots { get; set; }
        public List<StudentData>? StudentList { get; set; }
        public string GiaoTrinhId { get; set; }
    }

    public class StudentData
    {
        public string StudentID { get; set; }
    }

    public class GiaoTrinhDTO
    {
        public string? GiaoTrinhName { get; set; }
        public string? Description { get; set; }
        public string? FilePDF { get; set; }
    }
    public class SubjectData
    {
        public string? SubjectName { get; set; }
        public int TotalSlots { get; set; }
        public GiaoTrinhDTO? GiaoTrinhDTO { get; set; }
    }
}
