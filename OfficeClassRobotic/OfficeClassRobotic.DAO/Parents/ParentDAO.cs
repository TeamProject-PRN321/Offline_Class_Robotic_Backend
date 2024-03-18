using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Service.Exceptions;

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
                if (instance == null) {
                    instance = new ParentDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public async Task<List<Parent>> GetAllParent()
        {
            try {
                var parentExist = await _dbContext.Parents
                .Where(p => !p.IsDeleted)
                .ToListAsync();

                return parentExist;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<Parent> GetParentById(string parentId)
        {
            try {
                var parentExist = await _dbContext.Parents
                .Where(p => p.Id == Guid.Parse(parentId) && !p.IsDeleted)
                .SingleOrDefaultAsync();
                if (parentExist == null) {
                    throw new NotFoundException("ParentId not exist");
                }
                return parentExist;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<Parent> GetParentByAppUserId(string appUserId)
        {
            try
            {
                var parentExist = await _dbContext.Parents
                .Where(p => p.AppUserId == Guid.Parse(appUserId) && !p.IsDeleted)
                .SingleOrDefaultAsync();
                if (parentExist == null)
                {
                    throw new NotFoundException("ParentId not exist");
                }
                return parentExist;
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<Parent> GetParentByName(string name)
        {
            try
            {
                var parentExist = await _dbContext.Parents
                .Where(p => p.AppUser.FullName.Equals(name) && !p.IsDeleted)
                .SingleOrDefaultAsync();
                if (parentExist == null)
                {
                    throw new NotFoundException("ParentId not exist");
                }
                return parentExist;
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
