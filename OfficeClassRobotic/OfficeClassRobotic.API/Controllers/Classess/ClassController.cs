using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Classess;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.Repository.Classess;

namespace OfficeClassRobotic.API.Controllers.Classess
{
    [Route("api/v1/classes")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassRepository _classRepository;
        public ClassController(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        [HttpPost]
        [Route("add")]
        public Task<ClassRoboticResponse> Create(CreateClassesCommand request)
        {
            var result = _classRepository.CreateClass(request);
            return result;
        }

        [HttpPost]
        [Route("check-schedular-teacher")]
        public Task<CheckDataResponse> Check(CheckData request)
        {
            var result = _classRepository.CheckSchedularTeacher(request);
            return result;
        }
        [HttpGet]
        [Route("get-all-classes-are-not-finshed")]
        public async Task<List<ClassDTO>> GetAllClassesAreNotFinished()
        {
            var result = await _classRepository.GetAllClassesAreNotFinished();
            return result;
        }
    }
}
