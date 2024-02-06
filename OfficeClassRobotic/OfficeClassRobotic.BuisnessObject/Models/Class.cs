using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public DateTime DayStudy { get; set; }
        public int NumberOfSudent { get; set; }
        public double? MarkOfStudent { get; set; }
        [ForeignKey("Subject")]
        public int SubjectID { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherID {  get; set; }
        [ForeignKey("TrungTamRobotic")]
        public int TrungTamRoboticID { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual TrungTamRobotic TrungTamRobotic { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Attendance Attendance { get; set; }
    }
}
