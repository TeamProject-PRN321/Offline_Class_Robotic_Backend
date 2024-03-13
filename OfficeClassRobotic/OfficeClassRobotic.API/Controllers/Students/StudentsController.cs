﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Parents;
using OfficeClassRobotic.DAO.Students;
using OfficeClassRobotic.Repository.Parents;
using OfficeClassRobotic.Repository.Students;

namespace OfficeClassRobotic.API.Controllers.Students
{
    [Route("api/v1/student")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("get-schedule-of-student-by-student-id")]
        public async Task<List<ScheduleOfStudent>?> GetScheduleOfStudentByStudentId([FromQuery]GetStudentScheduleByStudentIdRequest request)
        {

            return await _studentRepository.GetScheduleOfStudentByStudentId(request);
        }

        [HttpGet]
        [Route("get-student-by-student-id/{studentId}")]
        public async Task<StudentDTO> GetStudentByStudentId(Guid studentId)
        {
            return await _studentRepository.GetStudentByStudentId(studentId);
        }
        [HttpGet]
        [Route("get-students-by-student-name/{studentName}")]
        public async Task<List<StudentDTO>> GetStudentByStudentName(string studentName)
        {

            return await _studentRepository.GetStudentByStudentName(studentName);
        }
     
     
    }
}
