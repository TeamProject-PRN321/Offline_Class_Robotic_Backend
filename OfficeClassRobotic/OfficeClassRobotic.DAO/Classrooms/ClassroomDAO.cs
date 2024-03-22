using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Classess;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.Classrooms
{
    public class ClassroomDAO
    {
        private static ClassroomDAO instance = null;
        private static ApplicationDBContext _dbContext = null;

        public ClassroomDAO()
        {
            _dbContext = new ApplicationDBContext();
        }

        public static ClassroomDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClassroomDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        // Thêm xóa sửa các thiết bị cho các phòng học
/*        public async Task CreateDeviceForClassroom(CreateDeviceForClassroomCommand request)
        {
            var newDevice = new Device
            {
                DeviceName = request.DeviceName,
                Description = request.Description,
                PriceOfDevice = request.PriceOfDevice,
                StatusOfDevice = 1,
                ClassRoomId = Guid.Parse(request.ClassRoomId),
            };
            _dbContext.Devices.Add(newDevice);
            await _dbContext.SaveChangesAsync();
        }*/

      /*  public async Task UpdateDeviceForClassroom(UpdateDeviceForClassroomCommand request)
        {
            var deviceExist = await _dbContext.Devices.Where(d => d.Id == Guid.Parse(request.DeviceId) && !d.IsDeleted).SingleOrDefaultAsync();
            if(deviceExist == null)
            {
                throw new NotFoundException("DeviedId not existed");
            }
            deviceExist.DeviceName = request.DeviceName;
            deviceExist.Description = request.Description;
            deviceExist.PriceOfDevice = request.PriceOfDevice;
            deviceExist.StatusOfDevice = request.StatusOfDevice;
            deviceExist.ClassRoomId = Guid.Parse(request.ClassRoomId);
            _dbContext.Devices.Update(deviceExist);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteDeviceForClassroom(DeleteDeviceForClassroomCommand request)
        {
            var deviceExist = await _dbContext.Devices.Where(d => d.Id == Guid.Parse(request.DeviceId) && !d.IsDeleted).SingleOrDefaultAsync();
            if (deviceExist == null)
            {
                throw new NotFoundException("DeviedId not existed");
            }
            deviceExist.IsDeleted = true;
            _dbContext.Devices.Update(deviceExist);
            await _dbContext.SaveChangesAsync();
        }*/

        // danh sách các thiết bị đã hư, hủy bỏ, gồm cả số tiền, số lượng, phân loại
        public async Task<List<ClassroomDTOResponse>> GetAllClassroomWithDeviceCancel()
        {
            var classroom = await _dbContext.Classrooms.Where(c => !c.IsDeleted).ToListAsync();
            var classRoomList = new List<ClassroomDTOResponse>();
            foreach (var c in classroom)
            {
               // var devices = await _dbContext.Devices.Where(d => d.ClassRoomId == c.Id && d.StatusOfDevice == 3).ToListAsync();
                var trungTam = await _dbContext.TrungTamRobotics.Where(t => t.Id == c.TrungTamRoboticId).SingleOrDefaultAsync();
                var listClassroom = new ClassroomDTOResponse
                {
                    Id = c.Id,
                    ClassRoomName = c.ClassRoomName,
                    Description = c.Description,
                    TrungTamRoboticData = trungTam,
                   // ListDevice = devices
                };
                classRoomList.Add(listClassroom);
            }
            return classRoomList;
        }

        // Danh sách 1 phòng học có bao nhiêu thiết bị, hiện 1 list phòng với các thiết bị đang sử dụng được hoặc chờ sửa chữa
        public async Task<List<ClassroomDTOResponse>> GetAllClassroom()
        {
            var classroom = await _dbContext.Classrooms.Where(c => !c.IsDeleted).ToListAsync();
            var classRoomList = new List<ClassroomDTOResponse>();
            foreach (var c in classroom)
            {
               // var devices = await _dbContext.Devices.Where(d => d.ClassRoomId == c.Id && (d.StatusOfDevice == 1 || d.StatusOfDevice == 2)).ToListAsync();
                var trungTam = await _dbContext.TrungTamRobotics.Where(t => t.Id == c.TrungTamRoboticId).SingleOrDefaultAsync();
                var listClassroom = new ClassroomDTOResponse
                {
                    Id = c.Id,
                    ClassRoomName = c.ClassRoomName,
                    Description = c.Description,
                    TrungTamRoboticData = trungTam,
                  //  ListDevice = devices
                };
                classRoomList.Add(listClassroom);
            }
            return classRoomList;
        }

        // search theo danh sách phòng, hiện 1 list phòng với các thiết bị đang sử dụng được hoặc chờ sửa chữa
        public async Task<List<ClassroomDTOResponse>> GetClassroomByClassCode(string keyword)
        {
            var classroom = await _dbContext.Classrooms.Where(c => !c.IsDeleted && c.ClassRoomName.Contains(keyword)).ToListAsync();
            var classRoomList = new List<ClassroomDTOResponse>();
            foreach (var c in classroom)
            {
               // var devices = await _dbContext.Devices.Where(d => d.ClassRoomId == c.Id && (d.StatusOfDevice == 1 || d.StatusOfDevice == 2)).ToListAsync();
                var trungTam = await _dbContext.TrungTamRobotics.Where(t => t.Id == c.TrungTamRoboticId).SingleOrDefaultAsync();
                var listClassroom = new ClassroomDTOResponse
                {
                    Id = c.Id,
                    ClassRoomName = c.ClassRoomName,
                    Description = c.Description,
                    TrungTamRoboticData = trungTam,
                   // ListDevice = devices
                };
                classRoomList.Add(listClassroom);
            }
            return classRoomList;
        }
    }
}
