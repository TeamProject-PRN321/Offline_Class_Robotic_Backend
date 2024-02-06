using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.Students
{
    public class StudentDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateOnly Birthday { get; set; }
        
        public int ParentID { get; set; }
    }
}
