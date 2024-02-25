using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;

namespace OfficeClassRobotic.DAO.Subjects
{
    public class SubjectDAO
    {
        private static SubjectDAO instance = null;
        private static ApplicationDBContext dBContext = null;

        public SubjectDAO()
        {
            dBContext = new ApplicationDBContext();
        }

        public static SubjectDAO Instance
        {
            get
            {
                if (instance == null) {
                    instance = new SubjectDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public async Task CreateSubject(SubjectData request)
        {
            var checkExist = await dBContext.Subjects.Where(x => x.SubjectName == request.SubjectName).FirstOrDefaultAsync();
            if(checkExist != null)
            {
                throw new BadRequestException($"Subject has been existed!");
            }
            var giaoTrinh = new GiaoTrinh
            {
                GiaoTrinhName = request.GiaoTrinhDTO.GiaoTrinhName,
                Description = request.GiaoTrinhDTO.Description,
                FilePDF = request.GiaoTrinhDTO.FilePDF,
            };
            dBContext.GiaoTrinhs.Add(giaoTrinh);
            var newSubject = new Subject
            {
                SubjectName = request.SubjectName,
                TotalSlots = request.TotalSlots,
                GiaoTrinhId = giaoTrinh.Id,
            };
            dBContext.Subjects.Add(newSubject);
            await dBContext.SaveChangesAsync();
        }

        public async Task CreateSubjectForListStudentWithGiaoTrinh(SubjectDTO subject)
        {
            try {
                // new giaoTrinh
                var giaoTrinh = new GiaoTrinh
                {
                    GiaoTrinhName = subject.GiaoTrinhDTO.GiaoTrinhName,
                    Description = subject.GiaoTrinhDTO.Description,
                    FilePDF = subject.GiaoTrinhDTO.FilePDF,
                };
                dBContext.GiaoTrinhs.Add(giaoTrinh);

                // check studentId into Subject
                var studentList = subject.StudentList.Select(s => s.StudentID).ToList();
                var studentExistWithSubject = await dBContext.Students
                    .Where(s => studentList.Contains(s.Id.ToString()) && !s.IsDeleted)
                    .ToListAsync();
                if (studentExistWithSubject.Count() == 0) {
                    throw new BadRequestException($"StudentId:  doesn't existed");
                }
                var newSubject = new Subject
                {
                    SubjectName = subject.SubjectName,
                    TotalSlots = subject.TotalSlots,
                    GiaoTrinhId = giaoTrinh.Id,
                };
                dBContext.Subjects.Add(newSubject);

                foreach (var student in studentExistWithSubject) {
                    var newListStudentForSubject = new StudentSubject
                    {
                        SubjectId = newSubject.Id,
                        StudentId = student.Id,
                    };
                    dBContext.StudentSubject.Add(newListStudentForSubject);
                }
                await dBContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.ToString());
            }
        }

        public async Task UpdateSubjectWithListStudent(UpdateSubjectDTO request)
        {
            try {
                var subjectExist = await dBContext.Subjects
                    .Where(s => s.Id == Guid.Parse(request.SubjectId) && !s.IsDeleted)
                    .SingleOrDefaultAsync();
                if (subjectExist == null) {
                    throw new NotFoundException($"Does not existed subjectId: {request.SubjectId}");
                }
                subjectExist.SubjectName = request.SubjectName;
                subjectExist.TotalSlots = request.TotalSlots;
                subjectExist.GiaoTrinhId = Guid.Parse(request.GiaoTrinhId);
                dBContext.Update(subjectExist);

                var studentList = request.StudentList.Select(s => s.StudentID).ToList();
                foreach (var student in studentList) {
                    var studentExist = await dBContext.Students.Where(s => s.Id == Guid.Parse(student) && !s.IsDeleted).SingleOrDefaultAsync();
                    if (studentExist == null) {
                        throw new NotFoundException($"StudentId: {student} does not existed");
                    }
                    
                }

                await dBContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.ToString());
            }
        }
    }
}
