using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Subjects;
using OfficeClassRobotic.DAO.Teachers;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OfficeClassRobotic.DAO.Classess
{
    public class ClassDAO
    {
        private static ClassDAO instance = null;
        private static ApplicationDBContext dBContext = null;

        public ClassDAO()
        {
            dBContext = new ApplicationDBContext();
        }

        public static ClassDAO Instance
        {
            get
            {
                if (instance == null) {
                    instance = new ClassDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        #region private function date
        private static string ConvertDayOfWeekToString(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    return "Chủ Nhật";
                case DayOfWeek.Monday:
                    return "Thứ 2";
                case DayOfWeek.Tuesday:
                    return "Thứ 3";
                case DayOfWeek.Wednesday:
                    return "Thứ 4";
                case DayOfWeek.Thursday:
                    return "Thứ 5";
                case DayOfWeek.Friday:
                    return "Thứ 6";
                case DayOfWeek.Saturday:
                    return "Thứ 7";
                default:
                    return "";
            }
        }

        private static DayOfWeek ConvertDayOfWeek(string day)
        {
            switch (day) {
                case "Chủ Nhật":
                    return DayOfWeek.Sunday;
                case "Thứ 2":
                    return DayOfWeek.Monday;
                case "Thứ 3":
                    return DayOfWeek.Tuesday;
                case "Thứ 4":
                    return DayOfWeek.Wednesday;
                case "Thứ 5":
                    return DayOfWeek.Thursday;
                case "Thứ 6":
                    return DayOfWeek.Friday;
                case "Thứ 7":
                    return DayOfWeek.Saturday;
                default:
                    throw new ArgumentException("Ngày không hợp lệ");
            }
        }
        #endregion
        /// <summary>
        /// Hàm này dùng để check xem còn trống giờ đó với lịch đó ko, và response ra, để lấy được thông tin và apply cho create class
        /// Để tạo lớp học, sẽ dùng thời gian, ngày học check thời khóa biểu coi có trống chưa, coi phòng học nào còn trống
        /// kiểm tra coi giao viên của bộ môn đó còn bao nhiêu người còn trống slot đó
        /// </summary>
        /// <returns></returns>
        public async Task<CheckDataResponse> CheckSchedularTeacher(CheckData request)
        {
            try {
                #region endDate
                var subject = await dBContext.Subjects
                    .Where(s => s.Id == Guid.Parse(request.SubjectId) && !s.IsDeleted)
                    .SingleOrDefaultAsync();
                if (subject == null) {
                    throw new NotFoundException("SubjectId not found");
                }
                var slots = subject.TotalSlots;
                var daysOfWeekNumber = request.DayStudy.Count;
                var week = slots / daysOfWeekNumber;
                var remaining = slots % daysOfWeekNumber;
                var dateEndStudy = request.DateStudy;

                var dayOfWeek = request.DayStudy;
                var days = dayOfWeek.Select(ConvertDayOfWeek).ToList();
                days.Sort();
                var sortedDayOfWeek = days.Select(day => ConvertDayOfWeekToString(day)).ToList();

                for (int i = 0; i < 7 * week; i++) {
                    dateEndStudy = dateEndStudy.AddDays(1);
                }
                while (remaining > 0) {
                    dateEndStudy = dateEndStudy.AddDays(1);
                    if (sortedDayOfWeek.Contains(ConvertDayOfWeekToString(dateEndStudy.DayOfWeek))) {
                        remaining--;
                    }
                }
                #endregion
                #region List Day of StartDay and EndDate
                var listDayStudy = new List<DateOnly>();
                for (var date = request.DateStudy; date <= dateEndStudy; date = date.AddDays(1)) {
                    if (sortedDayOfWeek.Contains(ConvertDayOfWeekToString(dateEndStudy.DayOfWeek))) {
                        listDayStudy.Add(date);
                    }
                }
                #endregion
                #region get teacher of subjectId empty slot
                // get all giáo viên bộ môn này
                var teachers = await dBContext.TeacherSubjects
                    .Where(s => s.SubjectId == Guid.Parse(request.SubjectId) && !s.IsDeleted)
                    .ToListAsync();
                if (teachers == null) {
                    throw new NotFoundException("Chưa có teacher nào được tạo với môn học này, bạn hãy tạo đi");
                }
                // check list giáo viên bộ môn này với thời gian, ngày, coi có lịch chưa. Có rồi thì hiển thị, chưa có thi bo qua
                var teacherExistSchedular = new List<TeacherDataResponse>();
                var schedularListEmptySlot = new List<ClassSchedule>();
                var schedularListHaveSlot = new List<ClassSchedule>();
                var seenIds = new HashSet<Guid>();
                var teacherSchedules = new List<DateFreeTime>();
                var teacherSchedulesDictionary = new Dictionary<Guid, List<DateFreeTime>>();
                foreach (var teacher in teachers) {
                    if (!teacherSchedulesDictionary.ContainsKey(teacher.TeacherId)) {
                        teacherSchedulesDictionary[teacher.TeacherId] = new List<DateFreeTime>();
                    }
                    var teacherFreeTime = teacherSchedulesDictionary[teacher.TeacherId];
                    foreach (var dateStudy in listDayStudy) {
                        var schedulars = await dBContext.ClassSchedule
                            .Where(cs => cs.TeacherId == teacher.TeacherId
                                        && cs.DateStudy.Year == dateStudy.Year
                                        && cs.DateStudy.Month == dateStudy.Month
                                        && cs.DateStudy.Day == dateStudy.Day
                                        && !cs.IsDeleted)
                            .ToListAsync();
                        // TH taecher chưa có lịch dạy, lấy thông tin của teacher, lấy ngày add thành 1 list
                        if (schedulars.Count == 0) {
                            teacherFreeTime.Add(new DateFreeTime { Date = dateStudy });
                        }
                        else {
                            foreach (var schedular in schedulars) {
                                var startTimeOfClass = await dBContext.Classes
                                    .Where(c => c.Id == schedular.ClassId &&
                                            (
                                                (c.StartTime == request.StartTime && c.EndTime == request.EndTime) ||
                                                (c.StartTime > request.StartTime && c.StartTime < request.EndTime) ||
                                                (c.EndTime > request.StartTime && c.EndTime < request.EndTime) ||
                                                (c.StartTime < request.StartTime && c.EndTime > request.EndTime) ||
                                                (c.StartTime > request.StartTime && c.EndTime < request.EndTime)
                                            ) && !c.IsDeleted)
                                    .SingleOrDefaultAsync();
                                // teacher này trống slot cho ngày hôm nay
                                if (startTimeOfClass == null && !teacherFreeTime.Any(ft => ft.Date == dateStudy)) {
                                    schedularListEmptySlot.Add(schedular);
                                    teacherFreeTime.Add(new DateFreeTime { Date = dateStudy });
                                }
                                // teacher có slot cho ngày hôm nay, để dành nếu muốn hiện ngày làm việc thì code tiếp chỗ này
                                else {
                                    schedularListHaveSlot.Add(schedular);
                                }
                            }
                        }
                    }
                    teacherSchedulesDictionary[teacher.TeacherId] = teacherFreeTime;
                }

                foreach (var kvp in teacherSchedulesDictionary) {
                    var teacherId = kvp.Key;
                    var teacherFreeTime = kvp.Value;
                    var teacherExistResponse = await dBContext.Teacher
                                .Where(t => t.Id == teacherId && !t.IsDeleted)
                                .SingleOrDefaultAsync();
                    if (teacherExistResponse == null) {
                        throw new NotFoundException("Error at teacherExistResponse no have teacherId");
                    }
                    var appUser = await dBContext.AppUsers
                        .Where(a => a.Id == teacherExistResponse.AppUserId)
                        .SingleOrDefaultAsync();
                    if (appUser == null) {
                        throw new NotFoundException("Error at appUser no have AppUserId");
                    }

                    var teacherApp = new TeacherDataResponse
                    {
                        Id = teacherExistResponse.Id,
                        AppUserId = teacherExistResponse.AppUserId,
                        FullName = appUser.FullName,
                        Email = appUser.Email,
                        PhoneNumber = appUser.PhoneNumber,
                        PhotoUrl = appUser.PhotoUrl,
                        ListDateFreeTime = teacherFreeTime
                    };
                    teacherExistSchedular.Add(teacherApp);
                }
                #endregion
                #region logic cho schedularListEmptySlot cmt
                // duyệt cái list trống slot để lấy thông tin teacher ra
                /*foreach (var emptySlot in schedularListEmptySlot) {
                    if (!seenIds.Contains(emptySlot.TeacherId)) {
                        var teacherExistResponse = await dBContext.Teacher
                        .Where(t => t.Id == emptySlot.TeacherId && !t.IsDeleted)
                        .SingleOrDefaultAsync();
                        var appUser = await dBContext.AppUsers
                            .Where(a => a.Id == teacherExistResponse.AppUserId)
                            .SingleOrDefaultAsync();

                        var freeTime = new List<DateFreeTime>();
                        foreach (var schedular in schedularListEmptySlot.Where(s => s.TeacherId == emptySlot.TeacherId && !s.IsDeleted)) {
                            teacherSchedules.Add(
                                new DateFreeTime
                                {
                                    Date = DateOnly.FromDateTime(schedular.DateStudy)
                                });
                        }
                        var teacherApp = new TeacherDataResponse
                        {
                            Id = teacherExistResponse.Id,
                            AppUserId = teacherExistResponse.AppUserId,
                            FullName = appUser.FullName,
                            Email = appUser.Email,
                            PhoneNumber = appUser.PhoneNumber,
                            PhotoUrl = appUser.PhotoUrl,
                            ListDateFreeTime = teacherSchedules
                        };
                        teacherExistSchedular.Add(teacherApp);

                        seenIds.Add(teacherExistResponse.Id);
                    }
                }*/
                #endregion
                #region logic find Room
                var availableClassroom = new List<DateFreeTimeForRoom>();
                HashSet<DateOnly> processedDates = new HashSet<DateOnly>();
                var getAllRoom = await dBContext.Classrooms.Where(c => !c.IsDeleted).ToListAsync();
                foreach (var dateStudy in listDayStudy) {
                    var date = dateStudy;
                    var schedulars = await dBContext.ClassSchedule
                            .Where(cs => cs.DateStudy.Year == dateStudy.Year
                                        && cs.DateStudy.Month == dateStudy.Month
                                        && cs.DateStudy.Day == dateStudy.Day
                                        && !cs.IsDeleted)
                            .ToListAsync();
                    // ngày này tất cả room còn trống
                    if (schedulars.Count == 0) {
                        if (processedDates.Add(dateStudy)) {
                            var availableRooms = new List<ClassRoomDataResponse>();
                            foreach (var room in getAllRoom) {
                                var addRoom = new ClassRoomDataResponse
                                {
                                    Id = room.Id,
                                    ClassRoomName = room.ClassRoomName,
                                    Description = room.Description,
                                    TrungTamRoboticId = room.TrungTamRoboticId,
                                };
                                availableRooms.Add(addRoom);
                            }
                            availableClassroom.Add(new DateFreeTimeForRoom
                            {
                                Date = dateStudy,
                                ClassRoomData = availableRooms
                            });
                        }

                    }
                    // ngày này có sài room , duyệt tiếp thời gian để xác định room số mấy
                    else {
                        // phòng đang sử dụng
                        var occupiedRooms = new List<ClassRoomDataResponse>();
                        var availableRooms = new List<ClassRoomDataResponse>();
                        foreach (var schedular in schedulars) {
                            var startTimeOfClass = await dBContext.Classes
                                .Where(c => c.Id == schedular.ClassId &&
                                        (
                                            (c.StartTime == request.StartTime && c.EndTime == request.EndTime) ||
                                            (c.StartTime > request.StartTime && c.StartTime < request.EndTime) ||
                                            (c.EndTime > request.StartTime && c.EndTime < request.EndTime) ||
                                            (c.StartTime < request.StartTime && c.EndTime > request.EndTime) ||
                                            (c.StartTime > request.StartTime && c.EndTime < request.EndTime)
                                        )
                                        && !c.IsDeleted)
                                .SingleOrDefaultAsync();
                            // slot này đã những có room, lấy những room còn trống
                            if (startTimeOfClass != null) {
                                // check làm sao để lấy được danh sách các room còn trống đây
                                // tương tự trong cái list này sẽ còn nhiều room khác đang sử dụng,
                                // add thành 1 list room đang sử dụng cho ngày hôm nay
                                // và add 1 list room còn trong cho ngày hôm nay tương ứng
                                var room = await dBContext.Classrooms
                                                    .Where(cr => cr.Id == schedular.ClassRoomID && !cr.IsDeleted)
                                                    .SingleOrDefaultAsync();
                                if (room != null) {
                                    occupiedRooms.Add(new ClassRoomDataResponse
                                    {
                                        Id = room.Id,
                                        ClassRoomName = room.ClassRoomName,
                                        Description = room.Description,
                                        TrungTamRoboticId = room.TrungTamRoboticId
                                    });
                                }
                            }
                        }
                        availableRooms = getAllRoom
                                                    .Where(room => !occupiedRooms.Any(occupiedRoom => occupiedRoom.Id == room.Id))
                                                    .Select(room => new ClassRoomDataResponse
                                                    {
                                                        Id = room.Id,
                                                        ClassRoomName = room.ClassRoomName,
                                                        Description = room.Description,
                                                        TrungTamRoboticId = room.TrungTamRoboticId
                                                    })
                                                    .ToList();

                        availableClassroom.Add(new DateFreeTimeForRoom
                        {
                            Date = dateStudy,
                            ClassRoomData = availableRooms
                        });
                    }
                }
                #endregion
                // đối với gv, thì hiện những giáo viên chưa có lịch dạy rồi
                // , còn room thì hiện những room còn trống
                var response = new CheckDataResponse
                {
                    SubjectId = subject.Id,
                    SubjectName = subject.SubjectName,
                    TotalSlots = subject.TotalSlots,
                    Message = $"Danh sách các giáo viên chưa có lịch dạy và các phòng còn trống từ ngày {request.DateStudy} đến {dateEndStudy}",
                    TeacherData = teacherExistSchedular,
                    DateFreeTimeForRoomData = availableClassroom
                };

                return response;
            }
            catch(Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        /// <summary>
        /// Bên cạnh tạo lớp học cho 1 list sinh viên đó, thì lịch học cũng sẽ đồng thời được tạo theo
        /// Lớp học sẽ gồm, ngày học và thời gian bắt đầu với kết thúc, với 1 list sinh viên được add vào
        /// tiếp theo sẽ tự động generate ra thời khóa biểu, Còn phòng học sẽ được nhà trường Update, sắp xếp
        /// sau cho khóa học và giáo viên cũng sẽ được chọn sau luôn
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task CreateClassess(CreateClassesCommand request)
        {
            var studentIds = request.StudentListId.Select(s => s.StudentId).ToList();
            foreach (var studentId in studentIds) {
                var classess = new Class
                {
                    ClassName = request.ClassName,
                    DayStudy = request.DayStudy,
                    StartTime = null,
                    EndTime = null,
                    StudentId = Guid.Parse(studentId),
                    SubjectId = Guid.Parse(request.SubjectId),
                };
                dBContext.Classes.Add(classess);

                var classSchedular = new ClassSchedule
                {
                    DateStudy = DateTime.Now,
                    NumberOfSudent = studentIds.Count,
                    ClassId = classess.Id,
                    TeacherId = Guid.Parse(request.TeacherId),
                    ClassRoomID = Guid.Parse(request.ClassRoomID)
                };
                dBContext.ClassSchedule.Add(classSchedular);
            }
            await dBContext.SaveChangesAsync();
        }
    }
}
