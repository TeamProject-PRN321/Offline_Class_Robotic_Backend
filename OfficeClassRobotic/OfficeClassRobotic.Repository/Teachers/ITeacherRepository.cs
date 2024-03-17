using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Teachers;

namespace OfficeClassRobotic.Repository.Teachers
{
    public interface ITeacherRepository
    {
        //public Task<ClassRoboticResponse> CreateTeacher(CreateTeacherDTO request);
        //public Task<ClassRoboticResponse> UpdateTeacher(UpdateTeacherDTO request);
        public Task<List<TeacherDTO>?> GetAllTeachers();
        public Task<TeacherDTO> GetTeacherByTeacherId(GetTeacherOrDeleteTeacherByTeacherId request);
        public Task<List<TeacherDTO>?> GetAllTeacherBySubjectId(GetTeacherBySubjectId request);
        public Task<ClassRoboticResponse> UpdateteacherWithSubject(ConnectTeacherWithListSubjectRequest request);
        public Task<List<TeacherSchedule>> GetScheduleOfTeacherByTeacherIdAndTime(TeacherScheduleRequest request);
        public Task<TeacherSubjectResponse> GetListTeacherBySubjectName(string keyword);

    }
}
