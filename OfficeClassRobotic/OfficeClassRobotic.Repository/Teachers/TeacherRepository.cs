using Azure.Core;
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

        public async Task<ClassRoboticResponse> UpdateteacherWithSubject(ConnectTeacherWithListSubjectRequest request)
        {
            try
            {
                await _dao.UpdateteacherWithSubject(request);
                return new ClassRoboticResponse
                {
                    Message = ClassRoboticMessage.UpdateSuccessfully
                };
            }
            catch
            {
                throw new BadRequestException("Something has wrong!");
            }
        }
    }
}
