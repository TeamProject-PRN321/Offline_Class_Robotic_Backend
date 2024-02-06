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
        [ForeignKey("GiaoTrinh")]
        public int GiaoTrinhID { get; set; }
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }

        public virtual Student? Student { get; set; }
        public virtual Class? Class { get; set; }
        public virtual GiaoTrinh? GiaoTrinh { get; set; }
    }
}
