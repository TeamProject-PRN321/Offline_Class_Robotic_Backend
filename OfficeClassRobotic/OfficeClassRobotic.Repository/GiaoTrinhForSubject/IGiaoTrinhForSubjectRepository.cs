using OfficeClassRobotic.DAO.GiaoTrinhForSubject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.GiaoTrinhForSubject
{
    public interface IGiaoTrinhForSubjectRepository
    {
        public Task CreateGiaoTrinhForSubject(GiaoTrinhDTO giaotrinh);
    }
}
