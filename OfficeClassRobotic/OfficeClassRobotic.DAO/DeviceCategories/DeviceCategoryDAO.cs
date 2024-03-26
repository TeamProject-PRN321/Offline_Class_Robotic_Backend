using Azure;
using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;

namespace OfficeClassRobotic.DAO.DeviceCategories
{
    public class DeviceCategoryDAO
    {
        private ApplicationDBContext _dbContext;
        public DeviceCategoryDAO _instance;

        public DeviceCategoryDAO()
        {
            _dbContext = new ApplicationDBContext();
        }

        public DeviceCategoryDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DeviceCategoryDAO();
                }
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public async Task CreateDeviceCategory(CreateDeviceCategoryDTO request)
        {
            var checkExisted = _dbContext.DeviceCategories.Where(x => x.DeviceCategoryName == request.DeviceCategoryName && !x.IsDeleted).FirstOrDefault();
            if (checkExisted != null)
            {
                throw new BadRequestException("Loại Thiết bị này đã có từ trước, vui lòng cập nhật lại!");
            }
            var deviceCategory = new DeviceCategory()
            {
                DeviceCategoryName = request.DeviceCategoryName,
                DeviceDescription = request.DeviceDescription,
                DevicePictureURL = request.DevicePictureURL,
                TrungTamRoboticId = Guid.Parse("5F4E0944-497B-4C33-9D5D-86F8824C8B95"),
            };
            _dbContext.DeviceCategories.Add(deviceCategory);
            if (request.ListDevice != null && request.ListDevice.Any())
            {
                var listSerialNumber = request.ListDevice.Select(x => x.DeviceSerialNumber).ToList();
                var checkDeviceExisted = _dbContext.Devices.Where(x => listSerialNumber.Contains(x.DeviceSerialNumber)).Select(x => x.DeviceSerialNumber).FirstOrDefault();
                if (checkDeviceExisted != null)
                {
                    throw new BadRequestException($"Thiết bị này đã có từ trước với số seri: {checkDeviceExisted}, vui lòng cập nhật lại!");
                }
                foreach (var serialNumber in listSerialNumber)
                {
                    var device = new Device
                    {
                        DeviceCategoryId = deviceCategory.Id,
                        StatusOfDevice = 0,
                        DeviceSerialNumber = serialNumber,
                    };
                    _dbContext.Add(device);
                }
            }
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<GetDeviceCategoryDTO>> GetAllDeviceCategoryAndListDevice()
        {
            var listDeviceCategory = _dbContext.DeviceCategories.Where(x => !x.IsDeleted).ToList();
            var listResponse = new List<GetDeviceCategoryDTO>();
            if (listDeviceCategory != null && listDeviceCategory.Any())
            {
                foreach (var deviceCategory in listDeviceCategory)
                {
                    var response = new GetDeviceCategoryDTO();

                    response.DevicePictureURL = deviceCategory.DevicePictureURL;
                    response.DeviceDescription = deviceCategory.DeviceDescription;
                    response.DeviceCategoryName = deviceCategory.DeviceCategoryName;
                    response.DeviceCategoryId = deviceCategory.Id;

                    var devices = await _dbContext.Devices.Where(x => x.DeviceCategoryId == deviceCategory.Id).ToListAsync();
                    if (devices.Any())
                    {
                        var listDevice = new List<GetDeviceDTO>();
                        foreach (var device in devices)
                        {
                            var lastModified = device.LastModified != null ? device.LastModified.Value.ToString("yyyy-MM-dd") : "Chưa từng sửa";
                            var statusString = device.StatusOfDevice == 0 ? "Bình Thường, Sử Dụng Được" : device.StatusOfDevice == 1 ? "Đã Được Cho Mượn" : device.StatusOfDevice == 2 ? "Đang chờ sửa chữa" : "Không sử dụng được";
                            var deviceDTO = new GetDeviceDTO
                            {
                                DateOfAcquisition = $"Ngày nhập kho: {device.Created.ToString("yyyy-MM-dd")}",
                                DeviceId = device.Id,
                                DeviceSerialNumber = device.DeviceSerialNumber,
                                DeviceStatus = device.StatusOfDevice,
                                DeviceStatusString = statusString,
                                DateOfLastRepair = $"Ngày sửa chửa gần nhất: {lastModified}",
                            };
                            listDevice.Add(deviceDTO);
                        }
                        response.ListDevicesOfDeviceCategory = listDevice;
                        response.QuantityOfDeviceInStorageCanBorrow = listDevice.Where(x => x.DeviceStatus == 0).Count();
                        response.QuantityOfDeviceInStorageInTotal = listDevice.Where(x => x.DeviceStatus != 2).Count();
                    }
                    listResponse.Add(response);
                }

            }
            return listResponse;
        }
        public async Task<GetDeviceCategoryDTO> GeDeviceCategoryAndListDeviceByDeviceCategoryId(Guid deviceCategoryId)
        {
            var deviceCategory = await _dbContext.DeviceCategories.Where(x => x.Id == deviceCategoryId && !x.IsDeleted).FirstOrDefaultAsync();
            var response = new GetDeviceCategoryDTO();
            if (deviceCategory != null)
            {
                response.DevicePictureURL = deviceCategory.DevicePictureURL;
                response.DeviceDescription = deviceCategory.DeviceDescription;
                response.DeviceCategoryName = deviceCategory.DeviceCategoryName;
                response.DeviceCategoryId = deviceCategory.Id;

                var devices = await _dbContext.Devices.Where(x => x.DeviceCategoryId == deviceCategory.Id).ToListAsync();
                if (devices.Any())
                {
                    var listDevice = new List<GetDeviceDTO>();
                    foreach (var device in devices)
                    {
                        var lastModified = device.LastModified != null ? device.LastModified.Value.ToString("yyyy-MM-dd") : "Chưa từng sửa";
                        var statusString = device.StatusOfDevice == 0 ? "Bình Thường, Sử Dụng Được" : device.StatusOfDevice == 1 ? "Đã Được Cho Mượn" : device.StatusOfDevice == 2 ? "Đang chờ sửa chữa" : "Không sử dụng được";

                        var deviceDTO = new GetDeviceDTO
                        {
                            DateOfAcquisition = $"Ngày nhập kho: {device.Created.ToString("yyyy-MM-dd")}",
                            DeviceId = device.Id,
                            DeviceSerialNumber = device.DeviceSerialNumber,
                            DeviceStatus = device.StatusOfDevice,
                            DeviceStatusString = statusString,
                            DateOfLastRepair = $"Ngày sửa chửa gần nhất: {lastModified}",
                        };
                        listDevice.Add(deviceDTO);
                    }
                    response.ListDevicesOfDeviceCategory = listDevice;
                    response.QuantityOfDeviceInStorageCanBorrow = listDevice.Where(x => x.DeviceStatus == 0).Count();
                    response.QuantityOfDeviceInStorageInTotal = listDevice.Where(x => x.DeviceStatus != 2).Count();
                }
            }
            return response;
        }

        public async Task UpdateAndAddMoreDivices(UpdateAndAddMoreDivices request)
        {
            var checkExisted = _dbContext.DeviceCategories.Where(x => x.Id == request.DeviceCategoryId && !x.IsDeleted).FirstOrDefault();
            if (checkExisted == null)
            {
                throw new BadRequestException("Loại Thiết bị này không được tìm thấy! vui lòng tìm kiếm lại");
            }

            checkExisted.DeviceCategoryName = request.DeviceCategoryName;
            checkExisted.DeviceDescription = request.DeviceDescription;
            checkExisted.DevicePictureURL = request.DevicePictureURL;
            _dbContext.DeviceCategories.Update(checkExisted);
            if (request.ListDevice != null && request.ListDevice.Any())
            {
                var listSerialNumber = request.ListDevice.Select(x => x.DeviceSerialNumber).ToList();
                var checkDeviceExisted = _dbContext.Devices.Where(x => listSerialNumber.Contains(x.DeviceSerialNumber)).Select(x => x.DeviceSerialNumber).FirstOrDefault();
                if (checkDeviceExisted != null)
                {
                    throw new BadRequestException($"Thiết bị này đã có từ trước với số seri: {checkDeviceExisted}, vui lòng cập nhật lại!");
                }
                foreach (var serialNumber in listSerialNumber)
                {
                    var device = new Device
                    {
                        DeviceCategoryId = checkExisted.Id,
                        StatusOfDevice = 0,
                        DeviceSerialNumber = serialNumber,
                    };
                    _dbContext.Add(device);
                }
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
