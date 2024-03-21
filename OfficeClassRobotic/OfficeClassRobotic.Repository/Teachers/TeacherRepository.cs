using AutoMapper;
using Azure.Core;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Teachers;
using OfficeClassRobotic.Service.Exceptions;

namespace OfficeClassRobotic.Repository.Teachers
{
    public class TeacherRepository : ITeacherRepository
    {
        private TeacherDAO _dao;
        private readonly IMapper _mapper;

        public TeacherRepository(IMapper mapper)
        {
            _dao = new TeacherDAO();
            _mapper = mapper;
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
                throw new BadRequestException("Không tìm thấy danh sách teacher dạy môn này!");
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
                throw new BadRequestException("Không thể lấy danh sách teacher!");
            }
        }

        public async Task<List<TeacherSchedule>> GetScheduleOfTeacherByTeacherIdAndTime(TeacherScheduleRequest request)
        {
            try
            {
                var result = await _dao.GetScheduleOfTeacherByTeacherIdAndTime(request);
                if(request.Keyword == null) request.Keyword = string.Empty;
                var respone = result.Where(x => x.ClassName.ToLower().Contains(request.Keyword.ToLower())).ToList();
                return respone;
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
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
                throw new BadRequestException("Không thể tìm thấy teacher!");
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
                throw new BadRequestException("Update fail!!");
            }
        }

        /// <summary>
        /// Dùng Get danh sách giáo viên theo SubjectName
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        public async Task<TeacherSubjectResponse> GetListTeacherBySubjectName(string keyword)
        {
            try
            {
                var result = await _dao.GetListTeacherBySubjectName(keyword);
                return result;
            }
            catch
            {
                throw new BadRequestException("Something has wrong!");
            }
        }

        public Task<ClassRoboticResponse> CreateTeacher(CreateTeacherDTO request)
        {
            throw new NotImplementedException();
        }
    }
}
