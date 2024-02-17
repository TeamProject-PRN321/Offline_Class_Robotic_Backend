

using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Admin : BaseAuditableEntity
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        //public int AdminID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public DateOnly Birthday { get; set; }

        public virtual IList<TrungTamRobotic> TrungTamRobotic { get; set; }
    }
}
