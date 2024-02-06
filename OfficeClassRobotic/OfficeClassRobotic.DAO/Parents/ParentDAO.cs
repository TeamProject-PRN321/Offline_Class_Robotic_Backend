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

        public async Task CreateParent(CreateParentCommand parent)
        {
            try {
                var parentExist = await _dbContext.Parents
                .Where(p => p.Name == parent.Name && p.Address == parent.Address)
                .SingleOrDefaultAsync();
                if (parentExist != null) {
                    throw new BadRequestException("Parent is existed");
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
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task UpdateParent(UpdateParentCommand parent)
        {
            try {
                var parentExist = await _dbContext.Parents
                .Where(p => p.ParentID == parent.ParentId)
                .SingleOrDefaultAsync();
                if (parentExist == null) {
                    throw new NotFoundException("ParentId not exist");
                }

                parentExist.Name = parent.Name;
                parentExist.Address = parent.Address;
                parentExist.Phone = parent.Phone;
                parentExist.Birthday = parent.Birthday;

                _dbContext.Parents.Update(parentExist);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task DeleteParent(DeleteParentCommand parent)
        {
            try {
                var parentExist = await _dbContext.Parents
                .Where(p => p.ParentID == parent.ParentId && !p.IsDeleted)
                .SingleOrDefaultAsync();
                if (parentExist == null) {
                    throw new NotFoundException("ParentId not exist");
                }

                // check coi phụ huynh này có còn học sinh ko, ko còn thì mới xóa, còn thì ko được xóa
                var studentExistParent = await _dbContext.Students
                    .Where(s => s.ParentID == parent.ParentId && !s.IsDeleted)
                    .SingleOrDefaultAsync();
                if (studentExistParent != null) {
                    throw new BadRequestException("Parent have student already Exist, and you can not delete Parent");
                }
                parentExist.IsDeleted = true;
                _dbContext.Parents.Update(parentExist);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
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

        public async Task<Parent> GetParentById(int parentId)
        {
            try {
                var parentExist = await _dbContext.Parents
                .Where(p => p.ParentID == parentId && !p.IsDeleted)
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
    }
}
