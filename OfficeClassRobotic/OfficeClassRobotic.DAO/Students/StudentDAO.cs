using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.Students
{
    public class StudentDAO
    {
        private static StudentDAO instance;
        private static ApplicationDBContext dbContext;
        public StudentDAO()
        {
            dbContext = new ApplicationDBContext();
        }
        public static StudentDAO Instance
        {
            get
            {
                if (instance == null) {
                    instance = new StudentDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public async Task CreateStudent(StudentDTO student)
        {
            var studentExist = await dbContext.Students
                .Where(s => s.Name == student.Name && s.ParentID == student.ParentID)
                .SingleOrDefaultAsync();
            if (studentExist != null) {
                throw new Exception("BadRequest");
            }
            var newStudent = new Student
            {
                Name = student.Name,
                Address = student.Address,
                Birthday = student.Birthday,
                ParentID = student.ParentID
            };

            dbContext.Students.Add(newStudent);
            await dbContext.SaveChangesAsync();
        }
    }
}
