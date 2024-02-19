using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;

namespace OfficeClassRobotic.DAO.TeacherSubjects
{
    public class TeacherSubjectDAO
    {
        private static ApplicationDBContext _dbContext;
        private static TeacherSubjectDAO _instance;

        public TeacherSubjectDAO()
        {
            _dbContext = new ApplicationDBContext();
        }
        public TeacherSubjectDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TeacherSubjectDAO();
                }
                return _instance;
            }
            set { _instance = value; }
        }
        public async Task CreateTeacherSubject(TeacherSubjectDTO request)
        {
            foreach(var subjectId in request.ListSubjectId)
            {
                var newTS = new TeacherSubject
                {
                    TeacherId = request.TeacherId,
                    SubjectId = subjectId
                };
                _dbContext.TeacherSubjects.Add(newTS);
            }
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateTeacherSubject(TeacherSubjectDTO request)
        {
            var listOld = _dbContext.TeacherSubjects.Where(x => x.TeacherId == request.TeacherId).ToList();
            if (listOld.Any())
            {
                _dbContext.TeacherSubjects.RemoveRange(listOld);
            }
            foreach (var subjectId in request.ListSubjectId)
            {
                var newTS = new TeacherSubject
                {
                    TeacherId = request.TeacherId,
                    SubjectId = subjectId
                };
                _dbContext.TeacherSubjects.Add(newTS);
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
