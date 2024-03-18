using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models.Common;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    public class AppUserRole 
    {
        public Guid AppUserId { get;set;}
        public Guid RoleId { get;set;}

        public virtual AppUser AppUser { get;set;}
        public virtual Role Role { get;set;}
    }
}
