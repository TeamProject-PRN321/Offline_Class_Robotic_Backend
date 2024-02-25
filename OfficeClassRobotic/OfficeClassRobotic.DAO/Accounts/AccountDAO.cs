using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;
using System.Security.Cryptography;
using System.Text;

namespace OfficeClassRobotic.DAO.Accounts
{
    public class AccountDAO
    {
        private ApplicationDBContext _dbContext;
        private AccountDAO _instance;

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
                Name = request.FullName,
                Address = request.Address,
                AppUserId = user.Id,
                Birthday = request.DateOfBirth,
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
                Name = request.FullName,
                Address = request.Address,
                AppUserId = user.Id,
                Birthday = request.DateOfBirth,
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
                Name = request.FullName,
                Address = request.Address,
                AppUserId = user.Id,
                Birthday = request.DateOfBirth,
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
                Name = request.FullName,
                Address = request.Address,
                AppUserId = user.Id,
                Birthday = request.DateOfBirth,
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
                Name = request.FullName,
                Address = request.Address,
                AppUserId = user.Id,
                Birthday = request.DateOfBirth,
            };
            _dbContext.Teacher.Add(teacher);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<TokenModel> Login(LoginModel request)
        {
            var user = await _dbContext.AppUsers.Where(x => (x.UserName.ToLower() == request.UserNameOrEmail.ToLower() || x.Email.ToLower() == request.UserNameOrEmail.ToLower())).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new KeyNotFoundException($"Không tìm thấy tên đăng nhập hoặc địa chỉ email '{request.UserNameOrEmail}'");
            }

            var enteredPasswordBytes = Encoding.UTF8.GetBytes(request.Password);

            var storedSalt = user.PassWordSalt;

            using var hmacForLogin = new HMACSHA512(storedSalt);
            var enteredPasswordHash = hmacForLogin.ComputeHash(enteredPasswordBytes);

            bool passwordsMatch = enteredPasswordHash.SequenceEqual(user.PassWordHash);
            if (!passwordsMatch)
            {
                throw new InvalidOperationException("Sai mật khẩu. Vui lòng nhập lại!");
            }



            return null;
        }
        private async Task<TokenModel> GenerateToken(AppUser user)
        {
            try
            {

            }
            catch
            {
                throw new InvalidOperationException("Sai mật khẩu. Vui lòng nhập lại!");
            }
            return null;
        }
    }
}
