using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Subjects;
using OfficeClassRobotic.DAO.Teachers;
using OfficeClassRobotic.Repository.Teachers;

namespace OfficeClassRobotic.API.Controllers.Teachers
{
    [Route("api/v1/teacher")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private ITeacherRepository _repo;

        public TeachersController(ITeacherRepository repo)
        {
            _repo = repo;
        }
        [HttpPost]
        [Route("add")]
        public Task<ClassRoboticResponse> Create(CreateTeacherDTO request)
        {
            var result = _repo.CreateTeacher(request);
            return result;
        }
    }
}
