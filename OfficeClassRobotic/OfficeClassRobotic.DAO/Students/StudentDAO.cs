using Microsoft.EntityFrameworkCore;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;
using System.Globalization;
using Models.OfficeClassRobotic.BuisnessObject;
using System.Xml.Linq;
using OfficeClassRobotic.DAO.Classess;
using OfficeClassRobotic.DAO.Attendances;

namespace OfficeClassRobotic.DAO.Students
{
    public class StudentDAO
    {
        private static StudentDAO instance;
        private static ApplicationDBContext _dbContext;
        public StudentDAO()
        {
            _dbContext = new ApplicationDBContext();
        }
        public static StudentDAO Instance
        {
            get
            {
                {
                    instance = new StudentDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public async Task<List<ScheduleOfStudent>?> GetScheduleOfStudentByStudentId(GetStudentScheduleByStudentIdRequest request)
        {
            // Step 1: Lấy hết những Class mà StudentId đang theo học
            var classesOfStudent = _dbContext.Classes.Where(x => x.StudentId == request.StudentId && !x.IsClassFinish).ToList();
            var listResult = new List<ScheduleOfStudent>();
            if (classesOfStudent.Any())
            {
                // Step 2: Lấy những môn student đang học và tính toán lại số lượng điểm danh
                foreach (var classOfStudent in classesOfStudent)
                {
                    var subject = _dbContext.Subjects.Where(x => x.Id == classOfStudent.SubjectId).SingleOrDefault();

                    var classSchedules = await _dbContext.ClassSchedule.Where(x => x.ClassId == classOfStudent.Id)
                        .OrderBy(x => x.DateStudy)
                        .ThenBy(x => x.StartTime)
                        .ToListAsync();
                    int slotRemaining = subject.TotalSlots;
                    foreach (var classSchedule in classSchedules)
                    {
                        var attend = _dbContext.Attendance.Where(x => x.ClassScheduleID == classSchedule.Id).Select(x => x.AttendStatus).FirstOrDefault();
                        if (attend != 0)
                        {
                            slotRemaining--;
                        }
                    }
                    var teacher = _dbContext.Teacher.Where(x => x.Id == classSchedules.Select(x => x.TeacherId).First()).Single();

                    foreach (var item in classSchedules)
                    {
                        var attendance = _dbContext.Attendance.Where(x => x.ClassScheduleID == item.Id).FirstOrDefault();
                        var userTeacher = _dbContext.AppUsers.Where(x => x.Id == teacher.AppUserId).FirstOrDefault();
                        var result = new ScheduleOfStudent()
                        {
                            SubjectId = classOfStudent.SubjectId,
                            SubjectName = subject!.SubjectName!,
                            TeacherId = teacher.Id,
                            TeacherName = userTeacher!.FullName,
                            DateLearn = item.DateStudy.ToString("dd-MM-yyyy"),
                            TimeStart = item.StartTime.ToString(),
                            TimeEnd = item.EndTime.ToString(),
                            SlotRemaining = slotRemaining,
                            SlotAttendanceStatus = attendance!.AttendStatus == 0 ? "Not yet" : attendance.AttendStatus == 1 ? "Present" : "Absent"
                        };
                        listResult.Add(result);
                    }
                }
                var response = listResult.OrderBy(x =>
                {
                    DateTime dateResult;
                    if (DateTime.TryParseExact(x.DateLearn, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateResult))
                    {
                        return dateResult;
                    }
                    else
                    {
                        // Handle invalid date (e.g., return a default value or log it)
                        return DateTime.MinValue;
                    }
                })
                               .ThenBy(x => x.TimeStart)
                               .ToList(); return response;
            }
            return null;
        }


        /*
        public async Task UpdateStudent(UpdateStudentCommand student)
        {
            try {
                var studentExist = await dbContext.Students
                .Where(s => s.Id == Guid.Parse(student.StudentId) && !s.IsDeleted)
                .SingleOrDefaultAsync();
                if (studentExist == null) {
                    throw new NotFoundException("StudentId does not exist to update");
                }
                studentExist.Name = student.Name;
                studentExist.Address = student.Address;
                studentExist.Birthday = student.Birthday;
                studentExist.ParentId = Guid.Parse(student.ParentID);

                dbContext.Students.Update(studentExist);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task DeleteStudent(DeleteStudentCommand student)
        {
            try {
                var studentExist = await dbContext.Students
                .Where(s => s.Id == Guid.Parse(student.StudentId) && !s.IsDeleted)
                .SingleOrDefaultAsync();
                if (studentExist == null) {
                    throw new NotFoundException("StudentId does not exist to delete");
                }
                studentExist.IsDeleted = true;

                dbContext.Students.Update(studentExist);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<List<Student>> GetAllStudent()
        {
            try {
                var studentList = await dbContext.Students
                .Where(s => !s.IsDeleted)
                .ToListAsync();
                
                return studentList;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<Student> GetStudentById(string student)
        {
            try {
                var studentExist = await dbContext.Students
                .Where(s => s.Id == Guid.Parse(student) && !s.IsDeleted)
                .SingleOrDefaultAsync();
                if (studentExist == null) {
                    throw new NotFoundException("Student Id does not existed");
                }

                return studentExist;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }*/
        public async Task<List<StudentDTO>> GetAllStudent()
        {
            var listResult = new List<StudentDTO>();
            var listAppUserStudent = _dbContext.AppUsers.ToList();
            foreach (var item in listAppUserStudent)
            {
                //Check coi nó có là account student hay không
                var s = _dbContext.Students.Where(x => x.AppUserId == item.Id && !x.IsDeleted).FirstOrDefault();
                if (s != null)
                {
                    var response = new StudentDTO();
                    var appUserStudent = _dbContext.AppUsers.Where(x => x.Id == s.AppUserId).FirstOrDefault();
                    if (appUserStudent != null)
                    {
                        var student = new StudentDTO()
                        {
                            StudentId = s.Id,
                            Address = appUserStudent.Address,
                            DateOfBirth = appUserStudent.DateOfBirth,
                            Email = appUserStudent.Email,
                            FullName = appUserStudent.FullName,
                            Gender = appUserStudent.Gender,
                            PhoneNumber = appUserStudent.PhoneNumber,
                            PhotoUrl = appUserStudent.PhotoUrl,
                            UserName = appUserStudent.UserName,
                        };
                        var parent = _dbContext.Parents.Where(x => x.Id == s.ParentId).FirstOrDefault();
                        if (parent != null)
                        {
                            var appUserParent = _dbContext.AppUsers.Where(x => x.Id == parent.AppUserId).FirstOrDefault();
                            if (parent != null && appUserParent != null)
                            {
                                student.Parent = new ParentDTO()
                                {
                                    Address = appUserParent.Address,
                                    DateOfBirth = appUserParent.DateOfBirth,
                                    Email = appUserParent.Email,
                                    FullName = appUserParent.FullName,
                                    Gender = appUserParent.Gender,
                                    ParentId = parent.Id,
                                    PhoneNumber = appUserParent.PhoneNumber,
                                    PhotoUrl = appUserParent.PhotoUrl,
                                    UserName = appUserParent.UserName,
                                };
                            }
                        }
                        response = student;
                        listResult.Add(response);
                    }
                }
            }
            return listResult;
        }
        public Task<StudentDTO> GetStudentByStudentId(Guid studentId)
        {
            // Ưu tiên dùng Name
            var response = new StudentDTO();
            var s = _dbContext.Students.Where(x => x.Id == studentId && !x.IsDeleted).FirstOrDefault();
            if (s != null)
            {
                var appUserStudent = _dbContext.AppUsers.Where(x => x.Id == s.AppUserId).FirstOrDefault();
                if (appUserStudent != null)
                {
                    var student = new StudentDTO()
                    {
                        StudentId = s.Id,
                        Address = appUserStudent.Address,
                        DateOfBirth = appUserStudent.DateOfBirth,
                        Email = appUserStudent.Email,
                        FullName = appUserStudent.FullName,
                        Gender = appUserStudent.Gender,
                        PhoneNumber = appUserStudent.PhoneNumber,
                        PhotoUrl = appUserStudent.PhotoUrl,
                        UserName = appUserStudent.UserName,
                    };
                    var parent = _dbContext.Parents.Where(x => x.Id == s.ParentId).FirstOrDefault();
                    if (parent != null)
                    {
                        var appUserParent = _dbContext.AppUsers.Where(x => x.Id == parent.AppUserId).FirstOrDefault();
                        if (parent != null && appUserParent != null)
                        {
                            student.Parent = new ParentDTO()
                            {
                                Address = appUserParent.Address,
                                DateOfBirth = appUserParent.DateOfBirth,
                                Email = appUserParent.Email,
                                FullName = appUserParent.FullName,
                                Gender = appUserParent.Gender,
                                ParentId = parent.Id,
                                PhoneNumber = appUserParent.PhoneNumber,
                                PhotoUrl = appUserParent.PhotoUrl,
                                UserName = appUserParent.UserName,
                            };
                        }
                    }
                    response = student;
                }
            }
            return Task.FromResult(response);
        }

        public Task<StudentDTO> GetStudentByAppUserId(Guid appUserId)
        {
            // Ưu tiên dùng Name
            var response = new StudentDTO();
            var s = _dbContext.Students.Where(x => x.AppUserId == appUserId && !x.IsDeleted).FirstOrDefault();
            if (s != null)
            {
                var appUserStudent = _dbContext.AppUsers.Where(x => x.Id == s.AppUserId).FirstOrDefault();
                if (appUserStudent != null)
                {
                    var student = new StudentDTO()
                    {
                        StudentId = s.Id,
                        Address = appUserStudent.Address,
                        DateOfBirth = appUserStudent.DateOfBirth,
                        Email = appUserStudent.Email,
                        FullName = appUserStudent.FullName,
                        Gender = appUserStudent.Gender,
                        PhoneNumber = appUserStudent.PhoneNumber,
                        PhotoUrl = appUserStudent.PhotoUrl,
                        UserName = appUserStudent.UserName,
                    };
                    var parent = _dbContext.Parents.Where(x => x.Id == s.ParentId).FirstOrDefault();
                    if (parent != null)
                    {
                        var appUserParent = _dbContext.AppUsers.Where(x => x.Id == parent.AppUserId).FirstOrDefault();
                        if (parent != null && appUserParent != null)
                        {
                            student.Parent = new ParentDTO()
                            {
                                Address = appUserParent.Address,
                                DateOfBirth = appUserParent.DateOfBirth,
                                Email = appUserParent.Email,
                                FullName = appUserParent.FullName,
                                Gender = appUserParent.Gender,
                                ParentId = parent.Id,
                                PhoneNumber = appUserParent.PhoneNumber,
                                PhotoUrl = appUserParent.PhotoUrl,
                                UserName = appUserParent.UserName,
                            };
                        }
                    }
                    response = student;
                }
            }
            return Task.FromResult(response);
        }
        public Task<List<StudentDTO>> GetStudentByStudentName(string studentName)
        {
            var listResult = new List<StudentDTO>();
            var listAppUserStudent = _dbContext.AppUsers.Where(x => x.FullName.ToLower().Trim().Contains(studentName.ToLower().Trim())).ToList();
            foreach (var item in listAppUserStudent)
            {
                //Check coi nó có là account student hay không
                var s = _dbContext.Students.Where(x => x.AppUserId == item.Id && !x.IsDeleted).FirstOrDefault();
                if (s != null)
                {
                    var response = new StudentDTO();
                    var appUserStudent = _dbContext.AppUsers.Where(x => x.Id == s.AppUserId).FirstOrDefault();
                    if (appUserStudent != null)
                    {
                        var student = new StudentDTO()
                        {
                            StudentId = s.Id,
                            Address = appUserStudent.Address,
                            DateOfBirth = appUserStudent.DateOfBirth,
                            Email = appUserStudent.Email,
                            FullName = appUserStudent.FullName,
                            Gender = appUserStudent.Gender,
                            PhoneNumber = appUserStudent.PhoneNumber,
                            PhotoUrl = appUserStudent.PhotoUrl,
                            UserName = appUserStudent.UserName,
                        };
                        var parent = _dbContext.Parents.Where(x => x.Id == s.ParentId).FirstOrDefault();
                        if (parent != null)
                        {
                            var appUserParent = _dbContext.AppUsers.Where(x => x.Id == parent.AppUserId).FirstOrDefault();
                            if (parent != null && appUserParent != null)
                            {
                                student.Parent = new ParentDTO()
                                {
                                    Address = appUserParent.Address,
                                    DateOfBirth = appUserParent.DateOfBirth,
                                    Email = appUserParent.Email,
                                    FullName = appUserParent.FullName,
                                    Gender = appUserParent.Gender,
                                    ParentId = parent.Id,
                                    PhoneNumber = appUserParent.PhoneNumber,
                                    PhotoUrl = appUserParent.PhotoUrl,
                                    UserName = appUserParent.UserName,
                                };
                            }
                        }
                        response = student;
                        listResult.Add(response);
                    }
                }
            }
            return Task.FromResult(listResult);
        }

        public async Task<List<GetStudentGrade>> GetListGradeByStudentId(Guid studentId)
        {
            var studentGrades = new List<GetStudentGrade>();

            // Lấy danh sách lớp học của sinh viên
            var classesOfStudentId = await _dbContext.Classes
                .Include(c => c.Subject)
                .Include(c => c.Student)
                    .ThenInclude(s => s.AppUser)
                .Where(c => c.StudentId == studentId)
                .ToListAsync();

            foreach (var classs in classesOfStudentId)
            {
                var studentGradeDTO = new GetStudentGrade
                {
                    StudentName = classs.Student.AppUser.UserName,
                    ClassName = classs.ClassName,
                    SubjectName = classs.Subject.SubjectName,
                    Grades = new List<Dictionary<string, double>>() // Khởi tạo danh sách Grade Dictionary cho mỗi lớp học
                };

                // Lấy tất cả các điểm của sinh viên trong lớp học đó
                var gradesInClass = await _dbContext.StudentGrades
                    .Where(sg => sg.ClassId == classs.Id)
                    .ToListAsync();

                // Tạo đối tượng Grade Dictionary cho mỗi điểm số
                foreach (var grade in gradesInClass)
                {
                    var gradeDictionary = new Dictionary<string, double>
                    {
                        { grade.AssesessmentType, grade.Grade }
                    };
                    studentGradeDTO.Grades.Add(gradeDictionary); // Thêm Grade Dictionary vào danh sách Grades của môn học
                }

                studentGrades.Add(studentGradeDTO);
            }
            return studentGrades;
        }


        public async Task<List<GetStudentAttendance>> GetAttendanceByStudentId(Guid studentId)
        {
            var attendanceList = await _dbContext.Attendance
                .Include(a => a.ClassSchedule)
                    .ThenInclude(cs => cs.Class)
                .Where(a => a.ClassSchedule.Class.StudentId == studentId)
                .Select(a => new GetStudentAttendance
                {
                    DateStudy = a.ClassSchedule.DateStudy,
                    AttendStatus = a.AttendStatus,
                    Description = a.Description
                })
                .ToListAsync();

            return attendanceList;
        }

    }
}
