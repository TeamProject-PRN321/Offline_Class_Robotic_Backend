using AutoMapper;
using OfficeClassRobotic.DAO.Classess;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;

namespace OfficeClassRobotic.Repository.Classess
{
    public class ClassRepository : IClassRepository
    {
        private ClassDAO _classDAO;
        private readonly IMapper _mapper;
        public ClassRepository(IMapper mapper)
        {
            _classDAO = new ClassDAO();
            _mapper = mapper;
        }
        public async Task<ClassRoboticResponse> CreateClass(CreateClassesCommand request)
        {
            await _classDAO.CreateClassess(request);
            return new ClassRoboticResponse
            {
                Message = "Create Successfully"
            };
        }

        public async Task<CheckDataResponse> CheckSchedularTeacher(CheckData request)
        {
            var response = await _classDAO.CheckSchedularTeacher(request);
            return response;
        }

        public async Task<List<ClassDTO>> GetAllClassesAreNotFinished()
        {
            var response = await _classDAO.GetAllClassesAreNotFinished();
            return response;
        }

        public async Task<ClassRoboticResponse> UpdateClass(ClassDTO request)
        {
            await ClassDAO.Instance.UpdateClassInfo(request);
            return new ClassRoboticResponse { Message = ClassRoboticMessage.UpdateSuccessfully };
        }

        public async Task<ClassRoboticResponse> DeleteClass(ClassDTO request)
        {
            await ClassDAO.Instance.DeleteClass(request);
            return new ClassRoboticResponse { Message = ClassRoboticMessage.DeleteSuccessfully };
        }

        public Task<StudentsOfClassesResponse> GetListStudentOfClassByClassName(string className)
            => ClassDAO.Instance.GetListStudentOfClassByClassName(className);


        public async Task<List<GetClassAndGradeByStudentId>> GetListClassByStudentId(Guid request)
        {
            var response = await ClassDAO.Instance.GetListClassByStudentId(request);
            return response;
        }
    }
}
