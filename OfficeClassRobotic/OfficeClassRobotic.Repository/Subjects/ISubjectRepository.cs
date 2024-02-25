using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.GiaoTrinhs;
using OfficeClassRobotic.DAO.Subjects;

namespace OfficeClassRobotic.Repository.GiaoTrinhForSubject
{
    public interface ISubjectRepository
    {
        public Task<ClassRoboticResponse> CreateSubject(CreateSubjectCommand subject);
        public Task<ClassRoboticResponse> UpdateSubject(UpdateSubjectCommand subject);
        public Task<ClassRoboticResponse> DeleteSubject(DeleteSubjectCommand subject);
        public Task<List<SubjectResponse>> GetAllSubject();
        public Task<SubjectResponse> GetSubjectById(string subjectId);
    }
}
