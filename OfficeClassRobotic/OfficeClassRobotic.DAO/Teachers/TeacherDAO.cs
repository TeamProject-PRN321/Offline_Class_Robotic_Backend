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
        /// Create Teacher With List Subject (If have)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        public async Task CreateTeacher(CreateTeacherDTO request)
        {
            if (request.ListSubjectId != null && request.ListSubjectId.Any())
            {
                var checkExistSubject = _dbContext.Subjects.Where(x => !request.ListSubjectId.Contains(x.Id) || (request.ListSubjectId.Contains(x.Id) && x.IsDeleted));
                if (checkExistSubject.Any())
                {
                    throw new NotFoundException(ClassRoboticMessage.DoesNotExistOrHaveBeenDeleted);
                }
            }

            //Add Teacher
            var teacher = new Teacher()
            {
                Address = request.Address,
                Birthday = request.Birthday,
/*                Certification = request.Certification,
                Major = request.Major,*/
                Name = request.Name,
            };
            _dbContext.Teacher.Add(teacher);

            if (request.ListSubjectId != null && request.ListSubjectId.Any())
            {
                //Add Teacher Subject
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
            await _dbContext.SaveChangesAsync();
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
                teacher.Birthday = request.Birthday;
                //teacher.Major = request.Major;
                teacher.Address = request.Address;
               // teacher.Certification = request.Certification;
                teacher.Name = request.Name;
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
            var listTeacher = _dbContext.Teacher.Where(x => x.IsDeleted).Include(x => x.TeacherSubjects).ToList();
            if (listResult != null)
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
                    var result = new TeacherDTO()
                    {
                        ListSubjectOfTeacher = listSubjectOfTeacher,
                        Address = teacher.Address,
                        Birthday = teacher.Birthday,
                   /*     Certification = teacher.Certification,
                        Major = teacher.Major,*/
                        Name = teacher.Name,
                        TeacherId = teacher.Id
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
                Address = teacher.Address,
                Birthday = teacher.Birthday,
             //   Certification = teacher.Certification,
                ListSubjectOfTeacher = listTeacherSubject,
               // Major = teacher.Major,
                Name = teacher.Name,
                TeacherId = teacher.Id
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
    }
}
