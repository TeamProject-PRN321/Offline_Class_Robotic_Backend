﻿using AutoMapper;
using Azure.Core;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Classrooms;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Parents;
using OfficeClassRobotic.DAO.Students;
using OfficeClassRobotic.DAO.SudentGrades;
using OfficeClassRobotic.Service.Exceptions;

namespace OfficeClassRobotic.Repository.Students
{
    public class StudentRepository : IStudentRepository
    {
        private StudentDAO studentDAO;
        private readonly IMapper _mapper;
        
        public StudentRepository(IMapper mapper)
        {
            studentDAO = new StudentDAO();
            _mapper = mapper;
        }
        public async Task<List<ScheduleOfStudent>?> GetScheduleOfStudentByStudentId(GetStudentScheduleByStudentIdRequest request)
        {
            try
            {
                return await studentDAO.GetScheduleOfStudentByStudentId(request);
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Không tìm thấy sinh viên");
            }
        }

        public async Task<StudentDTO> GetStudentByStudentId(Guid studentId)
        {
            try
            {
                return await studentDAO.GetStudentByStudentId(studentId);
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Không tìm thấy sinh viên");
            }
        }


        public async Task<StudentDTO> GetStudentByAppUserId(Guid appUserId)
        {
            try
            {
                return await studentDAO.GetStudentByAppUserId(appUserId);
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Không tìm thấy sinh viên");
            }
        }

        public async Task<List<StudentDTO>> GetStudentByStudentName(string studentName)
        {
            try
            {
                return await studentDAO.GetStudentByStudentName(studentName);
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Không tìm thấy sinh viên");
            }
        }

        public async Task<List<StudentDTO>> GetAllStudent()
        {
            try
            {
                return await studentDAO.GetAllStudent();
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Không tìm thấy danh sách sinh viên");
            }
        }

        public Task<List<StudentDTO>> SearchStudent(string studentName)
        {
            try
            {
                var list = studentDAO.GetStudentByStudentName(studentName);

                return list;
            }catch(Exception ex)
            {
                throw new BadRequestException("Không tìm thấy sinh viên");
            }
        }

        public async Task<List<GetStudentGrade>> GetStudentGrades(Guid studentId)
        {
            try
            {
                return await studentDAO.GetListGradeByStudentId(studentId);
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Student does not have grade yet");
            }
        }

        public async Task<List<GetStudentAttendance>> GetStudentAttendance(Guid studentId)
        {
            try
            {
                return await studentDAO.GetAttendanceByStudentId(studentId);
            }
            catch (Exception ex)
            {
                throw new BadRequestException("No attendance records found for the student.");
            }
        }



        /*
public async Task<ClassRoboticResponse> CreateStudent(CreateStudentCommand student)
{
await studentDAO.CreateStudent(student);
return new ClassRoboticResponse
{
Message = "Create Successfully"
};
}

public async Task<ClassRoboticResponse> DeleteStudent(DeleteStudentCommand student)
{
await studentDAO.DeleteStudent(student);
return new ClassRoboticResponse
{
Message = "Delete Successfully"
};
}

public async Task<List<StudentResponse>> GetAllStudent()
{
var student = await studentDAO.GetAllStudent();
var response = _mapper.Map<List<StudentResponse>>(student);
return response;
}

public async Task<StudentResponse> GetStudentById(string studentId)
{
var student = await studentDAO.GetStudentById(studentId);
var response = _mapper.Map<StudentResponse>(student);
return response;
}

public async Task<ClassRoboticResponse> UpdateStudent(UpdateStudentCommand student)
{
await studentDAO.UpdateStudent(student);
return new ClassRoboticResponse
{
Message = "Update Successfully"
};
}*/

    }
}
