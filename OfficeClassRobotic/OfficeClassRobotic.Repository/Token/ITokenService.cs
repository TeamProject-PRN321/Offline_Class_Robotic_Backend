
using Models.OfficeClassRobotic.BuisnessObject;

namespace OfficeClassRobotic.Repository.Token
{
    public interface ITokenService
    {
        string CreateToken(AppUser appUser);
    }
}
