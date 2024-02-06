using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.GiaoTrinhForSubject
{
    public class GiaoTrinhDTO
    {
        public SubjectDTO SubjectDTO {  get; set; } 
        public string? GiaoTrinhName { get; set; }
        public string? Description { get; set; }
        public string? FilePDF { get; set; }
    }

    public class SubjectDTO
    {
        public string? SubjectName { get; set; }
        public int TotalSlots { get; set; }
        public int StudentID { get; set; }
    }
}
