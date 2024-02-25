

using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Admin : BaseAuditableEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public DateOnly Birthday { get; set; }
        [ForeignKey("AppUser")]
        public Guid AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual IList<TrungTamRobotic> TrungTamRobotic { get; set; }
    }
}
