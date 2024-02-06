using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectID { get; set; }
        public string? SubjectName { get; set; }
        public int TotalSlots { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }

        public virtual Student? Student { get; set; }
        public virtual Class Class { get; set; }
        public virtual GiaoTrinh GiaoTrinh { get; set; }
    }
}
