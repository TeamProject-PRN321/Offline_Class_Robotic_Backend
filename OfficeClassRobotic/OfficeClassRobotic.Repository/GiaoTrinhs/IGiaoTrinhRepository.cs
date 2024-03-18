using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.GiaoTrinhs;
using OfficeClassRobotic.DAO.Parents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.GiaoTrinhs
{
    public interface IGiaoTrinhRepository
    {
        public Task<ClassRoboticResponse> CreateGiaoTrinh(CreateGiaoTrinhCommand giaoTrinh);
        public Task<ClassRoboticResponse> UpdateGiaoTrinh(UpdateGiaoTrinhCommand giaoTrinh);
        public Task<ClassRoboticResponse> DeleteGiaoTrinh(DeleteGiaoTrinhCommand giaoTrinh);
        public Task<List<GiaoTrinhResponse>> GetAllGiaoTrinh();
        public Task<GiaoTrinhResponse> GetGiaoTrinhById(string giaoTrinhId);
    }
}
