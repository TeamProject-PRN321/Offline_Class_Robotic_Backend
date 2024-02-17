using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
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
        private readonly IStudentRepository _studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost]
        [Route("add")]
        public Task<ClassRoboticResponse> Create(CreateStudentCommand request)
        {
            var result = _studentRepository.CreateStudent(request);
            return result;
        }

        [HttpPut]
        [Route("edit")]
        public Task<ClassRoboticResponse> Update(UpdateStudentCommand request)
        {
            var result = _studentRepository.UpdateStudent(request);
            return result;
        }

        [HttpDelete]
        [Route("remove")]
        public Task<ClassRoboticResponse> Delete(DeleteStudentCommand request)
        {
            var result = _studentRepository.DeleteStudent(request);
            return result;
        }

        [HttpGet]
        [Route("all")]
        public Task<List<StudentResponse>> GetAll()
        {
            var result = _studentRepository.GetAllStudent();
            return result;
        }

        [HttpGet]
        [Route("{parentId}")]
        public Task<StudentResponse> GetById(string parentId)
        {
            var result = _studentRepository.GetStudentById(parentId);
            return result;
        }
    }
}
