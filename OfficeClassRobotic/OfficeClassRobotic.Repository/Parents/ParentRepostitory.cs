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
        public async Task<ClassRoboticResponse> CreateParent(CreateParentCommand parent)
        {
            await parentDAO.CreateParent(parent);
            return new ClassRoboticResponse
            {
                Message = "Create Successfully"
            };
        }

        public async Task<ClassRoboticResponse> DeleteParent(DeleteParentCommand parent)
        {
            await parentDAO.DeleteParent(parent);
            return new ClassRoboticResponse
            {
                Message = "Delete Successfully"
            };
        }

        public async Task<List<ParentResponse>> GetAllParent()
        {
            var listParent = await parentDAO.GetAllParent();
            var response = _mapper.Map<List<ParentResponse>>(listParent);
            return response;
        }

        public async Task<ParentResponse> GetParentById(int parentId)
        {
            var parent = await parentDAO.GetParentById(parentId);
            var response = _mapper.Map<ParentResponse>(parent);
            return response;
        }

        public async Task<ClassRoboticResponse> UpdateParent(UpdateParentCommand parent)
        {
            await parentDAO.UpdateParent(parent);
            return new ClassRoboticResponse
            {
                Message = "Update Successfully"
            };
        }
    }
}
