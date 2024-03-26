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
        [Route("create-request-borrow-device")]
        public async Task<ClassRoboticResponse> TeacherBorrowDevice([FromBody]BorrowDeviceDTO request)
        {
            return await _repo.TeacherBorrowDevice(request);
        }
        [HttpGet]
        [Route("get-all-request-borrow-device-does-not-process-before")]
        public async Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceDoNotProcessBeforeOfTeacher()
        {
            return await _repo.ViewAllRequestBorrowDeviceDoNotProcessBeforeOfTeacher();
        }
        [HttpGet]
        [Route("get-all-request-borrow-device")]
        public async Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceOfTeacher()
        {
            return await _repo.ViewAllRequestBorrowDeviceOfTeacher();
        }
        [HttpGet]
        [Route("admin-accept-request/{borrowDeviceId}")]
        public async Task<ClassRoboticResponse> AdminAcceptRequestOfTeacher(Guid borrowDeviceId)
        {
            return await _repo.AdminAcceptRequestOfTeacher(borrowDeviceId);
        }
        [HttpGet]
        [Route("admin-reject-request/{borrowDeviceId}")]
        public async Task<ClassRoboticResponse> AdminRejectRequestOfTeacher(Guid borrowDeviceId)
        {
            return await _repo.AdminRejectRequestOfTeacher(borrowDeviceId);
        }
        [HttpGet]
        [Route("teacher-view-all-request-borrow-device/{appUserTeacherId}")]
        public async Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceOfTeacherInHistoryByTeacherId(Guid appUserTeacherId)
        {
            return await _repo.ViewAllRequestBorrowDeviceOfTeacherInHistoryByTeacherId(appUserTeacherId);
        }
        [HttpGet]
        [Route("teacher-give-back-/{borrowDeviceId}/{appUserTeacherId}")]
        public async Task<ClassRoboticResponse> TeacherGiveDevicesBack(Guid borrowDeviceId, Guid appUserTeacherId)
        {
            return await _repo.TeacherGiveDevicesBack(borrowDeviceId, appUserTeacherId);
        }

    }
}
