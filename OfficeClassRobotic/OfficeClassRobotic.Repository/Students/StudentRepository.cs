using AutoMapper;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Parents;
using OfficeClassRobotic.DAO.Students;

namespace OfficeClassRobotic.Repository.Students
{
    public class StudentRepository : IStudentRepository
    {
        /*private StudentDAO studentDAO;
        private readonly IMapper _mapper;
        public StudentRepository(IMapper mapper)
        {
            studentDAO = new StudentDAO();
            _mapper = mapper;
        }
        public async Task<ClassRoboticResponse> CreateStudent(CreateStudentCommand student)
        {
            await studentDAO.CreateStudent(student);
            return new ClassRoboticResponse
            {
                Message = "Create Successfully"
            };
        }

        public async Task<ClassRoboticResponse> DeleteStudent(DeleteStudentCommand student)
        {
            await studentDAO.DeleteStudent(student);
            return new ClassRoboticResponse
            {
                Message = "Delete Successfully"
            };
        }

        public async Task<List<StudentResponse>> GetAllStudent()
        {
            var student = await studentDAO.GetAllStudent();
            var response = _mapper.Map<List<StudentResponse>>(student);
            return response;
        }

        public async Task<StudentResponse> GetStudentById(string studentId)
        {
            var student = await studentDAO.GetStudentById(studentId);
            var response = _mapper.Map<StudentResponse>(student);
            return response;
        }

        public async Task<ClassRoboticResponse> UpdateStudent(UpdateStudentCommand student)
        {
            await studentDAO.UpdateStudent(student);
            return new ClassRoboticResponse
            {
                Message = "Update Successfully"
            };
        }*/
    }
}
