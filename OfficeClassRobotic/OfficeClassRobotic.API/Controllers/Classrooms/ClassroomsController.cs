using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using OfficeClassRobotic.DAO.Classrooms;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.GiaoTrinhs;
using OfficeClassRobotic.DAO.Subjects;
using OfficeClassRobotic.Repository.Classess;
using OfficeClassRobotic.Repository.Classrooms;

namespace OfficeClassRobotic.API.Controllers.Classrooms
{
    [Route("api/v1/classroom")]
    [ApiController]
    public class ClassroomsController : ControllerBase
    {
        private readonly IClassroomRepository _classroomRepository;
        public ClassroomsController(IClassroomRepository classroomRepository)
        {
            _classroomRepository = classroomRepository;
        }

        [HttpGet]
        [Route("all")]
        public Task<List<ClassroomResponse>> GetAll()
        {
            var result = _classroomRepository.GetAllClassroom();
            return result;
        }

        [HttpGet]
        [Route("cancel-device")]
        public Task<List<ClassroomCancelDeviceResponse>> GetCancelDevice()
        {
            var result = _classroomRepository.GetAllClassroomCancelDeviceResponse();
            return result;
        }

        [HttpGet("search/{keyword}")]
        public Task<List<ClassroomResponse>> Search(string keyword) => _classroomRepository.SearchClassroom(keyword);

        [HttpPost]
        [Route("add")]
        public Task<ClassRoboticResponse> Create(CreateDeviceForClassroomCommand request)
        {
            var result = _classroomRepository.CreateDeviceForClassroom(request);
            return result;
        }

        [HttpPut]
        [Route("edit")]
        public Task<ClassRoboticResponse> Update(UpdateDeviceForClassroomCommand request)
        {
            var result = _classroomRepository.UpdateDeviceForClassroom(request);
            return result;
        }

        [HttpDelete]
        [Route("remove")]
        public Task<ClassRoboticResponse> Delete(DeleteDeviceForClassroomCommand request)
        {
            var result = _classroomRepository.DeleteDeviceForClassroom(request);
            return result;
        }
    }
}
