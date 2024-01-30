using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DataAccess
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateOnly Birthday { get; set; }

        public int ParentID { get; set; }
        public Parent Parent { get; set; }
    }
}
