using AutoMapper;
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
            var response = _mapper.Map<List<ParentResponse>>(listParent);
            return response;


        }

        public async Task<ParentResponse> GetParentById(string parentId)
        {
            var parent = await parentDAO.GetParentById(parentId);
            var response = _mapper.Map<ParentResponse>(parent);
            return response;
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

        public Task<ParentResponse> GetParentByAppUserId(string appUserId)
        {
            throw new NotImplementedException();
        }

        public Task<ParentResponse> GetParentByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
