using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    /// <summary>
    /// Bảng này dùng để xác định các loại thiết bị khác nhau
    /// </summary>
    public class DeviceCategory : BaseAuditableEntity
    {
        public string? DeviceCategoryName { get; set; }
        public string? DeviceDescription { get; set; }
        public string? DevicePictureURL { get; set; }
        [ForeignKey("TrungTamRobotic")]
        public Guid TrungTamRoboticId { get; set; }


        public virtual TrungTamRobotic TrungTamRobotic { get; set; }
        public IList<Device> Devices { get; set; }
    }
}
