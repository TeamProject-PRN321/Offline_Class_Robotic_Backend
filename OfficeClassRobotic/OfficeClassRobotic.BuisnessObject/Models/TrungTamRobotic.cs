using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class TrungTamRobotic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrungTamRoboticID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
        [ForeignKey("Admin")]
        public int AdminID { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual IList<Class> Classes { get; set; }
        public virtual IList<Staff> Staffs { get; set; }
        public virtual IList<Classroom> Classrooms { get; set; }
    }
}
