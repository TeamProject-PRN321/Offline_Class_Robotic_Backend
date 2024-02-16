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
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        //public int AttendanceID { get; set; }
        public string AttendaceName { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Class")]
        public Guid ClassId { get; set; }

        public virtual ClassSubject ClassSubject { get; set; }
    }
}
