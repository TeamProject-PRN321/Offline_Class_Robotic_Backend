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
    public class TrungTamRobotic : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        
        public virtual IList<Classroom> Classrooms { get; set; }
        public virtual IList<DeviceCategory> Devices { get; set; }
    }
}
