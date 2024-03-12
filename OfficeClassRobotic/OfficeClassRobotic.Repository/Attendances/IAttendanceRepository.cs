using OfficeClassRobotic.DAO.Attendances;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;

namespace OfficeClassRobotic.Repository.Attendances
{
    public interface IAttendanceRepository
    {
        public Task<ClassRoboticResponse> UpdateAttendanceOfClassByClassName(List<AttendenceStudentOfClass> request);
        public Task<List<AttendenceStudentOfClass>?> GetAttendanceOfClassByClassName(string className, DateTime dateStudy);
    }
}
