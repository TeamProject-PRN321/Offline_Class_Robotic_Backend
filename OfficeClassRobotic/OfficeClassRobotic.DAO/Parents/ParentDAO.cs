using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.Parents
{
    public class ParentDAO
    {
        private static ParentDAO instance;
        public static ApplicationDBContext _dbContext;
        public ParentDAO()
        {
            _dbContext = new ApplicationDBContext();
        }
        public static ParentDAO Instance
        {
            get
            {
                if(instance == null) {
                    instance = new ParentDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public async Task CreateParent(ParentDTO parent)
        {
            var parentExist = await _dbContext.Parents
                .Where(p => p.Name == parent.Name && p.Address == parent.Address)
                .SingleOrDefaultAsync();
            if(parentExist != null) {
                throw new Exception("Badrequest");
            }
            var newParent = new Parent
            {
                Name = parent.Name,
                Address = parent.Address,
                Phone = parent.Phone,
                Birthday = parent.Birthday
            };
            _dbContext.Parents.Add(newParent);
            await _dbContext.SaveChangesAsync();
        }
    }
}
