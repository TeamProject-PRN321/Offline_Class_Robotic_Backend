﻿using Microsoft.EntityFrameworkCore;
using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.DAO.Teachers;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;
using System;
using System.Collections.Generic;
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
                var classStudents = await _dbContext.Classes.Where(c => c.ClassName.Contains(className)).ToListAsync();
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

        public List<GradeSubjectOfStudent> GetGradeSubject(List<StudentGrade> listStudentGrade, Guid subjectId)
        {
            var listGradeSubjectOfStudent = new List<GradeSubjectOfStudent>();
            foreach (var studenttGrade in listStudentGrade)
            {
                var subjectGradeExist = _dbContext.SubjectGradingWeights
                    .Where(s => s.SubjectID == subjectId && s.AssesessmentType == studenttGrade.AssesessmentType).SingleOrDefault();
                var newSubjectGradingWeight = new GradeSubjectOfStudent
                {
                    SubjetcId = subjectGradeExist.SubjectID,
                    AssesessmentType = studenttGrade.AssesessmentType,
                    WeightPercentage = subjectGradeExist.WeightPercentage,
                    Grade = studenttGrade.Grade,
                };
                listGradeSubjectOfStudent.Add(newSubjectGradingWeight);
            }

            return listGradeSubjectOfStudent;
        }
    }
}
