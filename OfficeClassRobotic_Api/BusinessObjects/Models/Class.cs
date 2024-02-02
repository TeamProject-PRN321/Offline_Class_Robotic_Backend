using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataAccess
{
    public class Class
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public DateTime DayStudy { get; set; }
        public int NumberOfSudent { get; set; }
        public double MarkOfStudent { get; set; }
        public int SubjectID { get; set; }
        public virtual Subject Subject { get; set; }
        public int TeacherID {  get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Attendance Attendance { get; set; }
        public int TrungTamRoboticID { get; set; }
        public virtual TrungTamRobotic TrungTamRobotic { get; set; }

    }
}
