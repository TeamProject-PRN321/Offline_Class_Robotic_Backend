using Models.OfficeClassRobotic.BuisnessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.Classrooms
{
    public class ClassroomResponse
    {
        public Guid Id { get; set; }
        public string ClassRoomName { get; set; }
        public string? Description { get; set; }
        
        public TrungTamRoboticResponse TrungTamRoboticData { get; set; }
        public List<DeviceResponse> ListDevice { get; set; }
    }

    public class ClassroomCancelDeviceResponse
    {
        public Guid Id { get; set; }
        public string ClassRoomName { get; set; }
        public string? Description { get; set; }

        public TrungTamRoboticResponse TrungTamRoboticData { get; set; }
        public List<DeviceResponse> ListDevice { get; set; }
        public int QuantityDevice { get; set; }
        public double? Price { get; set; }
    }

    public class ClassroomDTOResponse
    {
        public Guid Id { get; set; }
        public string ClassRoomName { get; set; }
        public string? Description { get; set; }

        public TrungTamRobotic TrungTamRoboticData { get; set; }
        public List<Device> ListDevice { get; set; }
    }

    public class DeviceResponse
    {
        public Guid Id { get; set; }
        public string DeviceName { get; set; }
        public string? Description { get; set; }
        public double? PriceOfDevice { get; set; }
        public bool? StatusOfDevice { get; set; }
        
        public Guid ClassRoomId { get; set; }
    }

    public class TrungTamRoboticResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class CreateDeviceForClassroomCommand
    {
        public string DeviceName { get; set; }
        public string? Description { get; set; }
        public double? PriceOfDevice { get; set; }

        public int StatusOfDevice { get; set; }
        public string ClassRoomId { get; set; }
    }

    public class UpdateDeviceForClassroomCommand
    {
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string? Description { get; set; }
        public double? PriceOfDevice { get; set; }

        public int StatusOfDevice { get; set; }
        public string ClassRoomId { get; set; }
    }

    public class DeleteDeviceForClassroomCommand
    {
        public string DeviceId { get; set; }
    }
}
