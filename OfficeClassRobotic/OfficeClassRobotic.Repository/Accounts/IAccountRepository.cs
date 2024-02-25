using OfficeClassRobotic.DAO.Accounts;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;

namespace OfficeClassRobotic.Repository.Accounts
{
    public interface IAccountRepository
    {
        public Task<TokenModel> Login(LoginModel login);
        public Task<TokenModel> RefreshToken(TokenModel model);
        public Task<ClassRoboticResponse> CreateAccountStudent(AccountStudentDTO request);
        public Task<ClassRoboticResponse> CreateAccountStaff(AccountStaffDTO request);
        public Task<ClassRoboticResponse> CreateAccountAdmin(AccountAdminDTO request);
        public Task<ClassRoboticResponse> CreateAccountTeacher(AccountTeacherDTO request);
        public Task<ClassRoboticResponse> CreateAccountParent(AccountParentDTO request);
    }
}
