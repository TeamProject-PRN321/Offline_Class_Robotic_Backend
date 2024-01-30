using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DataAccess
{
    public class Parent
    {
        public int ParnetID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateOnly Birthday { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
