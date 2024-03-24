using OfficeClassRobotic.DAO.Classess;
using OfficeClassRobotic.DAO.Classrooms;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;

namespace OfficeClassRobotic.Repository.Classess
{
    public interface IClassRepository 
    {
        public Task<ClassRoboticResponse> CreateClass(CreateClassesCommand request);
        public Task<CheckDataResponse> CheckSchedularTeacher(CheckData request);
        public Task<List<ClassDTO>> GetAllClassesAreNotFinished();
        public Task<ClassRoboticResponse> UpdateClass(ClassDTO request);
        public Task<ClassRoboticResponse> DeleteClass(ClassDTO request);
        public Task<StudentsOfClassesResponse> GetListStudentOfClassByClassName(string className);
        public Task<List<GetClassAndGradeByStudentId>> GetListClassByStudentId(Guid request);
        public Task<ClassDataResponse> GetClassOfStudentByIdAndClassname(string appUserId, string classname);

    }
}
