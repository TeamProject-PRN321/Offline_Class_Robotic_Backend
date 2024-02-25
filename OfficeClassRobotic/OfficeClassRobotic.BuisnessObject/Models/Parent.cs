using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Parent : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateOnly Birthday { get; set; }
        [ForeignKey("AppUser")]
        public Guid AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }

    }
}
