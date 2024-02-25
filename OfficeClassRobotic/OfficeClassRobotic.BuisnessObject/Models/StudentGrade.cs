using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    public class StudentGrade : BaseAuditableEntity
    {
        public string? AssesessmentType { get; set; }

        [ForeignKey("Class")]
        public Guid ClassId { get; set; }

        public double Grade { get; set; }

        public virtual Class Class { get; set; }
    }
}
