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
        /// Ngày gửi đơn mượn
        /// </summary>
        public DateTime DateTimeBorrow { get; set; }
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
        /// 3. Đã bị từ chối
        /// </summary>
        public int BorrowStatus { get; set; }

        //Relationships
        public IList<BorrowDeviceHistory> BorrowDeviceHistories { get; set; }   
        public virtual Teacher Teacher { get; set; }
        public virtual Classroom Classroom { get; set; }
    }
}
