//using AutoMapper;
//using Models.OfficeClassRobotic.BuisnessObject;
//using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
//using OfficeClassRobotic.DAO.GiaoTrinhs;
//using OfficeClassRobotic.DAO.Staffs;
//using OfficeClassRobotic.DAO.Subjects;

//namespace OfficeClassRobotic.Repository.StaffsRepository
//{
//    public class StaffsRepository : IStaffRepository
//    {
//        private StaffsDAO _staffsDAO;
//        private readonly IMapper _mapper;
//        public StaffsRepository (IMapper mapper)
//        {
//            _mapper = mapper;
//            _staffsDAO = new StaffsDAO();
//        }

//        public async Task<ClassRoboticResponse> CreateStaff(CreateStaffsCommand staff)
//        {
//            await _staffsDAO.CreateStaff(staff);
//            return new ClassRoboticResponse
//            {
//                Message = "Create Successfully"
//            };
//        }

//        public async Task<ClassRoboticResponse> UpdateStaff(UpdateStaffsCommand staff)
//        {
//            await _staffsDAO.UpdateStaff(staff);
//            return new ClassRoboticResponse
//            {
//                Message = "Update Successfully"
//            };
//        }

//        public async Task<ClassRoboticResponse> DeleteStaff(DeleteStaffsCommand staff)
//        {
//            await _staffsDAO.DeleteStaff(staff);
//            return new ClassRoboticResponse
//            {
//                Message = "Delete Successfully"
//            };
//        }

//        public async Task<List<StaffsResponse>> GetAllStaff()
//        {
//            var response = await _staffsDAO.GetAllStaff();
//            var data = _mapper.Map<List<StaffsResponse>>(response);
//            return data;
//        }

//        public async Task<StaffsResponse> GetStaffById(Guid StaffId)
//        {
//            var response = await _staffsDAO.GetStaffById(StaffId);
//            var data = _mapper.Map<StaffsResponse>(response);
//            return data;
//        }
//    }
//}
