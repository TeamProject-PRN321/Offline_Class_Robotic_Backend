using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.GiaoTrinhs
{
    public class GiaoTrinhResponse
    {
        public Guid Id { get; set; }
        public string? GiaoTrinhName { get; set; }
        public string? Description { get; set; }
        public string? FilePDF { get; set; }
        public DateTime Created { get; set; }
    }

    public class CreateGiaoTrinhCommand
    {
        public string? GiaoTrinhName { get; set; }
        public string? Description { get; set; }
        public string? FilePDF { get; set; }
    }

    public class UpdateGiaoTrinhCommand
    {
        public string GiaoTrinhId { get; set; }
        public string? GiaoTrinhName { get; set; }
        public string? Description { get; set; }
        public string? FilePDF { get; set; }
    }

    public class DeleteGiaoTrinhCommand
    {
        public string GiaoTrinhId { get; set; }
    }
}
