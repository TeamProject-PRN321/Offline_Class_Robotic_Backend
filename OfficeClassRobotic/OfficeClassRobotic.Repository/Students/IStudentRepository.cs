using OfficeClassRobotic.DAO.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.Students
{
    public interface IStudentRepository
    {
        public Task CreateStudent(StudentDTO student);
    }
}
