﻿using Microsoft.AspNetCore.Mvc;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Students;
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
        public async Task<List<ScheduleOfStudent>?> GetScheduleOfStudentByStudentId([FromQuery] GetStudentScheduleByStudentIdRequest request)
        {
            var response = await _studentRepository.GetScheduleOfStudentByStudentId(request);
            if (response == null)
            {
                return new List<ScheduleOfStudent>();
            }
            return await _studentRepository.GetScheduleOfStudentByStudentId(request);
        }

        [HttpGet]
        [Route("get-student-by-student-id/{studentId}")]
        public async Task<StudentDTO> GetStudentByStudentId(Guid studentId)
        {
            return await _studentRepository.GetStudentByStudentId(studentId);
        }

        [HttpGet]
        [Route("get-student-by-appuser-id/{appUserId}")]
        public async Task<StudentDTO> GetStudentByAppUserId(Guid appUserId)
        {
            return await _studentRepository.GetStudentByAppUserId(appUserId);
        }

        [HttpGet]
        [Route("get-students-by-student-name/{studentName}")]
        public async Task<List<StudentDTO>> GetStudentByStudentName(string studentName)
        {
            return await _studentRepository.GetStudentByStudentName(studentName);
        }
        [HttpGet]
        [Route("get-all-students")]
        public async Task<List<StudentDTO>> GetAllStudent()
        {
            return await _studentRepository.GetAllStudent();
        }

        [HttpGet]
        [Route("get-all-studentsGrades/{studentId}")]
        public async Task<List<GetStudentGrade>> GetStudentGrades(Guid studentId)
        {
            return await _studentRepository.GetStudentGrades(studentId);
        }


        [HttpGet]
        [Route("get-all-studentsAttendance/{studentId}")]
        public async Task<List<GetStudentAttendance>> GetStudentAttendance(Guid studentId)
        {
            return await _studentRepository.GetStudentAttendance(studentId);
        }

    }
}
