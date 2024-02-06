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

namespace OfficeClassRobotic.DAO.GiaoTrinhForSubject
{
    public class GiaoTrinhForSubjectDAO
    {
        private static GiaoTrinhForSubjectDAO instance = null;
        private static ApplicationDBContext dBContext = null;

        public GiaoTrinhForSubjectDAO()
        {
            dBContext = new ApplicationDBContext();
        }

        public static GiaoTrinhForSubjectDAO Instance
        {
            get
            {
                if (instance == null) {
                    instance = new GiaoTrinhForSubjectDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public async Task CreateSubjectForListStudentWithGiaoTrinh(SubjectDTO subject)
        {
            try {
                // new giaoTrinh
                var giaoTrinh = new GiaoTrinh
                {
                    GiaoTrinhName = subject.GiaoTrinhDTO.GiaoTrinhName,
                    Description = subject.GiaoTrinhDTO.Description,
                    FilePDF = subject.GiaoTrinhDTO.FilePDF,
                    Created = DateTime.Now,
                };
                dBContext.GiaoTrinhs.Add(giaoTrinh);
                await dBContext.SaveChangesAsync();

                // check studentId into Subject
                var studentList = subject.StudentList.Select(s => s.StudentID).ToList();
                var studentExistWithSubject = await dBContext.Subjects
                    .Where(s => studentList.Contains(s.StudentID) && s.GiaoTrinhID == giaoTrinh.GiaoTrinhID && !s.IsDeleted)
                    .ToListAsync();
                if (studentExistWithSubject.Count() != 0) {
                    throw new BadRequestException("Student Id already existed");
                }
                foreach (var student in studentList) {
                    var studentExist = await dBContext.Students
                        .Where(s => s.StudentID == student && !s.IsDeleted)
                        .SingleOrDefaultAsync();
                    if (studentExist == null)
                    {
                        throw new BadRequestException($"StudentId: {student} doesn't existed");
                    }
                    var newSubject = new Subject
                    {
                        SubjectName = subject.SubjectName,
                        TotalSlots = subject.TotalSlots,
                        Created = DateTime.Now,
                        GiaoTrinhID = giaoTrinh.GiaoTrinhID,
                        StudentID = student
                    };
                    dBContext.Subjects.Add(newSubject);
                }

                await dBContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.ToString());
            }

        }
    }
}
