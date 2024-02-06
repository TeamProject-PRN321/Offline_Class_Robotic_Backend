using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.GiaoTrinhForSubject;
using OfficeClassRobotic.Repository.GiaoTrinhForSubject;

namespace OfficeClassRobotic.API.Controllers.GiaoTrinhs
{
    [Route("api/v1/giao-trinh-subject")]
    [ApiController]
    public class GiaoTrinhForSubjectsController : ControllerBase
    {
        private readonly IGiaoTrinhForSubjectRepository _giaoTrinhForSubjectsRepository;
        public GiaoTrinhForSubjectsController(IGiaoTrinhForSubjectRepository giaoTrinhForSubjectsRepository)
        {
            _giaoTrinhForSubjectsRepository = giaoTrinhForSubjectsRepository;
        }

        [HttpPost]
        [Route("add")]
        public Task Create(GiaoTrinhDTO request)
        {
            var result = _giaoTrinhForSubjectsRepository.CreateGiaoTrinhForSubject(request);
            return result;
        }
    }
}
