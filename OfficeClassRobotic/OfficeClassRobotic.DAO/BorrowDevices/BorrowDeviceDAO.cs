using Azure;
using Azure.Core;
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
                var classRoom = _dbContext.Classrooms.Where(x => string.Compare(x.ClassRoomName.ToLower(), slot.ClassRoomName.ToLower()) == 0).FirstOrDefault();
                if (classRoom == null)
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
                    foreach (var device in listDevices)
                    {
                        var borrowDetail = new BorrowDeviceHistory
                        {
                            BorrowDeviceId = borrow.Id,
                            DeviceId = device.Id,
                            DeviceCategoryId = deviceCategory.Id,
                        };
                        _dbContext.BorrowDeviceHistories.Add(borrowDetail);
                    }
                }
            }
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceDoNotProcessBeforeOfTeacher()
        {
            /// <summary>
            /// 0. Đang đợi được duyệt cho mượn.
            /// 1. Đã mượn
            /// 2. Đã trả
            /// </summary>
            var listBorrowDeviceRequest = await _dbContext.BorrowDevices.Where(x => x.BorrowStatus == 0).Include(x => x.BorrowDeviceHistories).OrderBy(x => x.Created).ToListAsync();
            var listResponse = new List<GetBorrowDeviceRequestOfTeacher>();
            if (listBorrowDeviceRequest.Any())
            {
                foreach (var bd in listBorrowDeviceRequest)
                {
                    var borrowStatusString = bd.BorrowStatus == 0 ? "Đang đợi được duyệt cho mượn" : bd.BorrowStatus == 1 ? "Đã mượn" : "Đã trả";
                    var teacher = _dbContext.Teacher.Where(x => x.Id == bd.TeacherId).Include(x => x.AppUser).FirstOrDefault();
                    var classroom = _dbContext.Classrooms.Where(x => x.Id == bd.ClassRoomId).FirstOrDefault();
                    var response = new GetBorrowDeviceRequestOfTeacher()
                    {
                        BorrowDeviceId = bd.Id,
                        BorrowPurpose = bd.BorrowPurpose,
                        BorrowStatus = bd.BorrowStatus,
                        BorrowStatusString = borrowStatusString,
                        ClassName = bd.ClassName,
                        ClassRoomId = bd.ClassRoomId,
                        DateTimeBorrow = bd.DateTimeBorrow,
                        TeacherId = bd.TeacherId,
                        TeacherName = teacher.AppUser.FullName,
                        ClassRoomName = classroom.ClassRoomName,
                    };
                    response.ListDeviceDetail = new List<GetDeviceCategoryNeedToBorrow>();
                    var listBorrowHistory = _dbContext.BorrowDeviceHistories.Where(x => x.BorrowDeviceId == bd.Id).Include(x => x.DeviceCategory).ThenInclude(x => x.Devices).ToList();
                    if (listBorrowHistory.Any())
                    {
                        foreach (var item in listBorrowHistory)
                        {
                            var detailCategory = new GetDeviceCategoryNeedToBorrow
                            {
                                DeviceCategoryId = item.DeviceCategoryId,
                                DeviceCategoryName = item.DeviceCategory.DeviceCategoryName,
                                QuantityTeacherWantToBorrow = listBorrowHistory.Where(x => x.DeviceCategoryId == item.DeviceCategoryId).Count()
                            };
                            if (!response.ListDeviceDetail.Where(x => x.DeviceCategoryId == detailCategory.DeviceCategoryId).Any())
                            {
                                response.ListDeviceDetail.Add(detailCategory);
                                detailCategory.ListDevice = new List<GetDeviceNeedToBorrow>();
                                var detailDevice = new GetDeviceNeedToBorrow
                                {
                                    DeviceId = item.Device.Id,
                                    SerialNumber = item.Device.DeviceSerialNumber,
                                };
                                detailCategory.ListDevice.Add(detailDevice);
                            }
                            else
                            {

                                var detailDevice = new GetDeviceNeedToBorrow
                                {
                                    DeviceId = item.Device.Id,
                                    SerialNumber = item.Device.DeviceSerialNumber,
                                };
                                response.ListDeviceDetail.Where(x => x.DeviceCategoryId == item.DeviceCategoryId).Select(x => x.ListDevice).First().Add(detailDevice);
                            }

                        }
                    }
                    listResponse.Add(response);
                }
            }

            return listResponse;
        }
        public async Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceOfTeacherInHistory()
        {
            /// <summary>
            /// 0. Đang đợi được duyệt cho mượn.
            /// 1. Đã mượn
            /// 2. Đã trả
            /// </summary>
            var listBorrowDeviceRequest = await _dbContext.BorrowDevices.Include(x => x.BorrowDeviceHistories).OrderBy(x => x.Created).ToListAsync();
            var listResponse = new List<GetBorrowDeviceRequestOfTeacher>();
            if (listBorrowDeviceRequest.Any())
            {
                foreach (var bd in listBorrowDeviceRequest)
                {
                    var borrowStatusString = bd.BorrowStatus == 0 ? "Đang đợi được duyệt cho mượn" : bd.BorrowStatus == 1 ? "Đã mượn" : bd.BorrowStatus == 2 ? "Đã trả" : "Đã bị từ chối";
                    var teacher = _dbContext.Teacher.Where(x => x.Id == bd.TeacherId).Include(x => x.AppUser).FirstOrDefault();
                    var classroom = _dbContext.Classrooms.Where(x => x.Id == bd.ClassRoomId).FirstOrDefault();
                    var response = new GetBorrowDeviceRequestOfTeacher()
                    {
                        BorrowDeviceId = bd.Id,
                        BorrowPurpose = bd.BorrowPurpose,
                        BorrowStatus = bd.BorrowStatus,
                        BorrowStatusString = borrowStatusString,
                        ClassName = bd.ClassName,
                        ClassRoomId = bd.ClassRoomId,
                        DateTimeBorrow = bd.DateTimeBorrow,
                        TeacherId = bd.TeacherId,
                        TeacherName = teacher.AppUser.FullName,
                        ClassRoomName = classroom.ClassRoomName,
                    };
                    response.ListDeviceDetail = new List<GetDeviceCategoryNeedToBorrow>();
                    var listBorrowHistory = _dbContext.BorrowDeviceHistories.Where(x => x.BorrowDeviceId == bd.Id).Include(x => x.DeviceCategory).ThenInclude(x => x.Devices).ToList();
                    if (listBorrowHistory.Any())
                    {
                        foreach (var item in listBorrowHistory)
                        {
                            var detailCategory = new GetDeviceCategoryNeedToBorrow
                            {
                                DeviceCategoryId = item.DeviceCategoryId,
                                DeviceCategoryName = item.DeviceCategory.DeviceCategoryName,
                                QuantityTeacherWantToBorrow = listBorrowHistory.Where(x => x.DeviceCategoryId == item.DeviceCategoryId).Count()
                            };
                            if (!response.ListDeviceDetail.Where(x => x.DeviceCategoryId == detailCategory.DeviceCategoryId).Any())
                            {
                                response.ListDeviceDetail.Add(detailCategory);
                                detailCategory.ListDevice = new List<GetDeviceNeedToBorrow>();
                                var detailDevice = new GetDeviceNeedToBorrow
                                {
                                    DeviceId = item.Device.Id,
                                    SerialNumber = item.Device.DeviceSerialNumber,
                                };
                                detailCategory.ListDevice.Add(detailDevice);
                            }
                            else
                            {

                                var detailDevice = new GetDeviceNeedToBorrow
                                {
                                    DeviceId = item.Device.Id,
                                    SerialNumber = item.Device.DeviceSerialNumber,
                                };
                                response.ListDeviceDetail.Where(x => x.DeviceCategoryId == item.DeviceCategoryId).Select(x => x.ListDevice).First().Add(detailDevice);
                            }

                        }
                    }
                    listResponse.Add(response);
                }
            }

            return listResponse;
        }
        public async Task<List<GetBorrowDeviceRequestOfTeacher>> ViewAllRequestBorrowDeviceOfTeacherInHistoryByTeacherId(Guid appUserTeacherId)
        {
            /// <summary>
            /// 0. Đang đợi được duyệt cho mượn.
            /// 1. Đã mượn
            /// 2. Đã trả
            /// </summary>
            var teacher = _dbContext.Teacher.Where(x => x.AppUserId == appUserTeacherId).Include(x => x.AppUser).FirstOrDefault();
            if(teacher == null)
            {
                throw new BadRequestException("Không tìm thấy teacher như trên!");
            }
            var listBorrowDeviceRequest = await _dbContext.BorrowDevices.Where(x => x.TeacherId == teacher.Id).Include(x => x.BorrowDeviceHistories).OrderBy(x => x.Created).ToListAsync();
            var listResponse = new List<GetBorrowDeviceRequestOfTeacher>();
            if (listBorrowDeviceRequest.Any())
            {
                foreach (var bd in listBorrowDeviceRequest)
                {
                    var borrowStatusString = bd.BorrowStatus == 0 ? "Đang đợi được duyệt cho mượn" : bd.BorrowStatus == 1 ? "Đã mượn" : bd.BorrowStatus == 2 ? "Đã trả" : "Đã bị từ chối";
                    //var teacher = _dbContext.Teacher.Where(x => x.Id == bd.TeacherId).Include(x => x.AppUser).FirstOrDefault();
                    var classroom = _dbContext.Classrooms.Where(x => x.Id == bd.ClassRoomId).FirstOrDefault();
                    var response = new GetBorrowDeviceRequestOfTeacher()
                    {
                        BorrowDeviceId = bd.Id,
                        BorrowPurpose = bd.BorrowPurpose,
                        BorrowStatus = bd.BorrowStatus,
                        BorrowStatusString = borrowStatusString,
                        ClassName = bd.ClassName,
                        ClassRoomId = bd.ClassRoomId,
                        DateTimeBorrow = bd.DateTimeBorrow,
                        TeacherId = bd.TeacherId,
                        TeacherName = teacher.AppUser.FullName,
                        ClassRoomName = classroom.ClassRoomName,
                    };
                    response.ListDeviceDetail = new List<GetDeviceCategoryNeedToBorrow>();
                    var listBorrowHistory = _dbContext.BorrowDeviceHistories.Where(x => x.BorrowDeviceId == bd.Id).Include(x => x.DeviceCategory).ThenInclude(x => x.Devices).ToList();
                    if (listBorrowHistory.Any())
                    {
                        foreach (var item in listBorrowHistory)
                        {
                            var detailCategory = new GetDeviceCategoryNeedToBorrow
                            {
                                DeviceCategoryId = item.DeviceCategoryId,
                                DeviceCategoryName = item.DeviceCategory.DeviceCategoryName,
                                QuantityTeacherWantToBorrow = listBorrowHistory.Where(x => x.DeviceCategoryId == item.DeviceCategoryId).Count()
                            };
                            if (!response.ListDeviceDetail.Where(x => x.DeviceCategoryId == detailCategory.DeviceCategoryId).Any())
                            {
                                response.ListDeviceDetail.Add(detailCategory);
                                detailCategory.ListDevice = new List<GetDeviceNeedToBorrow>();
                                var detailDevice = new GetDeviceNeedToBorrow
                                {
                                    DeviceId = item.Device.Id,
                                    SerialNumber = item.Device.DeviceSerialNumber,
                                };
                                detailCategory.ListDevice.Add(detailDevice);
                            }
                            else
                            {

                                var detailDevice = new GetDeviceNeedToBorrow
                                {
                                    DeviceId = item.Device.Id,
                                    SerialNumber = item.Device.DeviceSerialNumber,
                                };
                                response.ListDeviceDetail.Where(x => x.DeviceCategoryId == item.DeviceCategoryId).Select(x => x.ListDevice).First().Add(detailDevice);
                            }

                        }
                    }
                    listResponse.Add(response);
                }
            }

            return listResponse;
        }
        public async Task AdminAcceptRequestOfTeacher(Guid borrowDeviceId )
        {
            //1. Update status BorrowDevice
            var borrowDevice = _dbContext.BorrowDevices.Where(x => x.Id == borrowDeviceId).FirstOrDefault();
            if (borrowDevice != null)
            {
                borrowDevice.BorrowStatus = 1;
                _dbContext.BorrowDevices.Update(borrowDevice);

                //2. Update status Device

                var borrowHistory = await _dbContext.BorrowDeviceHistories.Where(x => x.BorrowDeviceId == borrowDevice.Id).ToListAsync();
                foreach (var device in borrowHistory)
                {
                    var devices = await _dbContext.Devices.Where(x => x.DeviceCategoryId == device.Id).Include(x => x.DeviceCategory).ToListAsync();
                    var quantityOfDeviceInStorageWantBorrow = borrowHistory.Select(x => x.DeviceCategoryId == device.DeviceCategoryId).Count();
                    var quantityOfDeviceInStorageInTotal = devices.Where(x => x.StatusOfDevice != 2).Count();
                    var deviceName = _dbContext.DeviceCategories.Where(x => x.Id == device.DeviceCategoryId).FirstOrDefault();
                    if (quantityOfDeviceInStorageInTotal < quantityOfDeviceInStorageWantBorrow)
                    {
                        throw new BadRequestException("Số lượng sản phẩm trong kho không đủ cho request! Vui lòng kiểm tra lại : " + deviceName.DeviceCategoryName);
                    }
                    var deviceExist = await _dbContext.Devices.Where(x => x.Id == device.DeviceId).FirstOrDefaultAsync();
                    if (deviceExist != null)
                    {
                        deviceExist.StatusOfDevice = 1;
                        _dbContext.Devices.Update(deviceExist);
                    }
                }
                await _dbContext.SaveChangesAsync();
            }

        }
        public async Task TeacherGiveDevicesBack(Guid borrowDeviceId, Guid appUserTeacherId)
        {
            //1. Update status BorrowDevice
            var teacher = _dbContext.Teacher.Where(x => x.AppUserId == appUserTeacherId).Include(x => x.AppUser).FirstOrDefault();
            if (teacher == null)
            {
                throw new BadRequestException("Không tìm thấy teacher như trên!");
            }
            var borrowDevice = _dbContext.BorrowDevices.Where(x => x.Id == borrowDeviceId && x.TeacherId == teacher.Id).FirstOrDefault();
            if (borrowDevice != null)
            {
                borrowDevice.BorrowStatus = 2;
                _dbContext.BorrowDevices.Update(borrowDevice);

                //2. Update status Device

                var borrowHistory = await _dbContext.BorrowDeviceHistories.Where(x => x.BorrowDeviceId == borrowDevice.Id).ToListAsync();
                foreach (var device in borrowHistory)
                {
                    var devices = await _dbContext.Devices.Where(x => x.DeviceCategoryId == device.Id).Include(x => x.DeviceCategory).ToListAsync();
                    var quantityOfDeviceInStorageWantBorrow = borrowHistory.Select(x => x.DeviceCategoryId == device.DeviceCategoryId).Count();
                    var quantityOfDeviceInStorageInTotal = devices.Where(x => x.StatusOfDevice != 2).Count();
                    var deviceName = _dbContext.DeviceCategories.Where(x => x.Id == device.DeviceCategoryId).FirstOrDefault();
                    var deviceExist = await _dbContext.Devices.Where(x => x.Id == device.DeviceId).FirstOrDefaultAsync();
                    if (deviceExist != null)
                    {
                        deviceExist.StatusOfDevice = 0;
                        _dbContext.Devices.Update(deviceExist);
                    }
                }
                await _dbContext.SaveChangesAsync();
            }

        }

        public async Task AdminRejectRequestOfTeacher(Guid borrowDeviceId)
        {
            //1. Update status BorrowDevice
            var borrowDevice = _dbContext.BorrowDevices.Where(x => x.Id == borrowDeviceId).FirstOrDefault();
            if (borrowDevice != null)
            {
                borrowDevice.BorrowStatus = 3;
                _dbContext.BorrowDevices.Update(borrowDevice);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
