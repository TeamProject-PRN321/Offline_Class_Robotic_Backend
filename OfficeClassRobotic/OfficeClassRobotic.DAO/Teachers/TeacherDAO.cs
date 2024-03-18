using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.GiaoTrinhs;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;

namespace OfficeClassRobotic.DAO.Teachers
{
    public class TeacherDAO
    {
        private static TeacherDAO instance;
        private static ApplicationDBContext _dbContext;

        public TeacherDAO()
        {
            _dbContext = new ApplicationDBContext();
        }
        public static TeacherDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TeacherDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        /// <summary>
        /// Update Teacher
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        
    }
}
