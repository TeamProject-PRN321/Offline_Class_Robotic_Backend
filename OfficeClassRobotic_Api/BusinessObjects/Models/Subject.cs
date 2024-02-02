using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataAccess
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int TotalSlots { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public virtual GiaoTrinh GiaoTrinh { get; set; }
        public virtual Class Class { get; set; }
    }
}
