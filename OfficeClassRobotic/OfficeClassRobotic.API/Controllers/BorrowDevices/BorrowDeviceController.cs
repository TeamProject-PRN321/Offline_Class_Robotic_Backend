using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.BorrowDevices;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.Repository.BorrowDevices;
using OfficeClassRobotic.Repository.Classess;

namespace OfficeClassRobotic.API.Controllers.BorrowDevices
{
    [Route("api/v1/borrowdevice")]
    [ApiController]
    public class BorrowDeviceController : ControllerBase
    {
        private readonly IBorrowDeviceRepository _repo;
        public BorrowDeviceController(IBorrowDeviceRepository repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public async Task<ClassRoboticResponse> TeacherBorrowDevice([FromBody]BorrowDeviceDTO request)
        {
            return await _repo.TeacherBorrowDevice(request);
        }

    }
}
