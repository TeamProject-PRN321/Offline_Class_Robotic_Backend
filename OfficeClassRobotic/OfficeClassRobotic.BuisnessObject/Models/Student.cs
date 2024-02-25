using OfficeClassRobotic.BuisnessObject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeClassRobotic.BuisnessObject.Models.Common;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Student : BaseAuditableEntity
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        //public int StudentID { get; set; }
        public Guid ParentId { get; set; }

        [ForeignKey("AppUser")]
        public Guid AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }
        public ICollection<Class> Classs { get; set; }
    }
}
