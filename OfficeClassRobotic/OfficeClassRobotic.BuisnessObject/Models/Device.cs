using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Device
    {
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string? Description { get; set; }
        public double? PriceOfDevice { get; set; }
        public bool? StatusOfDevice { get; set; }
        public int ClassRoomID { get; set; }
        public virtual Classroom Classroom { get; set; }

    }
}
