using OfficeClassRobotic.BuisnessObject.Models;
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
    public class Attendance : BaseAuditableEntity
    {
        /// <summary>
        /// 0. Not yet
        /// 1. Present
        /// 2. Absent
        /// </summary>
        public int AttendStatus { get; set; } = 0;
        public string? Description { get; set; }
        [ForeignKey("ClassSchedule")]
        public Guid ClassScheduleID { get; set; }

        public virtual ClassSchedule ClassSchedule { get; set; }
    }
}
