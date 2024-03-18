using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Parents;
using OfficeClassRobotic.Repository.GiaoTrinhForSubject;
using OfficeClassRobotic.DAO.GiaoTrinhs;
using OfficeClassRobotic.Repository.GiaoTrinhs;

namespace OfficeClassRobotic.API.Controllers.GiaoTrinhs
{
    [Route("api/v1/giao-trinh")]
    [ApiController]
    public class GiaoTrinhsController : ControllerBase
    {
        private readonly IGiaoTrinhRepository _giaoTrinhRepository;
        public GiaoTrinhsController(IGiaoTrinhRepository giaoTrinhRepository)
        {
            _giaoTrinhRepository = giaoTrinhRepository;
        }
        [HttpPost]
        [Route("add")]
        public Task<ClassRoboticResponse> Create(CreateGiaoTrinhCommand request)
        {
            var result = _giaoTrinhRepository.CreateGiaoTrinh(request);
            return result;
        }

        [HttpPut]
        [Route("edit")]
        public Task<ClassRoboticResponse> Update(UpdateGiaoTrinhCommand request)
        {
            var result = _giaoTrinhRepository.UpdateGiaoTrinh(request);
            return result;
        }

        [HttpDelete]
        [Route("remove")]
        public Task<ClassRoboticResponse> Delete(DeleteGiaoTrinhCommand request)
        {
            var result = _giaoTrinhRepository.DeleteGiaoTrinh(request);
            return result;
        }

        [HttpGet]
        [Route("all")]
        public Task<List<GiaoTrinhResponse>> GetAll()
        {
            var result = _giaoTrinhRepository.GetAllGiaoTrinh();
            return result;
        }

        [HttpGet]
        [Route("{giaoTrinhId}")]
        public Task<GiaoTrinhResponse> GetById(string giaoTrinhId)
        {
            var result = _giaoTrinhRepository.GetGiaoTrinhById(giaoTrinhId);
            return result;
        }
    }
}
