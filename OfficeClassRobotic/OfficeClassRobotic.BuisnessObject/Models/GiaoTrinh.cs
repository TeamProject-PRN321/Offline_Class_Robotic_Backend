using OfficeClassRobotic.BuisnessObject.Models.Common;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class GiaoTrinh : BaseAuditableEntity
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        //public int GiaoTrinhID { get; set; }
        public string? GiaoTrinhName { get; set; }
        public string? Description { get; set; }
        public string? FilePDF { get; set; }

        public virtual Subject? Subject { get; set; }
    }
}
