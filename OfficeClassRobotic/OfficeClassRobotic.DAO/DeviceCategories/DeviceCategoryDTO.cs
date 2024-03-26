using Models.OfficeClassRobotic.BuisnessObject;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OfficeClassRobotic.DAO.DeviceCategories
{
    public class DeviceCategoryDTO
    {
        public string? DeviceCategoryName { get; set; }
        public string? DeviceDescription { get; set; }
        public string? DevicePictureURL { get; set; }
    }
    public class CreateDeviceDTO
    {
        public string? DeviceSerialNumber { get; set; }
    }
    public class CreateDeviceCategoryDTO : DeviceCategoryDTO
    {
        public List<CreateDeviceDTO>? ListDevice { get; set; }
    }
    public class UpdateAndAddMoreDivices : CreateDeviceCategoryDTO
    {
        [JsonPropertyOrder(0)]
        public Guid DeviceCategoryId { get; set; }
    }

    public class GetDeviceDTO : CreateDeviceDTO
    {
        public Guid DeviceId { get; set; }
        /// <summary>
        /// Ngày nhập thiết bị
        /// </summary>
        public string? DateOfAcquisition { get; set; }
        /// <summary>
        /// Ngày gần nhất thiết bị được sửa
        /// </summary>
        public string? DateOfLastRepair { get; set; }
        public int DeviceStatus { get; set; }
        public string? DeviceStatusString { get; set; }
    }
    public class GetDeviceCategoryDTO : DeviceCategoryDTO
    {
        [JsonPropertyOrder(1)]
        public Guid DeviceCategoryId { get; set; }
        [JsonPropertyOrder(2)]
        public int QuantityOfDeviceInStorageCanBorrow { get; set; }
        [JsonPropertyOrder(3)]
        public int QuantityOfDeviceInStorageInTotal  { get; set; }

        [JsonPropertyOrder(5)]
        public List<GetDeviceDTO>? ListDevicesOfDeviceCategory { get; set; } 
    }

}
