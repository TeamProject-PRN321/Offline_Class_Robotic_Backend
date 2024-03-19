using OfficeClassRobotic.DAO.GiaoTrinhs;

namespace OfficeClassRobotic.DAO.Subjects
{
    public class CreateSubjectCommand
    {
        public string? SubjectName { get; set; }
        public int TotalSlots { get; set; }
    }

    public class UpdateSubjectCommand
    {
        public string SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public int TotalSlots { get; set; }
        public string GiaoTrinhId { get; set; }
    }

    public class DeleteSubjectCommand
    {
        public string SubjectId { get; set; }
    }

    public class SubjectResponse 
    {
        public Guid Id { get; set; }
        public string? SubjectName { get; set; }
        public int TotalSlots { get; set; }
        public GiaoTrinhResponse? GiaoTrinhData { get; set; }
    }
}
