using OfficeClassRobotic.DAO.Parents;

namespace OfficeClassRobotic.Repository.Parents
{
    public class ParentRepostitory : IParentRepostitory
    {
        private ParentDAO parentDAO;
        public ParentRepostitory()
        {
            parentDAO = new ParentDAO();
        }
        public async Task CreateParent(ParentDTO parent)
        {
            await parentDAO.CreateParent(parent);
        }
    }
}
