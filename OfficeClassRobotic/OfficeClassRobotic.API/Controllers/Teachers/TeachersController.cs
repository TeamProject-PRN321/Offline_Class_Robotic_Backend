﻿using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Teachers;
using OfficeClassRobotic.Repository.Teachers;

namespace OfficeClassRobotic.API.Controllers.Teachers
{
    [Route("api/v1/teacher")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private ITeacherRepository _repo;

        public TeachersController(ITeacherRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<List<TeacherDTO>?> GetAll()
        {
            var result = await _repo.GetAllTeachers();
            return result;
        }
        [HttpPost]
        [Route("update-teacher-with-list-subject")]
        public async Task<ClassRoboticResponse> UpdateteacherWithSubject(ConnectTeacherWithListSubjectRequest request)
        {
            var result = await _repo.UpdateteacherWithSubject(request);
            return result;
        }
        [HttpGet]
        [Route("update-teacher-information/subjectId")]
        public async Task<List<TeacherDTO>?> GetAllTeacherBySubjectId(Guid subjectId)
        {
            var result = await _repo.GetAllTeacherBySubjectId(new GetTeacherBySubjectId
            {
                SubjectId = subjectId
            });
            return result;
        }
    }
}
