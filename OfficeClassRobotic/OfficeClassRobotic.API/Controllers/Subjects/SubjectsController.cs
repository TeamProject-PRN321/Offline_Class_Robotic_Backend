using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.GiaoTrinhs;
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
        public Task<ClassRoboticResponse> CreateSubject(CreateSubjectCommand request)
        {
            var result = _subjectsRepository.CreateSubject(request);
            return result;
        }

        [HttpPut]
        [Route("edit")]
        public Task<ClassRoboticResponse> UpdateSubject(UpdateSubjectCommand request)
        {
            var result = _subjectsRepository.UpdateSubject(request);
            return result;
        }

        [HttpDelete]
        [Route("remove")]
        public Task<ClassRoboticResponse> Delete(DeleteSubjectCommand request)
        {
            var result = _subjectsRepository.DeleteSubject(request);
            return result;
        }

        [HttpGet]
        [Route("all")]
        public Task<List<SubjectResponse>> GetAll()
        {
            var result = _subjectsRepository.GetAllSubject();
            return result;
        }

        [HttpGet]
        [Route("{subjectId}")]
        public Task<SubjectResponse> GetById(string subjectId)
        {
            var result = _subjectsRepository.GetSubjectById(subjectId);
            return result;
        }
    }
}
