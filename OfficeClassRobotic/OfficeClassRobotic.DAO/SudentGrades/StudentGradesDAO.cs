using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.DAO.Students;
using OfficeClassRobotic.DAO.Teachers;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.SudentGrades
{
    public class StudentGradesDAO
    {
        private static StudentGradesDAO instance;
        private static ApplicationDBContext _dbContext;

        public StudentGradesDAO()
        {
            _dbContext = new ApplicationDBContext();
        }
        public static StudentGradesDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentGradesDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public async Task<List<StudentGradeDTO>> GetStudentOfClassWithTemplateExcel(string className)
        {
            try
            {
                var listStudentGradeDto = new List<StudentGradeDTO>();
                var classStudents = await _dbContext.Classes.Where(c => c.ClassName.ToLower().Contains(className.ToLower())).ToListAsync();
                foreach (var classStudent in classStudents)
                {
                    var subjectGrade = await _dbContext.StudentGrades.Where(sg => sg.ClassId == classStudent.Id).ToListAsync();
                    var studentExist = await _dbContext.Students.Where(s => s.Id == classStudent.StudentId).SingleOrDefaultAsync();
                    var appUser = await _dbContext.AppUsers.Where(s => s.Id == studentExist.AppUserId).SingleOrDefaultAsync();
                    var studentGrade = new StudentGradeDTO
                    {
                        ClassName = classStudent.ClassName,
                        StudentId = classStudent.StudentId,
                        StudentName = appUser.FullName,
                        Email = appUser.Email,
                        GradeSubjectOfStudents = GetGradeSubject(subjectGrade, classStudent.SubjectId)
                    };
                    listStudentGradeDto.Add(studentGrade);
                }

                return listStudentGradeDto;
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }


        public async Task<List<StudentGradeDTO>> GetListGradeByStudentId(Guid studentId)
        {
            var studentGrades = new List<StudentGradeDTO>();

            // Lấy danh sách lớp học của sinh viên
            var classesOfStudentId = await _dbContext.Classes
                .Include(c => c.Subject)
                .Include(c => c.Student)
                    .ThenInclude(s => s.AppUser)
                .Where(c => c.StudentId == studentId)
                .ToListAsync();


            foreach (var classs in classesOfStudentId)
            {
                var listGradeSubjectOfStudent = new List<GradeSubjectOfStudent>();

                var gradesInClass = await _dbContext.StudentGrades
                    .Where(sg => sg.ClassId == classs.Id)
                    .FirstOrDefaultAsync();

                var subjectGradingWeight = _dbContext.SubjectGradingWeights
                    .Where(s => s.SubjectID == classs.SubjectId)
                    .ToList();

                foreach (var gradingWeight in subjectGradingWeight)
                {
                    var newSubjectGradingWeight = new GradeSubjectOfStudent
                    {
                        SubjectName = gradingWeight.Subject.SubjectName,
                        SubjetcId = gradingWeight.SubjectID,
                        AssesessmentType = gradingWeight.AssesessmentType,
                        WeightPercentage = gradingWeight.WeightPercentage,
                        Grade = gradesInClass.Grade
                    };
                    listGradeSubjectOfStudent.Add(newSubjectGradingWeight);
                }

                var studentGradeDTO = new StudentGradeDTO
                {
                    StudentName = classs.Student.AppUser.UserName,
                    StudentId = classs.StudentId,
                    ClassName = classs.ClassName,
                    Email = classs.Student.AppUser.Email,
                    GradeSubjectOfStudents = listGradeSubjectOfStudent
                };
                studentGrades.Add(studentGradeDTO);
            }
            return studentGrades;
        }


        public List<GradeSubjectOfStudent> GetGradeSubject(List<StudentGrade> listStudentGrade, Guid subjectId)
        {
            var listGradeSubjectOfStudent = new List<GradeSubjectOfStudent>();
            foreach (var studenttGrade in listStudentGrade)
            {
                var subjectGradeExist = _dbContext.SubjectGradingWeights
                    .Where(s => s.SubjectID == subjectId && s.AssesessmentType == studenttGrade.AssesessmentType).SingleOrDefault();
                var subjectExist = _dbContext.Subjects.Where(s => s.Id == subjectGradeExist.SubjectID).SingleOrDefault();
                var newSubjectGradingWeight = new GradeSubjectOfStudent
                {
                    SubjetcId = subjectGradeExist.SubjectID,
                    SubjetcName = subjectExist.SubjectName,
                    AssesessmentType = studenttGrade.AssesessmentType,
                    WeightPercentage = subjectGradeExist.WeightPercentage,
                    Grade = studenttGrade.Grade,
                };
                listGradeSubjectOfStudent.Add(newSubjectGradingWeight);
            }
            return listGradeSubjectOfStudent;
        }

        public async Task<Subject> GetSubjectByClassName(string className)
        {
            var classStudents = await _dbContext.Classes
                .Where(c => c.ClassName.Contains(className)).FirstOrDefaultAsync();

            var subject = await _dbContext.Subjects.Where(s => s.Id == classStudents.SubjectId).FirstOrDefaultAsync();
            return subject;
        }

        public async Task SaveGradeToDatabase(string studentId, List<GradeSubjectOfStudent> listGrade, string className)
        {
            var classId = await _dbContext.Classes.Where(c => c.StudentId == Guid.Parse(studentId) && c.ClassName == className).SingleOrDefaultAsync();
            foreach (var grade in listGrade)
            {
                var studentGrade = await _dbContext.StudentGrades
                    .Where(s => s.ClassId == classId.Id && s.AssesessmentType == grade.AssesessmentType)
                    .SingleOrDefaultAsync();
                if (studentGrade == null)
                {
                    studentGrade = new StudentGrade
                    {
                        ClassId = classId.Id,
                        AssesessmentType = grade.AssesessmentType,
                        Grade = grade.Grade
                    };
                    _dbContext.StudentGrades.Add(studentGrade);
                }
                else
                {
                    studentGrade.Grade = grade.Grade;
                    _dbContext.StudentGrades.Update(studentGrade);
                }
            }
            await _dbContext.SaveChangesAsync();
        }
    }
}
