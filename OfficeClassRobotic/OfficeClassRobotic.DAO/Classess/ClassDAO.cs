using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Subjects;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.Classess
{
    public class ClassDAO
    {
        private static ClassDAO instance = null;
        private static ApplicationDBContext dBContext = null;

        public ClassDAO()
        {
            dBContext = new ApplicationDBContext();
        }

        public static ClassDAO Instance
        {
            get
            {
                if (instance == null) {
                    instance = new ClassDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public Task CreateClassess(ClassDTO request)
        {
            var classess = new Class
            {
                ClassName = request.ClassName,
                DayStudy = request.DayStudy,
                TimeStudy = null,
                StudentId = Guid.Parse(request.StudentId),
                SubjectId = Guid.Parse(request.SubjectId),
            };
            dBContext.Classes.Add(classess);
            dBContext.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
