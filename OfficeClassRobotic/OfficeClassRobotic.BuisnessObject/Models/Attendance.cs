using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public string AttendaceName { get; set; }
        public string Description { get; set; }
        public int ClassID { get; set; }
        public virtual Class Class { get; set; }
    }
}
