using AutoMapper;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Classrooms;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.Classrooms
{
    public class ClassroomRepository : IClassroomRepository
    {
        private ClassroomDAO _classroomDAO;
        private readonly IMapper _mapper;
        public ClassroomRepository(IMapper mapper)
        {
            _classroomDAO = new ClassroomDAO();
            _mapper = mapper;
        }
        public async Task<List<ClassroomResponse>> GetAllClassroom()
        {
            var list = await _classroomDAO.GetAllClassroom();
            var response = new List<ClassroomResponse>();
            foreach (var item in list)
            {
                var responseItem = new ClassroomResponse
                {
                    Id = item.Id,
                    ClassRoomName = item.ClassRoomName,
                    Description = item.Description,
                    TrungTamRoboticData = _mapper.Map<TrungTamRoboticResponse>(item.TrungTamRoboticData),
                  //  ListDevice = _mapper.Map<List<DeviceResponse>>(item.ListDevice)
                };
                response.Add(responseItem);
            }
            return response;
        }

        public async Task<List<ClassroomCancelDeviceResponse>> GetAllClassroomCancelDeviceResponse()
        {
            var list = await _classroomDAO.GetAllClassroomWithDeviceCancel();
            var response = new List<ClassroomCancelDeviceResponse>();
            foreach (var item in list)
            {
                var responseItem = new ClassroomCancelDeviceResponse
                {
                    Id = item.Id,
                    ClassRoomName = item.ClassRoomName,
                    Description = item.Description,
                    TrungTamRoboticData = _mapper.Map<TrungTamRoboticResponse>(item.TrungTamRoboticData),
                   // ListDevice = _mapper.Map<List<DeviceResponse>>(item.ListDevice),
                    //QuantityDevice = item.ListDevice.Count(),
                    //Price = item.ListDevice/*.GroupBy(c => c.PriceOfDevice).Select(g => g.Key)*/.Sum(c => c.PriceOfDevice),
                };
                response.Add(responseItem);
            }
            return response;
        }

/*        public async Task<ClassRoboticResponse> CreateDeviceForClassroom(CreateDeviceForClassroomCommand request)
        {
            await ClassroomDAO.Instance.CreateDeviceForClassroom(request);
            return new ClassRoboticResponse { Message = ClassRoboticMessage.CreateSuccessfully };
        }*/
/*
        public async Task<ClassRoboticResponse> UpdateDeviceForClassroom(UpdateDeviceForClassroomCommand request)
        {
            await ClassroomDAO.Instance.UpdateDeviceForClassroom(request);
            return new ClassRoboticResponse { Message = ClassRoboticMessage.UpdateSuccessfully };
        }

        public async Task<ClassRoboticResponse> DeleteDeviceForClassroom(DeleteDeviceForClassroomCommand request)
        {
            await ClassroomDAO.Instance.DeleteDeviceForClassroom(request);
            return new ClassRoboticResponse { Message = ClassRoboticMessage.DeleteSuccessfully };
        }
*/
        public async Task<List<ClassroomResponse>> SearchClassroom(string className)
        {
            var list = await _classroomDAO.GetClassroomByClassCode(className);
            var response = new List<ClassroomResponse>();
            foreach (var item in list)
            {
                var responseItem = new ClassroomResponse
                {
                    Id = item.Id,
                    ClassRoomName = item.ClassRoomName,
                    Description = item.Description,
                    TrungTamRoboticData = _mapper.Map<TrungTamRoboticResponse>(item.TrungTamRoboticData),
               //     ListDevice = _mapper.Map<List<DeviceResponse>>(item.ListDevice)
                };
                response.Add(responseItem);
            }
            return response;
        }
    }
}
