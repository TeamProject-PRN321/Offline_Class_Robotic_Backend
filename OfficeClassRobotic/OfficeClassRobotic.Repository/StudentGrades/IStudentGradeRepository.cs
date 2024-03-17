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
    }
}
