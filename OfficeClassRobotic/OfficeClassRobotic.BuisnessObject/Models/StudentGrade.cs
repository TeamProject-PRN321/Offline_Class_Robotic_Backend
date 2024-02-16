using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    public class StudentGrade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentGradeID { get; set; }
        public string? AssesessmentType { get; set; }

        [ForeignKey("StudentSubject")]
        public int StudentSubjectID { get; set; }

        public double Grade { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }

        public virtual StudentSubject StudentSubject { get; set; }
    }
}
