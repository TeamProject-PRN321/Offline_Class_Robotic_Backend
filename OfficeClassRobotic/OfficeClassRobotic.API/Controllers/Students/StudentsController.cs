using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Parents;
using OfficeClassRobotic.DAO.Students;
using OfficeClassRobotic.Repository.Parents;
using OfficeClassRobotic.Repository.Students;

namespace OfficeClassRobotic.API.Controllers.Students
{
    [Route("api/v1/student")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        public StudentsController()
        {
            studentRepository = new StudentRepository();
        }

        [HttpPost]
        [Route("add")]
        public Task Create(StudentDTO request)
        {
            var result = studentRepository.CreateStudent(request);
            return result;
        }
    }
}
