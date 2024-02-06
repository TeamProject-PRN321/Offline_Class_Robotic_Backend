using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.GiaoTrinhForSubject;
using OfficeClassRobotic.DAO.Parents;
using OfficeClassRobotic.Repository.Parents;

namespace OfficeClassRobotic.API.Controllers.Parents
{
    [Route("api/v1/parent")]
    [ApiController]
    public class ParentsController : ControllerBase
    {
        private readonly IParentRepostitory parentRepostitory;
        public ParentsController()
        {
            parentRepostitory = new ParentRepostitory();
        }

        [HttpPost]
        [Route("add")]
        public Task Create(ParentDTO request)
        {
            var result = parentRepostitory.CreateParent(request);
            return result;
        }
    }
}
