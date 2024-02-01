using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataAccess
{
    public class FeedBack
    {
        public int FeedbackID { get; set; }
        public string FeedBackName { get; set; }
        public string Description { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public int TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }


    }
}
