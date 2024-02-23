using OfficeClassRobotic.DAO.Parents;
using OfficeClassRobotic.DAO.Students;
using OfficeClassRobotic.DAO.Teachers;
using System.ComponentModel.DataAnnotations;

namespace OfficeClassRobotic.DAO.Accounts
{
    public class AccountDTO
    {
        /*
         *         [Required]
        public string Username { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhotoUrl { get; set; }
         */
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        /*
                public byte[] PassWordHash { get; set; }
                public byte[] PassWordSalt { get; set; }*/
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string? PhotoUrl { get; set; }
    }
    public class AccountStudentDTO : AccountDTO
    {

        public CreateStudentCommand StudentInfor { get; set; }
    }
    public class AccountParentDTO : AccountDTO
    {
        public CreateParentCommand ParentInfor { get; set; }
    }
    public class AccountTeacher : AccountDTO
    {
        public CreateTeacherDTO TeacherInfor { get; set;}
    }
}
