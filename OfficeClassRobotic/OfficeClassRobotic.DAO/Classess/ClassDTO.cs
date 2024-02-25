using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.Classess
{
    public class ClassDTO
    {
        public string? ClassName { get; set; }
        public List<string>? DayStudy { get; set; }
        public string StudentId { get; set; }
        public string SubjectId { get; set; }
    }
}
