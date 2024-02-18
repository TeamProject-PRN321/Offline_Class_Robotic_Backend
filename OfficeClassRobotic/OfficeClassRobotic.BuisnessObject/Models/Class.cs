/*using OfficeClassRobotic.BuisnessObject.Models.Common;
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
        public string ClassName { get; set; }
        public DateTime DayStudy { get; set; }
        public int NumberOfSudent { get; set; }
        public double? MarkOfStudent { get; set; }
        [ForeignKey("Subject")]
        public Guid SubjectId { get; set; }
        [ForeignKey("Teacher")]
        public Guid TeacherId { get; set; }
        [ForeignKey("TrungTamRobotic")]
        public Guid TrungTamRoboticId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual TrungTamRobotic TrungTamRobotic { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Attendance Attendance { get; set; }
    }
}
*/