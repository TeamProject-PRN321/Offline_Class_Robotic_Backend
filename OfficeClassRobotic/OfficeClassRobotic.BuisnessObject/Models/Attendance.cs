using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceID { get; set; }
        public string AttendaceName { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Class")]
        public int ClassID { get; set; }

        public virtual Class Class { get; set; }
    }
}
