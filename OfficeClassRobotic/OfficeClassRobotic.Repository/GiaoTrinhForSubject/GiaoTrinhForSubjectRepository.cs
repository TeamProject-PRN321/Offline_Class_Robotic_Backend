using OfficeClassRobotic.DAO.GiaoTrinhForSubject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.GiaoTrinhForSubject
{
    public class GiaoTrinhForSubjectRepository : IGiaoTrinhForSubjectRepository
    {
        private GiaoTrinhForSubjectDAO _giaoTrinhDAO;
        public GiaoTrinhForSubjectRepository()
        {
            _giaoTrinhDAO = new GiaoTrinhForSubjectDAO();
        }
        public async Task CreateGiaoTrinhForSubject(GiaoTrinhDTO giaotrinh)
        {
            await _giaoTrinhDAO.CreateGiaoTrinhForSubject(giaotrinh);
        }
    }
}
