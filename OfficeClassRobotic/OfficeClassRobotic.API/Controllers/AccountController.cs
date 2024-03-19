using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeClassRobotic.API.DTOs;
using OfficeClassRobotic.DAO.Accounts;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.Repository.Accounts;
using OfficeClassRobotic.Service.Exceptions;
using System.Security.Cryptography;
using System.Text;

namespace OfficeClassRobotic.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpPost("register-admin-account")]
        public async Task<ClassRoboticResponse> RegisterAdminAccount(AccountAdminDTO request)
        {
            try
            {
                return await _accountRepository.CreateAccountAdmin(request);
            }
            catch
            {
                throw new BadRequestException(ClassRoboticMessage.CreateFail);
            }
        }

        [HttpPost("register-student-account")]
        public async Task<ClassRoboticResponse> RegisterStudentAccount(AccountStudentDTO request)
        {
            try
            {
                return await _accountRepository.CreateAccountStudent(request);
            }
            catch
            {
                throw new BadRequestException(ClassRoboticMessage.CreateFail);
            }
        }

        [HttpPost("register-staff-account")]
        public async Task<ClassRoboticResponse> RegisterStaffAccount(AccountStaffDTO request)
        {
            try
            {
                return await _accountRepository.CreateAccountStaff(request);
            }
            catch
            {
                throw new BadRequestException(ClassRoboticMessage.CreateFail);
            }
        }

        [HttpPost("register-parents-account")]
        public async Task<ClassRoboticResponse> RegisterParentAccount(AccountParentDTO request)
        {
            try
            {
                return await _accountRepository.CreateAccountParent(request);
            }
            catch
            {
                throw new BadRequestException(ClassRoboticMessage.CreateFail);
            }
        }

        [HttpPost("register-teacher-account")]
        public async Task<ClassRoboticResponse> RegisterTeacherAccount(AccountTeacherDTO request)
        {
            try
            {
                return await _accountRepository.CreateAccountTeacher(request);
            }
            catch
            {
                throw new BadRequestException(ClassRoboticMessage.CreateFail);
            }
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
    }
}
