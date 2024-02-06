using OfficeClassRobotic.DAO.Students;

namespace OfficeClassRobotic.Repository.Students
{
    public class StudentRepository : IStudentRepository
    {
        private StudentDAO studentDAO;
        public StudentRepository()
        {
            studentDAO = new StudentDAO();
        }
        public async Task CreateStudent(StudentDTO student)
        {
            await studentDAO.CreateStudent(student);    
        }
    }
}
