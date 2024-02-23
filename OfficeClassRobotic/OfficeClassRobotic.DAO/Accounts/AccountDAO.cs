using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
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
        public async Task CreateStudentAccount(AccountStudentDTO request)
        {
            var checkExist = _dbContext.AppUsers.Where(x => x.UserName == request.UserName).FirstOrDefault();
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
            await _dbContext.SaveChangesAsync();
            /*            var user = _mapper.Map<AppUser>(registerDto);

                        using var hmac = new HMACSHA512();

                        user.UserName = registerDto.Username.ToLower();
                        user.PassWordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password));
                        user.PassWordSalt = hmac.Key;

                        _context.AppUsers.Add(user);
                        await _context.SaveChangesAsync();

                        return new UserDto
                        {
                            Username = user.UserName,
                            TokenKey = _tokenService.CreateToken(user),
                            Gender = user.Gender
                        };*/
        }
    }
}
