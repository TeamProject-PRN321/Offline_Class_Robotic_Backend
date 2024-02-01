using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataAccess
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateOnly Birthday { get; set; }
        public virtual ICollection<TrungTamRobotic> Robotics { get; set; }
    }
}
