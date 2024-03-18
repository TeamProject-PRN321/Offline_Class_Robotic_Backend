using OfficeClassRobotic.DAO.Students;

namespace OfficeClassRobotic.Repository.Students
{
    public interface IStudentRepository
    {
        /*public Task<ClassRoboticResponse> CreateStudent(CreateStudentCommand student);
        public Task<ClassRoboticResponse> UpdateStudent(UpdateStudentCommand student);
        public Task<ClassRoboticResponse> DeleteStudent(DeleteStudentCommand student);
        public Task<List<StudentResponse>> GetAllStudent();
        public Task<StudentResponse> GetStudentById(string studentId);*/
        public Task<List<ScheduleOfStudent>?> GetScheduleOfStudentByStudentId(GetStudentScheduleByStudentIdRequest request);
        public Task<StudentDTO> GetStudentByStudentId(Guid studentId);
        public Task<StudentDTO> GetStudentByAppUserId(Guid appUserId);
        public Task<List<StudentDTO>> GetStudentByStudentName(string studentName);
        public Task<List<StudentDTO>> GetAllStudent();
    }
}
