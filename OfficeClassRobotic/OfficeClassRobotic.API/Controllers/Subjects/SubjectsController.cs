using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Subjects;
using OfficeClassRobotic.Repository.GiaoTrinhForSubject;

namespace OfficeClassRobotic.API.Controllers.Subjects
{
    [Route("api/v1/subject")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectRepository _subjectsRepository;
        public SubjectsController(ISubjectRepository subjectsRepository)
        { 
            _subjectsRepository = subjectsRepository;
        }

        [HttpPost]
        [Route("add")]
        public Task<ClassRoboticResponse> Create(SubjectDTO request)
        {
            var result = _subjectsRepository.CreateSubjectForListStudentWithGiaoTrinh(request);
            return result;
        }
        [HttpPost]
        public Task<ClassRoboticResponse> CreateSubject(SubjectData request)
        {
            var result = _subjectsRepository.CreateSubject(request);
            return result;
        }

        [HttpPut]
        [Route("edit")]
        public Task<ClassRoboticResponse> Update(UpdateSubjectDTO request)
        {
            var result = _subjectsRepository.UpdateSubjectWithListStudent(request);
            return result;
        }
    }
}
