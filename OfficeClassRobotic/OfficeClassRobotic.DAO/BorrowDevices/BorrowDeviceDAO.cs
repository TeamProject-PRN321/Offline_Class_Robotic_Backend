using Microsoft.EntityFrameworkCore;
using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.DAO.Attendances;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;

namespace OfficeClassRobotic.DAO.BorrowDevices
{
    public class BorrowDeviceDAO
    {
        private ApplicationDBContext _dbContext;
        private BorrowDeviceDAO _instance;
        public BorrowDeviceDAO()
        {
            _dbContext = new ApplicationDBContext();
        }
        public BorrowDeviceDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BorrowDeviceDAO();
                }
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public async Task TeacherBorrowDevice(BorrowDeviceDTO request)
        {
            if (request.ListDeviceCategoryAndQuantity == null || request.ListSlotWantToBorrow == null)
            {
                throw new BadRequestException("Request có chứa list null! Vui lòng kiểm tra lại");
            }
            foreach (var slot in request.ListSlotWantToBorrow)
            {
                var classRoom = _dbContext.Classrooms.Where(x => string.Compare(x.ClassRoomName.ToLower(),slot.ClassRoomName.ToLower()) == 0).FirstOrDefault();
                if(classRoom == null)
                {
                    throw new BadRequestException("Class room không tồn tại!");
                }
                var teacher = _dbContext.Teacher.Where(x => x.AppUserId == request.AppUserTeacherId).FirstOrDefault();
                if (teacher == null)
                {
                    throw new BadRequestException("Teacher không tồn tại!");
                }
                var borrow = new BorrowDevice
                {
                    DateTimeBorrow = DateTime.Now,
                    BorrowPurpose = request.BorrowPurpose,
                    BorrowStatus = 0,
                    ClassName = slot.ClassName,
                    ClassRoomId = classRoom.Id,
                    TeacherId = teacher.Id,
                };
                _dbContext.BorrowDevices.Add(borrow);
                foreach (var item in request.ListDeviceCategoryAndQuantity)
                {
                    //1. Kiểm tra device tồn tại
                    var deviceCategory = _dbContext.DeviceCategories.Where(x => x.Id == item.DeviceCategoryId).FirstOrDefault();
                    if (deviceCategory == null)
                    {
                        throw new BadRequestException("Device Category với ID: " + item.DeviceCategoryId + " null!");
                    }
                    //2. Kiểm tra hàng tồn kho
                    var listDevices = await _dbContext.Devices.Where(x => x.DeviceCategoryId == deviceCategory.Id && x.StatusOfDevice == 0).ToListAsync();
                    if (listDevices.Count < item.QuantityTeacherWantToBorrow)
                    {
                        throw new BadRequestException("Device Category với tên: " + deviceCategory.DeviceCategoryName + " không đủ số lượng cho mượn!");
                    }
                    //3. Ok hết rồi thì bắt đầu tạo đơn hàng Borrow Detail
                    //3.1 Lấy random thiết bị 
                    var random = new Random();
                    listDevices = listDevices.OrderBy(x => random.Next()).Take(item.QuantityTeacherWantToBorrow).ToList();
                    foreach(var device in listDevices)
                    {
                        var borrowDetail = new BorrowDeviceHistory
                        {
                            BorrowDeviceId = borrow.Id,
                            DeviceId = device.Id,
                        };
                        _dbContext.BorrowDeviceHistories.Add(borrowDetail);
                    }
                }
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
