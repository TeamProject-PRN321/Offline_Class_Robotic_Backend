using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;

namespace OfficeClassRobotic.DAO.Teachers
{
    public class TeacherDAO
    {
        private static TeacherDAO instance;
        private static ApplicationDBContext _dbContext;

        public TeacherDAO()
        {
            _dbContext = new ApplicationDBContext();
        }
        public static TeacherDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TeacherDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        /// <summary>
        /// Update Teacher
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        public async Task UpdateTeacher(UpdateTeacherDTO request)
        {
            if (request.ListSubjectId != null && request.ListSubjectId.Any())
            {
                var checkExistSubject = _dbContext.Subjects.Where(x => !request.ListSubjectId.Contains(x.Id) || (request.ListSubjectId.Contains(x.Id) && x.IsDeleted));
                if (checkExistSubject.Any())
                {
                    throw new NotFoundException(ClassRoboticMessage.DoesNotExistOrHaveBeenDeleted);
                }
            }
            //Tìm giảng viên
            var teacher = _dbContext.Teacher.Where(x => x.Id == request.TeacherId).FirstOrDefault();
            if (teacher != null)
            {
                if (request.ListSubjectId != null && request.ListSubjectId.Any())
                {
                    //Xóa cũ thay mới
                    var oldTeacherSubject = await _dbContext.TeacherSubjects.Where(x => x.TeacherId == request.TeacherId).ToListAsync();
                    _dbContext.TeacherSubjects.RemoveRange(oldTeacherSubject);
                    foreach (var subjectId in request.ListSubjectId)
                    {
                        var tS = new TeacherSubject
                        {
                            SubjectId = subjectId,
                            TeacherId = teacher.Id
                        };
                        _dbContext.TeacherSubjects.Add(tS);
                    }
                }
            }

            await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Get All teacher
        /// </summary>
        /// <returns></returns>
        public async Task<List<TeacherDTO>?> GetAllTeacher()
        {
            var listResult = new List<TeacherDTO>();
            var listTeacher = _dbContext.Teacher.Where(x => !x.IsDeleted).Include(x => x.TeacherSubjects).ToList();
            if (listTeacher.Any())
            {
                foreach (var teacher in listTeacher)
                {
                    var listSubjectOfTeacher = new List<GetSubjectOfTeacher>();
                    if (teacher.TeacherSubjects.Any())
                    {
                        foreach (var ts in teacher.TeacherSubjects)
                        {
                            var subject = await _dbContext.Subjects.Where(x => x.Id == ts.SubjectId && !x.IsDeleted).FirstOrDefaultAsync();
                            if (subject != null)
                            {
                                listSubjectOfTeacher.Add(new GetSubjectOfTeacher
                                {
                                    SubjectId = subject.Id,
                                    SubjectName = subject.SubjectName,
                                });
                            }
                        }
                    }
                    var teacherInfo = await GetTeacherByTeacherId(new GetTeacherOrDeleteTeacherByTeacherId
                    {
                        TeacherId = teacher.Id
                    });
                    var result = new TeacherDTO()
                    {
                        ListSubjectOfTeacher = listSubjectOfTeacher,
                        TeacherId = teacher.Id,
                        Address = teacherInfo.Address,
                        Birthday = teacherInfo.Birthday,
                        Gender = teacherInfo.Gender,
                        PhoneNumber = teacherInfo.PhoneNumber,
                        Name = teacherInfo.Name,
                    };
                    listResult.Add(result);
                }
            }
            return listResult;
        }
        /// <summary>
        /// Get Teacher by Teacher ID
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        public async Task<TeacherDTO> GetTeacherByTeacherId(GetTeacherOrDeleteTeacherByTeacherId request)
        {
            var teacher = _dbContext.Teacher.Where(x => x.Id == request.TeacherId && !x.IsDeleted).Include(x => x.TeacherSubjects).FirstOrDefault();
            if (teacher == null)
            {
                throw new NotFoundException(ClassRoboticMessage.DoesNotExistOrHaveBeenDeleted);
            }
            var teacherAppuserInfo = _dbContext.AppUsers.Where(x => x.Id == teacher.AppUserId).SingleOrDefault();

            var listTeacherSubject = new List<GetSubjectOfTeacher>();
            if (teacher.TeacherSubjects.Any())
            {
                foreach (var s in teacher.TeacherSubjects)
                {
                    var sj = await _dbContext.Subjects.Where(x => x.Id == s.SubjectId && !x.IsDeleted).FirstOrDefaultAsync();
                    if (sj != null)
                    {
                        var teacherSubject = new GetSubjectOfTeacher()
                        {
                            SubjectId = sj.Id,
                            SubjectName = sj.SubjectName,
                        };
                        listTeacherSubject.Add(teacherSubject);
                    }
                }
            }
            var result = new TeacherDTO
            {
                ListSubjectOfTeacher = listTeacherSubject,
                PhoneNumber = teacherAppuserInfo.PhoneNumber,
                Address = teacherAppuserInfo.Address,
                Birthday = teacherAppuserInfo.DateOfBirth,
                Gender = teacherAppuserInfo.Gender,
                Name = teacherAppuserInfo.FullName,
                TeacherId = teacher.Id,
            };
            return result;
        }
        /// <summary>
        /// Get Teacher By Subject ID
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<List<TeacherDTO>?> GetAllTeacherBySubjectId(GetTeacherBySubjectId request)
        {
            var listSubject = await _dbContext.TeacherSubjects.Where(x => x.SubjectId == request.SubjectId).ToListAsync();
            var listResult = new List<TeacherDTO>();
            if (listSubject.Any())
            {
                foreach (var item in listSubject)
                {
                    var teacherDTO = await GetTeacherByTeacherId(new GetTeacherOrDeleteTeacherByTeacherId
                    {
                        TeacherId = item.TeacherId
                    });
                    listResult.Add(teacherDTO);
                }
            }
            return listResult;
        }
        /// <summary>
        /// Dùng để Update Subject cho Teacher
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        public async Task UpdateteacherWithSubject(ConnectTeacherWithListSubjectRequest request)
        {
            var teacher = _dbContext.Teacher.Where(x => x.Id == request.TeacherId && !x.IsDeleted).FirstOrDefault();
            if (teacher == null)
            {
                throw new NotFoundException("Không tìm thấy giảng viên nào có tên như trên!");
            }
            var flagSubject = await _dbContext.Subjects.Where(x => request.ListSubjectId.Contains(x.Id) && !x.IsDeleted).ToListAsync();
            if (!flagSubject.Any())
            {
                throw new NotFoundException("Không tìm thấy môn học nào có tên như trên!");
            }
            if (flagSubject.Count != request.ListSubjectId.Count)
            {
                throw new NotFoundException("Đã có môn học nào đó trong danh sách bị xóa, vui lòng kiểm tra lại!!");
            }
            var listTeacherSubjectOld = _dbContext.TeacherSubjects.Where(x => x.TeacherId == request.TeacherId).ToList();
            if (listTeacherSubjectOld.Any())
            {
                _dbContext.TeacherSubjects.RemoveRange(listTeacherSubjectOld);
            }
            foreach (var item in request.ListSubjectId)
            {
                var teacherSubject = new TeacherSubject
                {
                    SubjectId = item,
                    TeacherId = request.TeacherId
                };
                _dbContext.TeacherSubjects.Add(teacherSubject);
            }
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<TeacherSchedule>> GetScheduleOfTeacherByTeacherIdAndTime(TeacherScheduleRequest request)
        {
            var listResult = new List<TeacherSchedule>();
            var teacher = await _dbContext.Teacher.Where(x => x.AppUserId == request.AppUserId).FirstOrDefaultAsync();
            if (teacher == null)
            {
                throw new BadRequestException("Không tìm thấy Teacher nào có Appuser ID như: " + request.AppUserId);
            }
            var listClassSchedule = await _dbContext.ClassSchedule
                .Where(x => x.TeacherId == teacher.Id &&
                            x.DateStudy >= request.DateStartOfWeek &&
                            x.DateStudy <= request.DateEndOfWeek)
                .GroupBy(x => new { x.DateStudy, x.StartTime, x.ClassRoomID, x.EndTime, x.NumberOfSudent })
                .Select(x => new
                {
                    ClassIdCommon = x.Min(y => y.ClassId),
                    DateStudy = x.Key.DateStudy,
                    StartTime = x.Key.StartTime,
                    EndTime = x.Key.EndTime,
                    NumberOfSudent = x.Key.NumberOfSudent,
                    ClassRoomIdCommon = x.Key.ClassRoomID
                })
                .OrderBy(x => x.DateStudy)
                .ThenBy(x => x.StartTime)
                .ToListAsync();
            foreach (var item in listClassSchedule)
            {
                var classOfStudent = await _dbContext.Classes.Where(x => x.Id == Guid.Parse(item.ClassIdCommon.ToString())).FirstAsync();
                var classRoom = _dbContext.Classrooms.Where(x => x.Id == item.ClassRoomIdCommon).First();
                var startTime = item.StartTime!.Value.Hours + ":" + (item.StartTime.Value.Minutes < 10 ? item.StartTime.Value.Minutes + "0" : item.StartTime.Value.Minutes) + " " + (item.StartTime.Value.Hours >= 12 ? "PM" : "AM");
                var endTime = item.EndTime!.Value.Hours + ":" + (item.EndTime.Value.Minutes < 10 ? item.EndTime.Value.Minutes + "0" : item.EndTime.Value.Minutes) + " " + (item.EndTime.Value.Hours >= 12 ? "PM" : "AM"); ;
                var result = new TeacherSchedule()
                {
                    ClassName = classOfStudent.ClassName!,
                    ClassroomName = classRoom.ClassRoomName,
                    DayStudy = item.DateStudy.ToString("dd-MM-yyyy"),
                    StartTime = item.StartTime,
                    EndTime = item.EndTime,
                    TimeDetail = $"Lớp học bắt đầu lúc: {startTime} và kết thúc lúc: {endTime}",
                    TotalStudentInClass = item.NumberOfSudent,
                };
                listResult.Add(result);
            }
            return listResult;
        }
    }
}
