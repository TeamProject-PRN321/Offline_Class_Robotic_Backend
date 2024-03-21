using OfficeClassRobotic.BuisnessObject.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Class : BaseAuditableEntity
    {
        public string? ClassName { get; set; }
        public List<string>? DayStudy {  get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        [ForeignKey("Student")]
        public Guid StudentId { get; set; }
        [ForeignKey("Subject")]
        public Guid SubjectId { get; set; }
        /// <summary>
        /// Đánh dấu xem lớp học của học sinh này đã kết thúc chưa
        /// True là kết thúc rồi
        /// False là chưa kết thúc
        /// </summary>
        public bool IsClassFinish { get; set; } = false;
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual IList<ClassSchedule> ClassSchedule { get; set; }
    }
}
