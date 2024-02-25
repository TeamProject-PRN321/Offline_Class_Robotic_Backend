using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace OfficeClassRobotic.DAO.Accounts
{
    public class AccountDAO
    {
        private ApplicationDBContext _dbContext;
        private AccountDAO _instance;

        public AccountDAO()
        {
            _dbContext = new ApplicationDBContext();
        }

        public AccountDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountDAO();
                }
                return _instance;
            }
            set => _instance = value;
        }
        /// <summary>
        /// Tạo account cho student
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        public async Task CreateStudentAccount(AccountStudentDTO request)
        {
            var checkExist = _dbContext.AppUsers.Where(x => x.UserName == request.UserName || x.Email == request.Email).FirstOrDefault();
            if (checkExist != null)
            {
                throw new BadRequestException("Account have been existed!");
            }
            using var hmac = new HMACSHA512();
            // Add App User
            var user = new AppUser
            {
                Address = request.Address,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                FullName = request.FullName,
                Gender = request.Gender,
                PassWordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(request.Password)),
                PassWordSalt = hmac.Key,
                UserName = request.UserName,
                PhotoUrl = request.PhotoUrl,
            };
            _dbContext.AppUsers.Add(user);

            // Add AppUser_Role
            var userRole = new AppUserRole
            {
                AppUserId = user.Id,
                RoleId = Guid.Parse("B308C9A8-9A44-4662-B010-E4688FB8E019")
            };
            _dbContext.AppUserRoles.Add(userRole);

            // Add Student Table 
            var student = new Student
            {
                AppUserId = user.Id,
                //Parent ID co cung duoc, khong co cung duoc
                ParentId = Guid.Parse(request.ParentID)
            };
            _dbContext.Students.Add(student);


            await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Tạo account cho staff
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        public async Task CreateStaffAccount(AccountStaffDTO request)
        {
            var checkExist = _dbContext.AppUsers.Where(x => x.UserName == request.UserName || x.Email == request.Email).FirstOrDefault();
            if (checkExist != null)
            {
                throw new BadRequestException("Account have been existed!");
            }
            using var hmac = new HMACSHA512();
            var user = new AppUser
            {
                Address = request.Address,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                FullName = request.FullName,
                Gender = request.Gender,
                PassWordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(request.Password)),
                PassWordSalt = hmac.Key,
                UserName = request.UserName,
                PhotoUrl = request.PhotoUrl,
            };
            _dbContext.AppUsers.Add(user);

            // Add AppUser_Role
            var userRole = new AppUserRole
            {
                AppUserId = user.Id,
                RoleId = Guid.Parse("DC1C58F1-326B-43C0-A750-263BCEEE32BE")
            };
            _dbContext.AppUserRoles.Add(userRole);

            // Add Student Table 
            var staff = new Staff
            {
                AppUserId = user.Id,
                //Parent ID co cung duoc, khong co cung duoc
            };
            _dbContext.Staffs.Add(staff);

            await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Tạo account cho Admin
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        public async Task CreateAdminAccount(AccountAdminDTO request)
        {
            var checkExist = _dbContext.AppUsers.Where(x => x.UserName == request.UserName || x.Email == request.Email).FirstOrDefault();
            if (checkExist != null)
            {
                throw new BadRequestException("Account have been existed!");
            }
            using var hmac = new HMACSHA512();
            var user = new AppUser
            {
                Address = request.Address,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                FullName = request.FullName,
                Gender = request.Gender,
                PassWordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(request.Password)),
                PassWordSalt = hmac.Key,
                UserName = request.UserName,
                PhotoUrl = request.PhotoUrl,
            };
            _dbContext.AppUsers.Add(user);

            // Add AppUser_Role
            var userRole = new AppUserRole
            {
                AppUserId = user.Id,
                RoleId = Guid.Parse("891E4E1C-BED5-4992-A978-FC969FDAF128")
            };
            _dbContext.AppUserRoles.Add(userRole);

            // Add account Table 
            var admin = new Admin
            {
                AppUserId = user.Id,
                //Parent ID co cung duoc, khong co cung duoc
            };
            _dbContext.Admins.Add(admin);

            await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Tạo account cho Parent
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        public async Task CreateParentAccount(AccountParentDTO request)
        {
            var checkExist = _dbContext.AppUsers.Where(x => x.UserName == request.UserName || x.Email == request.Email).FirstOrDefault();
            if (checkExist != null)
            {
                throw new BadRequestException("Account have been existed!");
            }
            using var hmac = new HMACSHA512();
            var user = new AppUser
            {
                Address = request.Address,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                FullName = request.FullName,
                Gender = request.Gender,
                PassWordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(request.Password)),
                PassWordSalt = hmac.Key,
                UserName = request.UserName,
                PhotoUrl = request.PhotoUrl,
            };
            _dbContext.AppUsers.Add(user);

            // Add AppUser_Role
            var userRole = new AppUserRole
            {
                AppUserId = user.Id,
                RoleId = Guid.Parse("1C477667-FBC0-4C85-9D2F-1F5A6DA3EDAC")
            };
            _dbContext.AppUserRoles.Add(userRole);

            // Add account Table 
            var parent = new Parent
            {
                AppUserId = user.Id,
            };
            _dbContext.Parents.Add(parent);

            await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Tạo account cho Teacher
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        public async Task CreateTeacherAccount(AccountParentDTO request)
        {
            var checkExist = _dbContext.AppUsers.Where(x => x.UserName == request.UserName || x.Email == request.Email).FirstOrDefault();
            if (checkExist != null)
            {
                throw new BadRequestException("Account have been existed!");
            }
            using var hmac = new HMACSHA512();
            var user = new AppUser
            {
                Address = request.Address,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                FullName = request.FullName,
                Gender = request.Gender,
                PassWordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(request.Password)),
                PassWordSalt = hmac.Key,
                UserName = request.UserName,
                PhotoUrl = request.PhotoUrl,
            };
            _dbContext.AppUsers.Add(user);

            // Add AppUser_Role
            var userRole = new AppUserRole
            {
                AppUserId = user.Id,
                RoleId = Guid.Parse("433CA17D-2BB8-4A98-91E6-5703365CB2FD")
            };
            _dbContext.AppUserRoles.Add(userRole);

            // Add account Table 
            var teacher = new Teacher
            {
                AppUserId = user.Id,
            };
            _dbContext.Teacher.Add(teacher);

            await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Đăng nhập để check User
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        /// <exception cref="BadRequestException"></exception>
        public async Task<AppUserModel> Login(LoginModel request)
        {
            var user = await _dbContext.AppUsers.Where(x => (x.UserName.ToLower() == request.UserNameOrEmail.ToLower() || x.Email.ToLower() == request.UserNameOrEmail.ToLower())).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new NotFoundException($"Không tìm thấy tên đăng nhập hoặc địa chỉ email '{request.UserNameOrEmail}'");
            }

            var enteredPasswordBytes = Encoding.UTF8.GetBytes(request.Password);

            var storedSalt = user.PassWordSalt;

            using var hmacForLogin = new HMACSHA512(storedSalt);
            var enteredPasswordHash = hmacForLogin.ComputeHash(enteredPasswordBytes);

            bool passwordsMatch = enteredPasswordHash.SequenceEqual(user.PassWordHash);
            if (!passwordsMatch)
            {
                throw new BadRequestException("Sai mật khẩu. Vui lòng nhập lại!");
            }
            var response = new AppUserModel();
            var listRole = await _dbContext.AppUserRoles.Where(x => x.AppUserId == user.Id).Select(x => x.RoleId).ToListAsync();
            response.AppUser = user;
            response.ListRole = new List<string>();
            foreach (var item in listRole)
            {
                var role = _dbContext.Roles.Where(x => x.Id == item).Select(x => x.RoleName).FirstOrDefault();
                if (role != null)
                {
                    response.ListRole.Add(role);
                }
            }
            return response;
        }
        public async Task<string> GenerateRefreshToken(AppUser user, JwtSecurityToken token)
        {
            var refreshToken = GenerateRefreshToken();

            //Lưu RefreshToken vào Database
            var refreshTokenEntity = new RefreshToken
            {
                AppUserId = user.Id,
                JwtId = token.Id,
                RefreshTOken = refreshToken,
                IsUsed = false,
                IsRevoked = false,
                IssuedAt = DateTime.Now,
                ExpiredAt = DateTime.Now.AddDays(30),
            };
            _dbContext.RefreshToken.Add(refreshTokenEntity);
            await _dbContext.SaveChangesAsync();

            return refreshToken;
        }
        public async Task<AppUserModel> RenewToken(TokenModel model, byte[] key)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var tokenValidateParam = new TokenValidationParameters
            {
                //Tự cấp Token
                ValidateIssuer = false,
                ValidateAudience = false,

                //Ký vào token
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),

                ValidateLifetime = false,//Kh kiểm tra token hết hạn
            };
            try
            {
                //Check 1: AccessToken Valid Format
                var tokenInverification = jwtTokenHandler.ValidateToken(model.AccessToken, tokenValidateParam, out var validateToken);

                //Check 2: Check Alg
                if (validateToken is JwtSecurityToken jwtSecurityToken)
                {
                    var result = jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha512Signature, StringComparison.InvariantCultureIgnoreCase);
                    if (!result)
                    {
                        throw new BadRequestException("Có lỗi xãy ra trong quá trình refresh token!!!!");
                    }
                }
                //Check 3: Check accessToken expire?
                var utcExpireDate = long.Parse(tokenInverification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp)!.Value);

                var expireDate = ConvertUnixTimeToDateTime(utcExpireDate);
                if (expireDate > DateTime.Now)
                {
                    throw new BadRequestException("Token chưa hết hạn!!!!");
                }
                //Check 4: Check refreshtoken exist in DB
                var storedToken = _dbContext.RefreshToken.FirstOrDefault(x => x.RefreshTOken == model.RefreshToken);
                if (storedToken == null)
                {
                    throw new BadRequestException("Token chưa từng tồn tại!!!");
                }
                if (storedToken.IsRevoked)
                {
                    throw new BadRequestException("Token đã được sử dụng!!!");
                }
                //Check 6: Accesstoken id 
                var jti = tokenInverification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti)!.Value;
                if (storedToken.JwtId != jti)
                {
                    throw new BadRequestException("Token có vấn đề!!!!");
                }
                //Update token is used
                storedToken.IsRevoked = true;
                storedToken.IsUsed = true;
                _dbContext.RefreshToken.Update(storedToken);
                await _dbContext.SaveChangesAsync();

                //Create new token
                var user = await _dbContext.AppUsers.FirstOrDefaultAsync(x => x.Id == storedToken.AppUserId);

                var response = new AppUserModel();
                response.AppUser = user!;
                response.ListRole = new List<string>();

                var listRole = await _dbContext.AppUserRoles.Where(x => x.AppUserId == user!.Id).Select(x => x.RoleId).ToListAsync();
                foreach (var item in listRole)
                {
                    var role = _dbContext.Roles.Where(x => x.Id == item).Select(x => x.RoleName).FirstOrDefault();
                    if (role != null)
                    {
                        response.ListRole.Add(role);
                    }
                }
                return response;
            }
            catch
            {
                throw new BadRequestException("Đăng nhập thất bại!!!");
            }
        }
        private DateTime ConvertUnixTimeToDateTime(long utcExpireDate)
        {
            var dateTimeOffset = DateTimeOffset.FromFileTime(utcExpireDate);
            var test = dateTimeOffset.DateTime;
            var dateTimeInterval = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var result = dateTimeInterval.AddHours(7).AddSeconds(utcExpireDate).ToUniversalTime();
            return result;
        }
        private string GenerateRefreshToken()
        {
            var random = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(random);
                return Convert.ToBase64String(random);
            }
        }
    }

}
