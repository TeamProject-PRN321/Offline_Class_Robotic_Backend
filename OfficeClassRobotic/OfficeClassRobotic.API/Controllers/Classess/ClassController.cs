using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Classess;
using OfficeClassRobotic.DAO.Classrooms;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.Repository.Classess;

namespace OfficeClassRobotic.API.Controllers.Classess
{
    [Route("api/v1/classes")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassRepository _classRepository;
        public ClassController(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        [HttpPost]
        [Route("add")]
        public Task<ClassRoboticResponse> Create(CreateClassesCommand request)
        {
            var result = _classRepository.CreateClass(request);
            return result;
        }

        [HttpPut]
        [Route("edit")]
        public Task<ClassRoboticResponse> Update(ClassDTO request)
        {
            var result = _classRepository.UpdateClass(request);
            return result;
        }

        [HttpDelete]
        [Route("remove")]
        public Task<ClassRoboticResponse> Delete(ClassDTO request)
        {
            var result = _classRepository.DeleteClass(request);
            return result;
        }

        [HttpPost]
        [Route("check-schedular-teacher")]
        public Task<CheckDataResponse> Check(CheckData request)
        {
            var result = _classRepository.CheckSchedularTeacher(request);
            return result;
        }
        [HttpGet]
        [Route("get-all-classes-are-not-finshed")]
        public async Task<List<ClassDTO>> GetAllClassesAreNotFinished()
        {
            var result = await _classRepository.GetAllClassesAreNotFinished();
            return result;
        }

        [HttpGet]
        [Route("get-list-student-of-class/{classname}")]
        public async Task<StudentsOfClassesResponse> GetListStudentByClassname(string classname)
        {
            var result = await _classRepository.GetListStudentOfClassByClassName(classname);
            return result;
        }

        [HttpGet]
        [Route("get-list-class-of-studentId/{studentId}")]
        public async Task<List<GetClassAndGradeByStudentId>> GetListStudentByClassname(Guid studentId)
        {
            var result = await _classRepository.GetListClassByStudentId(studentId);
            return result;
        }

        [HttpGet]
        [Route("get-class-of-student-by-id-and-classname/{appuserid}/{classname}")]
        public async Task<ClassDataResponse> GetListStudentByClassname(string appuserid, string classname)
        {
            var result = await _classRepository.GetClassOfStudentByIdAndClassname(appuserid, classname);
            return result;
        }
    }
}
