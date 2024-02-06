

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public DateOnly Birthday { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? Created {  get; set; } 
        public string? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }

        public virtual IList<TrungTamRobotic> Robotics { get; set; }
    }
}
