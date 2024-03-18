using OfficeClassRobotic.DAO.Classess;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;

namespace OfficeClassRobotic.Repository.Classess
{
    public interface IClassRepository 
    {
        public Task<ClassRoboticResponse> CreateClass(CreateClassesCommand request);
        public Task<CheckDataResponse> CheckSchedularTeacher(CheckData request);
        public Task<List<ClassDTO>> GetAllClassesAreNotFinished();
    }
}
