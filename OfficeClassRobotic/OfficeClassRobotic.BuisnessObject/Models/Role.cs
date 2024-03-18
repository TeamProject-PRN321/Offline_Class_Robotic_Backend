using OfficeClassRobotic.BuisnessObject.Models.Common;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    public class Role : BaseAuditableEntity
    {
        public string RoleName { get; set; } = null!;  

        public IList<AppUserRole> AppUserRoles { get; set; }
    }
}
