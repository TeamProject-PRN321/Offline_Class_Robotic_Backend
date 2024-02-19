namespace OfficeClassRobotic.DAO.TeacherSubjects
{
    public class TeacherSubjectDTO
    {
        public List<Guid> ListSubjectId { get; set; } = null!;
        public Guid TeacherId { get; set; }
    }
}
