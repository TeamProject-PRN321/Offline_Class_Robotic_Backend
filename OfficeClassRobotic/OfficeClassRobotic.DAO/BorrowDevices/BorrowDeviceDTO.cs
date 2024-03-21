using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeClassRobotic.DAO.BorrowDevices
{
    /// <summary>
    /// Đầu tiên là Ai mượn ? -> Teacher mượn
    /// Mượn cho lớp nào ? -> ClassName 
    /// Class đó tại phòng nào ? -> Classroom
    /// Mục Đích mượn ? -> BorrowPurpose
    /// Giờ mượn -> BorrowTime
    /// Ngày mượn -> DateBorrow
    /// 
    /// 
    /// Model mượn nên như sau
    /// Giảng viên vào chọn DeviceCategory 
    /// Sẽ chọn được nhiều DeviceCategory List<>
    /// 
    /// Tiếp theo sẽ là chọn số lượng DeviceCategory
    /// 
    /// Mượn cho slot nào ? Nên hiện ra Slot trong tương lai mà Teacher đang
    /// dạy, mà slot của teacher chính là ClassSchedule .
    /// </summary>
    public class BorrowDeviceDTO
    {
        /// <summary>
        /// Lý do mượn
        /// </summary>
        public string? BorrowPurpose { get; set; }
        public Guid AppUserTeacherId { get; set; }
        /// <summary>
        /// Mượn nhiều thiết bị
        /// </summary>
        public List<DeviceCategoryWithQuantityNeedToBorrow>? ListDeviceCategoryAndQuantity { get; set; }
        /// <summary>
        /// Mượn cho nhiều slot khác nhau
        /// </summary>
        public List<BorrowBySlot>? ListSlotWantToBorrow { get; set; }
    }
    /// <summary>
    /// Mượn nhiều món với số lượng khác nhau
    /// </summary>
    public class DeviceCategoryWithQuantityNeedToBorrow
    {
        public Guid DeviceCategoryId { get; set; }
        public int QuantityTeacherWantToBorrow { get; set; }
    }
    public class GetDeviceCategoryNeedToBorrow : DeviceCategoryWithQuantityNeedToBorrow
    {
        public List<GetDeviceNeedToBorrow>? ListDevice { get; set; }
        public string? DeviceCategoryName { get; set; }

    }
    public class GetDeviceNeedToBorrow 
    {
        public string? SerialNumber { get; set; }
        public Guid DeviceId { get; set; }
    }
    public class BorrowBySlot
    {
        public string ClassName { get; set; }
        public string ClassRoomName { get; set; }
        public DateTime DayStudy { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
    public class GetBorrowDeviceRequestOfTeacher
    {
        public Guid BorrowDeviceId { get; set; }
        public string? BorrowPurpose { get; set; }
        public string? ClassName { get; set; }
        public DateTime DateTimeBorrow { get; set; }
        public Guid ClassRoomId { get; set; }
        public string? ClassRoomName { get; set; }
        public Guid TeacherId { get; set; }
        public string? TeacherName { get; set; }
        public int BorrowStatus { get; set; }
        public string? BorrowStatusString { get; set; }
        public List<GetDeviceCategoryNeedToBorrow>? ListDeviceDetail { get; set; }
    }
    public class AdminAccessRequestOfTeacher
    {
        public Guid BorrowDeviceId { get; set; }
    }
}
