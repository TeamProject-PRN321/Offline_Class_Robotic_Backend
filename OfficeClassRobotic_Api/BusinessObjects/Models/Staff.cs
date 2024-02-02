using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataAccess
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly Birthday { get; set; }

        public int TrungTamRoboticID { get; set; }
        public virtual TrungTamRobotic TrungTamRobotic { get; set; }
    }
}
