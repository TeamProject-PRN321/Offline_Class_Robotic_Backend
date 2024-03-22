using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    public class BorrowDevice : BaseAuditableEntity
    {
        /// <summary>
        /// Lý do mượn
        /// </summary>
        public string? BorrowPurpose { get; set; }
        /// <summary>
        /// Lớp nào mượn
        /// </summary>
        public string? ClassName { get; set; }
        /// <summary>
        /// Giờ mượn
        /// </summary>
        public TimeSpan BorrowTime { get; set; }
        /// <summary>
        /// Ngày mượn
        /// </summary>
        public Guid DateBorrow { get; set; }
        /// <summary>
        /// Mượn tại phòng nào
        /// </summary>
        [ForeignKey("Classroom")]
        public Guid ClassRoomId { get; set; }
        /// <summary>
        /// Teacher nào mượn
        /// </summary>
        [ForeignKey("Teacher")]
        public Guid TeacherId { get; set; }

        /// <summary>
        /// 0. Đang đợi được duyệt cho mượn.
        /// 1. Đã mượn
        /// 2. Đã trả
        /// </summary>
        public int BorrowStatus { get; set; }

        //Relationships
        public IList<BorrowDeviceHistory> BorrowDeviceHistories { get; set; }   
        public virtual Teacher Teacher { get; set; }
        public virtual Classroom Classroom { get; set; }
    }
}
