using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    public class SubjectGradingWeight : BaseAuditableEntity
    {
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

        public virtual Subject Subject { get; set; }
    }
}
