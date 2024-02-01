using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataAccess
{
    public class Classroom
    {
        public int ClassRoomID { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}
