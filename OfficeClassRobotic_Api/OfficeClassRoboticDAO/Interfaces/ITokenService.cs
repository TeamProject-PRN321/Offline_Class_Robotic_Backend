using Models.DataAccess;

namespace OfficeClassRobotic.BuisnessTier.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser appUser);
    }
}
