using OfficeClassRobotic.BuisnessObject.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class GiaoTrinh : BaseAuditableEntity
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        //public int GiaoTrinhID { get; set; }
        public string? GiaoTrinhName { get; set; }
        public string? Description { get; set; }
        public string? FilePDF { get; set; }

        public virtual Subject? Subject { get; set; }
    }
}
