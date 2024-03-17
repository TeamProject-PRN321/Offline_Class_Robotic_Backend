using OfficeClassRobotic.DAO.Classess;
using OfficeClassRobotic.DAO.Classrooms;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.Classrooms
{
    public interface IClassroomRepository
    {
        public Task<List<ClassroomResponse>> GetAllClassroom();
        public Task<List<ClassroomCancelDeviceResponse>> GetAllClassroomCancelDeviceResponse();
        public Task<ClassRoboticResponse> CreateDeviceForClassroom(CreateDeviceForClassroomCommand request);
        public Task<ClassRoboticResponse> UpdateDeviceForClassroom(UpdateDeviceForClassroomCommand request);
        public Task<ClassRoboticResponse> DeleteDeviceForClassroom(DeleteDeviceForClassroomCommand request);
        public Task<List<ClassroomResponse>> SearchClassroom(string className);
    }
}
