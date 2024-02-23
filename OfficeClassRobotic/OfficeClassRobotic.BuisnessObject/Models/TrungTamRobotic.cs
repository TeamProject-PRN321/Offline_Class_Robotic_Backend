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
    public class TrungTamRobotic : BaseAuditableEntity
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        //public int TrungTamRoboticID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [ForeignKey("Admin")]
        public Guid AdminId { get; set; }
        [Required]
        public Guid AppUserId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual IList<Staff> Staffs { get; set; }
        public virtual IList<Classroom> Classrooms { get; set; }
    }
}
