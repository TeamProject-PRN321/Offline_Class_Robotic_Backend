using AutoMapper;
using OfficeClassRobotic.DAO.Students;
using OfficeClassRobotic.DAO.SudentGrades;
using OfficeClassRobotic.Service.Exceptions;

namespace OfficeClassRobotic.Repository.IStudentGrades
{
    public class StudentGradeRepository : IStudentGradeRepository
    {
        private StudentGradesDAO studentGradeDAO;
        private readonly IMapper _mapper;
        public StudentGradeRepository(IMapper mapper)
        {
            studentGradeDAO = new StudentGradesDAO();
            _mapper = mapper;
        }

        public Task<List<StudentGradeDTO>> GetStudentOfClassWithTemplateExcel(string className) 
            => StudentGradesDAO.Instance.GetStudentOfClassWithTemplateExcel(className);
    }
}
