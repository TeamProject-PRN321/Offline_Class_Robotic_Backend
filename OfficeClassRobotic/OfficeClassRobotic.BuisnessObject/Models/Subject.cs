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
    public class Subject : BaseAuditableEntity
    {
        public string? SubjectName { get; set; }
        public int TotalSlots { get; set; }

        public ICollection<Class> Class { get; set; }
        public ICollection<GiaoTrinh> GiaoTrinh { get; set; }
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }
        public ICollection<SubjectGradingWeight> SubjectGradingWeight { get; set; }


    }
}
