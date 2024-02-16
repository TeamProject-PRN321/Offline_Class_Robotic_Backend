using Models.OfficeClassRobotic.BuisnessObject;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    public class SubjectGradingWeight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectGradingWeightID { get; set; }
        [ForeignKey("Subject")]
        public int SubjectID { get; set; }
        /// <summary>
        /// Dạng kiểm tra : Kiểm tra 15P, Kiểm tra kết thúc môn
        /// </summary>
        public string? AssesessmentType { get; set; }
        /// <summary>
        /// % của mỗi dạng kiểm tra
        /// Ví dụ: 
        /// Kiểm tra 15p : 15%
        /// Kiểm tra 1 tiết lần 1: 20%
        /// </summary>
        public int WeightPercentage { get; set; }

        public bool IsDeleted { get; set; } = false;
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
