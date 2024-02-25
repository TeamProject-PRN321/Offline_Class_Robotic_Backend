using OfficeClassRobotic.DAO.Classess;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.GiaoTrinhs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.Classess
{
    public interface IClassRepository 
    {
        public Task<ClassRoboticResponse> CreateClass(ClassDTO request);
    }
}
