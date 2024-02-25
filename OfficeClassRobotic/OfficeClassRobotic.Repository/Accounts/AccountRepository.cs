using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OfficeClassRobotic.DAO.Accounts;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OfficeClassRobotic.Repository.Accounts
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountDAO _accountDAO;
        private readonly JwtSettings _jwtSettings;

        public AccountRepository(IOptions<JwtSettings> jwtSettings)
        {
            _accountDAO = new AccountDAO();
            _jwtSettings = jwtSettings.Value;
        }

        public Task<ClassRoboticResponse> CreateAccountAdmin(AccountAdminDTO request)
        {
            throw new NotImplementedException();
        }

        public Task<ClassRoboticResponse> CreateAccountParent(AccountParentDTO request)
        {
            throw new NotImplementedException();
        }

        public Task<ClassRoboticResponse> CreateAccountStaff(AccountStaffDTO request)
        {
            throw new NotImplementedException();
        }

        public Task<ClassRoboticResponse> CreateAccountStudent(AccountStudentDTO request)
        {
            throw new NotImplementedException();
        }

        public Task<ClassRoboticResponse> CreateAccountTeacher(AccountTeacherDTO request)
        {
            throw new NotImplementedException();
        }

        private async Task<TokenModel> GenerateTokenModel(AppUserModel user)
        {
            try
            {
                if (user == null)
                {
                    // Thực chất kh thể ra lỗi này vì đã bắt hầu hết các lỗi ở DAO, nhưng để ở đây thêm cho đẹp
                    throw new InvalidOperationException("Có lỗi trong quá trình đăng nhập, vui lòng kiểm tra lại");
                }
                var roleClaims = user.ListRole.Select(q => new Claim("role", q)).ToList();
                List<Claim> authClaims = new List<Claim>();
                authClaims.Add(new Claim(JwtRegisteredClaimNames.Email, user.AppUser.Email));
                authClaims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.AppUser.UserName));
                authClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
                authClaims.Add(new Claim("Id", user.AppUser.Id.ToString()));

                foreach (var item in user.ListRole)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, item));
                }
                var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));

                var token = new JwtSecurityToken(
                    issuer: _jwtSettings.Issuer,
                    audience: _jwtSettings.Audience,
                    claims: authClaims.Union(roleClaims),
                    expires: DateTime.Now.AddMinutes(_jwtSettings.DurationInMinutes),
                    signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
                    );

                var accessToken = new JwtSecurityTokenHandler().WriteToken(token);
                var refreshToken = await _accountDAO.GenerateRefreshToken(user.AppUser, token);
                return new TokenModel()
                {
                    AccessToken = accessToken,
                    RefreshToken = refreshToken,
                    Expires = DateTime.Now.AddMinutes(_jwtSettings.DurationInMinutes),
                };
            }
            catch
            {
                throw new InvalidOperationException("Sai mật khẩu. Vui lòng nhập lại!");
            }
        }
        public async Task<TokenModel> Login(LoginModel login)
        {
            var user = await _accountDAO.Login(login);
            var token = await GenerateTokenModel(user);
            return token;
        }

        public async Task<TokenModel> RefreshToken(TokenModel model)
        {
            var secretKeyBytes = Encoding.UTF8.GetBytes(_jwtSettings.Key);
            var userRefresh = await _accountDAO.RenewToken(model, secretKeyBytes);
            var token = await GenerateTokenModel(userRefresh);
            return token;
        }
    }
}
