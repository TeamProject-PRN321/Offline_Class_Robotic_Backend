//using Microsoft.EntityFrameworkCore;
//using Models.OfficeClassRobotic.BuisnessObject;
//using OfficeClassRobotic.DAO.GiaoTrinhs;
//using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
//using OfficeClassRobotic.Service.Exceptions;

//namespace OfficeClassRobotic.DAO.Staffs
//{
//    public class StaffsDAO
//    {
//        private static StaffsDAO instance;
//        private static ApplicationDBContext _dbContext;

//        public StaffsDAO()
//        {
//            _dbContext = new ApplicationDBContext();
//        }

//        public static StaffsDAO Instance
//        {
//            get
//            {
//                if (instance == null)
//                {
//                    instance = new StaffsDAO();
//                }
//                return instance;
//            }
//            private set => instance = value;
//        }

//        public async Task<List<Staff>> GetAllStaff()
//        {
//            try
//            {
//                var staffs = await _dbContext.Staffs.ToListAsync();
//                return staffs;
//            }
//            catch (Exception ex)
//            {
//                throw new BadRequestException(ex.Message);
//            }
//        }

//        public async Task CreateStaff(CreateStaffsCommand request)
//        {
//            try
//            {
//                var isTrungTamExist = await _dbContext.TrungTamRobotics.Where(t => t.Id == request.TrungTamRoboticId && !t.IsDeleted).SingleOrDefaultAsync();
//                if(isTrungTamExist == null)
//                {
//                    throw new NotFoundException("Trung tam doesn't existed");
//                }
//                var isStaffExist = await _dbContext.Staffs
//                .Where(s => s.Id == request.Id && s.TrungTamRoboticId == request.TrungTamRoboticId)
//                .SingleOrDefaultAsync();
//                if (isStaffExist != null)
//                {
//                    throw new BadRequestException("Staff is existed");
//                }
//                var staff = new Staff
//                {
//                    Name = request.Name,
//                    Address = request.Address,
//                    PhoneNumber = request.PhoneNumber,
//                    Birthday = request.Birthday,
//                    TrungTamRoboticId = request.TrungTamRoboticId
//                };
//                _dbContext.Add(staff);
//                await _dbContext.SaveChangesAsync();
//            }
//            catch (Exception ex)
//            {
//                throw new BadRequestException(ex.Message);
//            }
//        }

//        public async Task UpdateStaff(UpdateStaffsCommand request)
//        {
//            try
//            {
//                var staffIsExist = await _dbContext.Staffs
//                    .Where(s => s.Id == request.Id && !s.IsDeleted).SingleOrDefaultAsync();
//                if (staffIsExist == null)
//                {
//                    throw new NotFoundException("Does not existed staff");
//                }
//                staffIsExist.Name = request.Name;
//                staffIsExist.Address = request.Address;
//                staffIsExist.PhoneNumber = request.PhoneNumber;
//                staffIsExist.Birthday = request.Birthday;
//                staffIsExist.TrungTamRoboticId = request.TrungTamRoboticId;

//                _dbContext.Update(staffIsExist);
//                await _dbContext.SaveChangesAsync();
//            }
//            catch (Exception ex)
//            {
//                throw new BadRequestException(ex.Message);
//            }
//        }

//        public async Task DeleteStaff(DeleteStaffsCommand request)
//        {
//            try
//            {
//                var staffIsExist = await _dbContext.Staffs
//                    .Where(s => s.Id == request.Id && !s.IsDeleted).SingleOrDefaultAsync();
//                if (staffIsExist == null)
//                {
//                    throw new NotFoundException("Does not existed staff");
//                }
//                staffIsExist.IsDeleted = true;
//                _dbContext.Update(staffIsExist);
//                await _dbContext.SaveChangesAsync();
//            }
//            catch (Exception ex)
//            {
//                throw new BadRequestException(ex.Message);
//            }
//        }

//        public async Task<Staff> GetStaffById(Guid staffId)
//        {
//            try
//            {
//                var staffIsExist = await _dbContext.Staffs.FindAsync(staffId);
                   
//                if (staffIsExist == null)
//                {
//                    throw new NotFoundException("Does not existed staff");
//                }
//                return staffIsExist;
//            }
//            catch (Exception ex)
//            {
//                throw new BadRequestException(ex.Message);
//            }
//        }

//    }
//}
