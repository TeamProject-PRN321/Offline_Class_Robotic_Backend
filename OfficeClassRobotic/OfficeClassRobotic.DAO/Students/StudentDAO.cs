﻿using Microsoft.EntityFrameworkCore;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using System.Globalization;

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
                if (instance == null)
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

        public async Task CreateStudent(CreateStudentCommand student)
        {
            try {
                var parentExist = await dbContext.Parents.Where(p => p.Id == Guid.Parse(student.ParentID) && !p.IsDeleted).SingleOrDefaultAsync();
                if(parentExist == null) {
                    throw new NotFoundException("Parent doesn't existed");
                }
                var studentExist = await dbContext.Students
                .Where(s => s.Name == student.Name && s.ParentId == Guid.Parse(student.ParentID))
                .SingleOrDefaultAsync();
                if (studentExist != null) {
                    throw new BadRequestException("Student is existed");
                }
                var newStudent = new Student
                {
                    Name = student.Name,
                    Address = student.Address,
                    Birthday = student.Birthday,
                    ParentId = Guid.Parse(student.ParentID)
                };

                dbContext.Students.Add(newStudent);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

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
    }
}
