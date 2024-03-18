
using Models.OfficeClassRobotic.BuisnessObject;

namespace OfficeClassRobotic.Repository.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser appUser);
    }
}
