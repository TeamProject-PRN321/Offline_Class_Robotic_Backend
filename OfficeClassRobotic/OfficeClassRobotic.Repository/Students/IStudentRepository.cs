using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Parents;
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
        public Task<ClassRoboticResponse> CreateStudent(CreateStudentCommand student);
        public Task<ClassRoboticResponse> UpdateStudent(UpdateStudentCommand student);
        public Task<ClassRoboticResponse> DeleteStudent(DeleteStudentCommand student);
        public Task<List<StudentResponse>> GetAllStudent();
        public Task<StudentResponse> GetStudentById(string studentId);
    }
}
