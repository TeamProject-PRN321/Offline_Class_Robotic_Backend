using OfficeClassRobotic.DAO.Parents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.Repository.Parents
{
    public interface IParentRepostitory
    {
        public Task CreateParent(ParentDTO parent);
    }
}
