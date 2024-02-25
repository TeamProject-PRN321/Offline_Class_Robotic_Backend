using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Classess;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.GiaoTrinhs;
using OfficeClassRobotic.Repository.Classess;
using OfficeClassRobotic.Repository.GiaoTrinhs;

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
        public Task<ClassRoboticResponse> Create(ClassDTO request)
        {
            var result = _classRepository.CreateClass(request);
            return result;
        }
    }
}
