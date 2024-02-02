using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class GiaoTrinh
    {
        public int GiaoTrinhID { get; set; }
        public string GiaoTrinhName { get; set; }
        public string Description { get; set; }
        public string FilePDF { get; set; }
        public int SubjectID { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
