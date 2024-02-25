using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.API.DTOs;
using OfficeClassRobotic.DAO.Accounts;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Repository.Accounts;
using OfficeClassRobotic.Repository.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace OfficeClassRobotic.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly IAccountRepository _accountRepository;

        public AccountController(ApplicationDBContext context, ITokenService tokenService, IMapper mapper, IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
            _context = context;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {

            if (await UserExists(registerDto.Username))
            {
                return BadRequest("Username is already taken");
            }

            var user = _mapper.Map<AppUser>(registerDto);

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
            };
        }

        [HttpPost("login")]
        public async Task<ActionResult<TokenModel>> Login(LoginDto loginDto)
        {
            var response =await _accountRepository.Login(new LoginModel
            {
                UserNameOrEmail = loginDto.Username,
                Password = loginDto.Password,
            });
            return response;
        }
        [HttpPost("refresh")]
        public async Task<ActionResult<TokenModel>> Refresh(TokenModel model)
        {
            var response = await _accountRepository.RefreshToken(model);
            return response;
        }

        private async Task<bool> UserExists(string username)
        {
            return await _context.AppUsers.AnyAsync(x => x.UserName.ToLower() == username.ToLower());
        }
    }
}
