using OfficeClassRobotic.DAO.Classrooms;
using OfficeClassRobotic.DAO.Students;

namespace OfficeClassRobotic.Repository.Students
{
    public interface IStudentRepository
    {
        
        /*public Task<List<StudentResponse>> GetAllStudent();
        public Task<StudentResponse> GetStudentById(string studentId);*/
        public Task<List<ScheduleOfStudent>?> GetScheduleOfStudentByStudentId(GetStudentScheduleByStudentIdRequest request);
        public Task<StudentDTO> GetStudentByStudentId(Guid studentId);
        public Task<StudentDTO> GetStudentByAppUserId(Guid appUserId);
        public Task<List<StudentDTO>> GetStudentByStudentName(string studentName);
        public Task<List<StudentDTO>> GetAllStudent();
        public Task<List<StudentDTO>> SearchStudent(string studentName);
        public Task<List<GetStudentGrade>> GetStudentGrades(Guid studentId);
        public Task<List<GetStudentAttendance>> GetStudentAttendance(Guid studentId);

    }
}
