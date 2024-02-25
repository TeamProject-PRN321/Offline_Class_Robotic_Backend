using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    public class RefreshToken : BaseAuditableEntity
    {
        [ForeignKey("AppUser")]
        public Guid AppUserId { get; set; }
        public string RefreshTOken { get; set; } = null!;
        public string? JwtId { get; set; }
        public int UsageCount { get; set; }
        public bool IsUsed { get; set; }
        public bool IsRevoked { get; set; }
        public DateTime IssuedAt { get; set; }
        public DateTime ExpiredAt { get; set; }


        // relationShip
        public virtual AppUser AppUser { get; set; }
    }
}
