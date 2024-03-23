using Microsoft.EntityFrameworkCore;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Students;
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

        public async Task<List<ParentResponse>> GetAllParent()
        {
            try {
                var ParentDto = new List<ParentResponse>();

                var parentExist = await _dbContext.Parents.
                    Include(c => c.AppUser)
                .Where(p => !p.IsDeleted)
                .ToListAsync();

                foreach (var parent in parentExist)
                {
                    var parentResponse = new ParentResponse()
                    {
                        Id = parent.Id,
                        AppUserId = parent.AppUserId,
                        Name = parent.AppUser.FullName,
                        Address = parent.AppUser.Address,
                        Phone = parent.AppUser.PhoneNumber,
                        Birthday = parent.AppUser.DateOfBirth,
                        Created = parent.Created
                    };
                    ParentDto.Add(parentResponse);
                }
                if (parentExist == null)
                {
                    throw new NotFoundException("parent list is empty");
                }
                return ParentDto;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<ParentResponse> GetParentById(Guid parentId)
        {
            try {

                var parentExist = await _dbContext.Parents
                    .Include(c => c.AppUser)
                .Where(p => p.Id == parentId && !p.IsDeleted)
                .SingleOrDefaultAsync();

                var parentResponse = new ParentResponse()
                {
                    Id = parentExist.Id,
                    AppUserId = parentExist.AppUserId,
                    Name = parentExist.AppUser.FullName,
                    Address = parentExist.AppUser.Address,
                    Phone = parentExist.AppUser.PhoneNumber,
                    Birthday = parentExist.AppUser.DateOfBirth,
                    Created = parentExist.Created
                };

                if (parentExist == null) {
                    throw new NotFoundException(parentId + " not exist");
                }
                return parentResponse;
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<ParentResponse> GetParentByAppUserId(Guid appUserId)
        {
            try
            {
                var parentExist = await _dbContext.Parents
                    .Include (c => c.AppUser)
                .Where(p => p.AppUserId == appUserId && !p.IsDeleted)
                .SingleOrDefaultAsync();

                var parentResponse = new ParentResponse()
                {
                    Id = parentExist.Id,
                    AppUserId = parentExist.AppUserId,
                    Name = parentExist.AppUser.FullName,
                    Address = parentExist.AppUser.Address,
                    Phone = parentExist.AppUser.PhoneNumber,
                    Birthday = parentExist.AppUser.DateOfBirth,
                    Created = parentExist.Created
                };

                if (parentExist == null)
                {
                    throw new NotFoundException(appUserId + " not exist");
                }
                return parentResponse;
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }

        public async Task<List<ParentResponse>> GetParentByName(string parentName)
        {
            try
            {
                var parentDtos = new List<ParentResponse>();

                var parentExist = await _dbContext.Parents
                    .Include(c => c.AppUser)
                .Where(p => p.AppUser.FullName.Contains(parentName) && !p.IsDeleted)
                .ToListAsync();

                foreach (var parent in parentExist)
                {
                    var parentResponse = new ParentResponse()
                    {
                        Id = parent.Id,
                        AppUserId = parent.AppUserId,
                        Name = parent.AppUser.FullName,
                        Address = parent.AppUser.Address,
                        Phone = parent.AppUser.PhoneNumber,
                        Birthday = parent.AppUser.DateOfBirth,
                        Created = parent.Created
                    };
                    parentDtos.Add(parentResponse);
                }
                if (parentExist == null)
                {
                    throw new NotFoundException(parentName + "does not exist");
                }
                return parentDtos;
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
