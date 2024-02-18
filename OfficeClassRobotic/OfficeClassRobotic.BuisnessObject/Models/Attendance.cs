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
        public string AttendaceName { get; set; }
        public string? Description { get; set; }
        [ForeignKey("ClassSchedule")]
        public Guid ClassScheduleID { get; set; }

        public virtual ClassSchedule ClassSchedule { get; set; }
    }
}
