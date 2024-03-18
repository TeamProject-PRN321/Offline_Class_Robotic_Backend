using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.BuisnessObject.Models.Common
{
    public abstract class BaseAuditableEntity : BaseEntities, ISoftDelete
    {
        public DateTime Created { get; set; }

        public string? CreateBy { get; set; }

        public DateTime? LastModified { get; set; }

        public string? LastModifiedBy { get; set; }

        public bool IsDeleted { get; set; }

        protected BaseAuditableEntity()
        {
            Created = DateTime.Now;
            IsDeleted = false;
        }
    }
}
