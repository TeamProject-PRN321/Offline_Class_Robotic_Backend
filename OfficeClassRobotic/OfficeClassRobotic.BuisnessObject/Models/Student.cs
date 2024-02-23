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
        public string Name { get; set; }
        public string Address { get; set; }
        public DateOnly Birthday { get; set; }
        [ForeignKey("Parent")]
        public Guid ParentId { get; set; }

        public virtual Parent Parent { get; set; }
        public virtual IList<FeedBack> Feedbacks { get; set; }

        [Required]
        public Guid AppUserId { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
