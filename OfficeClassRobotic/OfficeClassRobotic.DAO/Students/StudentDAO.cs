using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.Students
{
    public class StudentDAO
    {
        /*private static StudentDAO instance;
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

        public async Task CreateStudent(CreateStudentCommand student)
        {
            try {
                var parentExist = await dbContext.Parents.Where(p => p.Id == Guid.Parse(student.ParentID) && !p.IsDeleted).SingleOrDefaultAsync();
                if(parentExist == null) {
                    throw new NotFoundException("Parent doesn't existed");
                }
                var studentExist = await dbContext.Students
                .Where(s => s.Name == student.Name && s.ParentId == Guid.Parse(student.ParentID))
                .SingleOrDefaultAsync();
                if (studentExist != null) {
                    throw new BadRequestException("Student is existed");
                }
                var newStudent = new Student
                {
                    Name = student.Name,
                    Address = student.Address,
                    Birthday = student.Birthday,
                    ParentId = Guid.Parse(student.ParentID)
                };

                dbContext.Students.Add(newStudent);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task UpdateStudent(UpdateStudentCommand student)
        {
            try {
                var studentExist = await dbContext.Students
                .Where(s => s.Id == Guid.Parse(student.StudentId) && !s.IsDeleted)
                .SingleOrDefaultAsync();
                if (studentExist == null) {
                    throw new NotFoundException("StudentId does not exist to update");
                }
                studentExist.Name = student.Name;
                studentExist.Address = student.Address;
                studentExist.Birthday = student.Birthday;
                studentExist.ParentId = Guid.Parse(student.ParentID);

                dbContext.Students.Update(studentExist);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task DeleteStudent(DeleteStudentCommand student)
        {
            try {
                var studentExist = await dbContext.Students
                .Where(s => s.Id == Guid.Parse(student.StudentId) && !s.IsDeleted)
                .SingleOrDefaultAsync();
                if (studentExist == null) {
                    throw new NotFoundException("StudentId does not exist to delete");
                }
                studentExist.IsDeleted = true;

                dbContext.Students.Update(studentExist);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<List<Student>> GetAllStudent()
        {
            try {
                var studentList = await dbContext.Students
                .Where(s => !s.IsDeleted)
                .ToListAsync();
                
                return studentList;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<Student> GetStudentById(string student)
        {
            try {
                var studentExist = await dbContext.Students
                .Where(s => s.Id == Guid.Parse(student) && !s.IsDeleted)
                .SingleOrDefaultAsync();
                if (studentExist == null) {
                    throw new NotFoundException("Student Id does not existed");
                }

                return studentExist;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }*/
    }
}
