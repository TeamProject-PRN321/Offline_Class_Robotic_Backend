//using Microsoft.AspNetCore.Mvc;
//using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
//using OfficeClassRobotic.DAO.GiaoTrinhs;
//using OfficeClassRobotic.DAO.Staffs;
//using OfficeClassRobotic.Repository.StaffsRepository;

//namespace OfficeClassRobotic.API.Controllers.Staffs
//{
//    [Route("api/v1/staff")]
//    [ApiController]
//    public class StaffController : ControllerBase
//    {
//        private readonly IStaffRepository _staffRepository;
//        public StaffController (IStaffRepository staffRepository)
//        {
//            _staffRepository = staffRepository;
//        }

//        [HttpPost]
//        [Route("add")]
//        public Task<ClassRoboticResponse> Create(CreateStaffsCommand request)
//        {
//            var result = _staffRepository.CreateStaff(request);
//            return result;
//        }

//        [HttpPut]
//        [Route("edit")]
//        public Task<ClassRoboticResponse> Update(UpdateStaffsCommand request)
//        {
//            var result = _staffRepository.UpdateStaff(request);
//            return result;
//        }

//        [HttpDelete]
//        [Route("remove")]
//        public Task<ClassRoboticResponse> Delete(DeleteStaffsCommand request)
//        {
//            var result = _staffRepository.DeleteStaff(request);
//            return result;
//        }

//        [HttpGet]
//        [Route("all")]
//        public Task<List<StaffsResponse>> GetAll()
//        {
//            var result = _staffRepository.GetAllStaff();
//            return result;
//        }

//        [HttpGet]
//        [Route("{staffId}")]
//        public Task<StaffsResponse> GetById(Guid staffId)
//        {
//            var result = _staffRepository.GetStaffById(staffId);
//            return result;
//        }
//    }
//}
