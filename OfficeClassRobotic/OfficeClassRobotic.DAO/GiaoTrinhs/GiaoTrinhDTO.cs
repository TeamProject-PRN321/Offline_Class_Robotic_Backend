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

    public class GiaoTrinhPDFResponse
    {
        public Guid Id { get; set; }
        public string? GiaoTrinhName { get; set; }
        public string? Description { get; set; }
        public string? FilePDFName { get; set; }
        public byte[] FilePDF { get; set; }
        public string SubjectId { get; set; }
    }

    public class CreateGiaoTrinhCommand
    {
        public string? GiaoTrinhName { get; set; }
        public string? Description { get; set; }
        public List<CreateFilePDFs> ListFilePDFs { get; set; }
        public string SubjectId { get; set; }
    }

    public class CreateFilePDFs
    {
        public string? FilePDFName { get; set; }
        public byte[] FilePDF { get; set; }
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
