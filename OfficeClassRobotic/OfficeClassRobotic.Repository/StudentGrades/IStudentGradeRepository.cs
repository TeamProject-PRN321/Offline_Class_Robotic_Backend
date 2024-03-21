using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.SudentGrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.IStudentGrades
{
    public interface IStudentGradeRepository
    {
        public Task<List<StudentGradeDTO>> GetStudentOfClassWithTemplateExcel(string className);
        public Task<Subject> GetSubjectByClassName(string className);
        public Task SaveToDatabase(string studentId, List<GradeSubjectOfStudent> listGrade, string className);
        public Task<List<StudentGradeDTO>> GetScoreOfStudentByClassname(string className);
    }
}
