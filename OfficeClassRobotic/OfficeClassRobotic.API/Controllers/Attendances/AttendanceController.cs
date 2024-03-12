using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Attendances;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.Repository.Attendances;

namespace OfficeClassRobotic.API.Controllers.Attendances
{
    [Route("api/v1/attendances")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private IAttendanceRepository _repo;

        public AttendanceController(IAttendanceRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("{className}/{dateStudy}")]
        public async Task<List<AttendenceStudentOfClass>?> GetAttendanceOfClassByClassName(string className, DateTime dateStudy)
        {
            return await _repo.GetAttendanceOfClassByClassName(className, dateStudy);
        }
        [HttpPost]
        public async Task<ClassRoboticResponse> UpdateAttendanceOfClassByClassName(List<AttendenceStudentOfClass> request)
        {
            return await _repo.UpdateAttendanceOfClassByClassName(request);
        }

    }
}
