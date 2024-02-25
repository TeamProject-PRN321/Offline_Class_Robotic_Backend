namespace OfficeClassRobotic.DAO.Teachers
{
    public class GetSubjectOfTeacher
    {
        public Guid SubjectId { get; set; }
        public string? SubjectName { get; set; }
    }
    public class TeacherDTO 
    {
        public Guid TeacherId { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly Birthday { get; set; }
        public string? Address { get; set; }
        public string? Major { get; set; }
        public string? Certification { get; set; }
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
}
