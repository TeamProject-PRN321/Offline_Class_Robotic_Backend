/*using Azure.Core;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Teachers;
using OfficeClassRobotic.Service.Exceptions;

namespace OfficeClassRobotic.Repository.Teachers
{
    public class TeacherRepository : ITeacherRepository
    {
        private TeacherDAO _dao;

        public TeacherRepository()
        {
            _dao = new TeacherDAO();
        }

        public async Task<ClassRoboticResponse> CreateTeacher(CreateTeacherDTO request)
        {
            await _dao.CreateTeacher(request);
            return new ClassRoboticResponse
            {
                Message = "Create Successfully"
            };
        }

        public async Task<List<TeacherDTO>?> GetAllTeacherBySubjectId(GetTeacherBySubjectId request)
        {
            try
            {
                var result = await _dao.GetAllTeacherBySubjectId(request);
                return result;
            }
            catch
            {
                throw new BadRequestException("Something has wrong!");
            }
        }

        public async Task<List<TeacherDTO>?> GetAllTeachers()
        {
            try
            {
                var result = await _dao.GetAllTeacher();
                return result;
            }
            catch
            {
                throw new BadRequestException("Something has wrong!");
            }
        }

        public async Task<TeacherDTO> GetTeacherByTeacherId(GetTeacherOrDeleteTeacherByTeacherId request)
        {
            try
            {
                var result = await _dao.GetTeacherByTeacherId(request);
                return result;
            }
            catch
            {
                throw new BadRequestException("Something has wrong!");
            }
        }

        public async Task<ClassRoboticResponse> UpdateTeacher(UpdateTeacherDTO request)
        {
            await _dao.UpdateTeacher(request);
            return new ClassRoboticResponse
            {
                Message = "Update Successfully"
            };
        }
    }
}
*/