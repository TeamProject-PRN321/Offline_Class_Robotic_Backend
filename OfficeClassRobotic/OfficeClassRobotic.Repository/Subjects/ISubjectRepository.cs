using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Subjects;

namespace OfficeClassRobotic.Repository.GiaoTrinhForSubject
{
    public interface ISubjectRepository
    {
        public Task<ClassRoboticResponse> CreateSubjectForListStudentWithGiaoTrinh(SubjectDTO subject);
        public Task<ClassRoboticResponse> UpdateSubjectWithListStudent(UpdateSubjectDTO subject);
        public Task<ClassRoboticResponse> CreateSubject(SubjectData request);
    }
}
