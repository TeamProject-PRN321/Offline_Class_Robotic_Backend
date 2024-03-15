using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.LichHoc_ClassSchedule;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;

namespace OfficeClassRobotic.DAO.Attendances
{
    public class AttendanceDAO
    {
        private ApplicationDBContext _dbContext;
        private AttendanceDAO _instance;
        public AttendanceDAO()
        {
            _dbContext = new ApplicationDBContext();
        }
        public AttendanceDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AttendanceDAO();
                }
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public async Task<List<AttendenceStudentOfClass>?> GetAttendanceOfClassByClassName(string className, DateTime dateStudy)
        {
            var attendanceData = await _dbContext.ClassSchedule
                .Where(cs => cs.DateStudy.Day == dateStudy.Day &&
                             cs.DateStudy.Month == dateStudy.Month &&
                             cs.DateStudy.Year == dateStudy.Year &&
                             cs.Class.ClassName == className)
                .Join(_dbContext.Attendance,
                      cs => cs.Id,
                      atd => atd.ClassScheduleID,
                      (cs, atd) => new { cs, atd })
                .Join(_dbContext.Students,
                      x => x.cs.Class.StudentId,
                      s => s.Id,
                      (x, s) => new { x.cs, x.atd, s })
                .Join(_dbContext.AppUsers,
                      x => x.s.AppUserId,
                      a => a.Id,
                      (x, a) => new { x.cs, x.atd, x.s, a })
                .OrderBy(x => x.cs.DateStudy)
                .ThenBy(x => x.a.FullName)
                .Select(x => new AttendenceStudentOfClass
                {
                    AttendanceStatus = x.atd.AttendStatus,
                    AttendanceId = x.atd.Id,
                    ClassName = x.cs.Class.ClassName,
                    DateStudy = x.cs.DateStudy.ToString("yyyy-MM-dd"),
                    StartTime = x.cs.Class.StartTime.ToString(),
                    EndTime = x.cs.Class.EndTime.ToString(),
                    StudentName = x.a.FullName,
                    StudentId = x.cs.Class.StudentId,
                })
                .ToListAsync();
            return attendanceData;
        }

        public async Task UpdateAttendanceOfClassByClassName(List<AttendenceStudentOfClass> request)
        {
            foreach(var item in request)
            {
                var checkDateTimeNow = DateTime.Now.ToString("yyyy-MM-dd");
                var checkDateAttend = item.DateStudy;
                if (string.Compare(checkDateTimeNow, checkDateAttend) != 0)
                {
                    throw new BadRequestException("Không thể điểm danh khác ngày được: " + item.DateStudy);
                }
                var attend = _dbContext.Attendance.Where(x => x.Id == item.AttendanceId).SingleOrDefault();
                if(attend == null)
                {
                    throw new BadRequestException("Không tìm thấy Student nào có buổi điểm danh :" + item.StudentName);
                }
                attend.AttendStatus = item.AttendanceStatus;
                _dbContext.Attendance.Update(attend);
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
