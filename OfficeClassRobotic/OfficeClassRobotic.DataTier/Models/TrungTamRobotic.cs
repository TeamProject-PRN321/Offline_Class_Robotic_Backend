using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataAccess
{
    public class TrungTamRobotic
    {
        public int TrungTamRoboticID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int AdminID { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        public virtual ICollection<Classroom> Classrooms { get; set; }

    }
}
