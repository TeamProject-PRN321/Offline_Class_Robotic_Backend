using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.Parents
{
    public class CreateParentCommand
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateOnly Birthday { get; set; }
    }

    public class UpdateParentCommand
    {
        public string ParentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateOnly Birthday { get; set; }
    }

    public class DeleteParentCommand
    {
        public string ParentId { get; set; }
    }

    public class ParentResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateOnly Birthday { get; set; }
        public DateTime? Created { get; set; }
    }

}
