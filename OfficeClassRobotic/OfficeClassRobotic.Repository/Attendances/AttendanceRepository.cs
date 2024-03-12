using OfficeClassRobotic.DAO.Attendances;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;

namespace OfficeClassRobotic.Repository.Attendances
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private AttendanceDAO _dao;

        public AttendanceRepository()
        {
            _dao = new AttendanceDAO();
        }

        public async Task<List<AttendenceStudentOfClass>?> GetAttendanceOfClassByClassName(string className, DateTime dateStudy)
        {
            return await _dao.Instance.GetAttendanceOfClassByClassName(className,dateStudy);
        }

        public async Task<ClassRoboticResponse> UpdateAttendanceOfClassByClassName(List<AttendenceStudentOfClass> request)
        {
            await _dao.Instance.UpdateAttendanceOfClassByClassName(request);
            return new ClassRoboticResponse
            {
                Message = ClassRoboticMessage.UpdateSuccessfully,
            };
        }
    }
}
