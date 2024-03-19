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

        public async Task CreateSubject(CreateSubjectCommand request)
        {
            try {
                var checkExist = await dBContext.Subjects.Where(x => x.SubjectName == request.SubjectName && !x.IsDeleted).FirstOrDefaultAsync();
                if (checkExist != null) {
                    throw new BadRequestException($"Subject has been existed!");
                }
                var newSubject = new Subject
                {
                    SubjectName = request.SubjectName,
                    TotalSlots = request.TotalSlots,
                };
                dBContext.Subjects.Add(newSubject);
                await dBContext.SaveChangesAsync();
                // để đây từ từ sửa, 1 môn học sẽ tạo với 1 list giáo trình, ok
                var giaoTrinh = new GiaoTrinh
                {
                    GiaoTrinhName = request.GiaoTrinhDTO.GiaoTrinhName,
                    Description = request.GiaoTrinhDTO.Description,
                    //FilePDF = request.GiaoTrinhDTO.FilePDF,
                    SubjectId = newSubject.Id
                };
                dBContext.GiaoTrinhs.Add(giaoTrinh);
                
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task UpdateSubject(UpdateSubjectCommand request)
        {
            try {
                var checkSubjectExist = await dBContext.Subjects
                .Where(s => s.Id == Guid.Parse(request.SubjectId) && !s.IsDeleted)
                .SingleOrDefaultAsync();
                if (checkSubjectExist == null) {
                    throw new NotFoundException("Does not exist SubjectId");
                }
                checkSubjectExist.SubjectName = request.SubjectName;
                checkSubjectExist.TotalSlots = request.TotalSlots;
                dBContext.Subjects.Update(checkSubjectExist);
                await dBContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task DeleteSubject(DeleteSubjectCommand request)
        {
            try {
                var checkSubjectExist = await dBContext.Subjects
                            .Where(s => s.Id == Guid.Parse(request.SubjectId) && !s.IsDeleted)
                            .SingleOrDefaultAsync();
                if (checkSubjectExist == null) {
                    throw new NotFoundException("Does not exist SubjectId");
                }
                checkSubjectExist.IsDeleted = true;
                dBContext.Subjects.Update(checkSubjectExist);
                await dBContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<List<Subject>> GetAllSubject()
        {
            try {
                var subjectList = await dBContext.Subjects.Where(g => !g.IsDeleted).ToListAsync();
                return subjectList;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<GiaoTrinh> GetGiaoTrinhById(Guid giaoTrinhId)
        {
            try {
                var giaoTrinhExist = await dBContext.GiaoTrinhs
                    .Where(g => g.Id == giaoTrinhId && !g.IsDeleted)
                    .SingleOrDefaultAsync();
                if (giaoTrinhExist == null) {
                    throw new NotFoundException("Does not existed giaoTrinhId");
                }
                return giaoTrinhExist;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<Subject> GetSubjectById(string subjectId)
        {
            try {
                var subjectExist = await dBContext.Subjects
                    .Where(g => g.Id == Guid.Parse(subjectId) && !g.IsDeleted)
                    .SingleOrDefaultAsync();
                if (subjectExist == null) {
                    throw new NotFoundException("Does not existed subjectId");
                }
                return subjectExist;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
