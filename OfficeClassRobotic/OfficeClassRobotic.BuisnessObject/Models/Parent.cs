using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Parent : BaseAuditableEntity
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        //public int ParentID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateOnly Birthday { get; set; }

        [Required]
        public Guid AppUserId { get; set; }
        public virtual IList<Student> Students { get; set; }

    }
}
