using AutoMapper;
using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.DAO.Extensions.CRUDMessage;
using OfficeClassRobotic.DAO.Parents;

namespace OfficeClassRobotic.Repository.Parents
{
    public class ParentRepostitory : IParentRepostitory
    {
        private ParentDAO parentDAO;
        private readonly IMapper _mapper;
        public ParentRepostitory(IMapper mapper)
        {
            parentDAO = new ParentDAO();
            _mapper = mapper;
        }
       

        public async Task<List<ParentResponse>> GetAllParent()
        {
            var listParent = await parentDAO.GetAllParent();
            return listParent;


        }

        public async Task<ParentResponse> GetParentById(Guid parentId)
        {
            var parent = await parentDAO.GetParentById(parentId);
            return parent;
        }

        public Task<ClassRoboticResponse> CreateParent(CreateParentCommand parent)
        {
            throw new NotImplementedException();
        }

        public Task<ClassRoboticResponse> UpdateParent(UpdateParentCommand parent)
        {
            throw new NotImplementedException();
        }

        public Task<ClassRoboticResponse> DeleteParent(DeleteParentCommand parent)
        {
            throw new NotImplementedException();
        }

        public async Task<ParentResponse> GetParentByAppUserId(Guid appUserId)
        {
            var parent = await parentDAO.GetParentByAppUserId(appUserId);
            return parent;
        }

        public async Task<List<ParentResponse>> GetParentByName(string parentName)
        {
            var parent = await parentDAO.GetParentByName(parentName);
            return parent;
        }
    }
}
