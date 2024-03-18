using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class GiaoTrinh : BaseAuditableEntity
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        //public int GiaoTrinhID { get; set; }
        public string? GiaoTrinhName { get; set; }
        public string? Description { get; set; }
        public string? FilePDFName { get; set; }
        public byte[]? FilePDF { get; set; }
        [ForeignKey("Subject")]
        public Guid SubjectId { get; set; }

        public virtual Subject? Subject { get; set; }
    }
}
