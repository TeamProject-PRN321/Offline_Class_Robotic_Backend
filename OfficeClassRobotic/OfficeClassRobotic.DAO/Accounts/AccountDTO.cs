using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Parents;
using OfficeClassRobotic.DAO.Students;
using OfficeClassRobotic.DAO.Teachers;
using System.ComponentModel.DataAnnotations;

namespace OfficeClassRobotic.DAO.Accounts
{
    public class AccountDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string? PhotoUrl { get; set; }
    }
    public class AccountStaffDTO : AccountDTO { }
    public class AccountAdminDTO : AccountDTO { }
    public class AccountParentDTO : AccountDTO { }
    public class AccountTeacherDTO : AccountDTO { }
    public class AccountStudentDTO : AccountDTO
    {
        public string ParentID { get; set; }
    }
    public class LoginModel
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
    public class AppUserModel
    {
        public AppUser AppUser { get; set; } = null!;
        public List<string> ListRole { get; set; } = null!;
    }
    public class TokenModel
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }

        // ngay het han
        public DateTime Expires { get; set; }
    }
    public class JwtSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double DurationInMinutes { get; set; }
    }
}
