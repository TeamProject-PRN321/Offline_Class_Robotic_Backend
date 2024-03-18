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
    public class Device : BaseAuditableEntity
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        //public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string? Description { get; set; }
        public double? PriceOfDevice { get; set; }
        /// <summary>
        /// 1. Bình thường, sử dụng được
        /// 2. Đang chờ sửa chữa
        /// 3. Không sử dụng được
        /// </summary>
        public int StatusOfDevice { get; set; }
        [ForeignKey("Classroom")]
        public Guid ClassRoomId { get; set; }

        public virtual Classroom Classroom { get; set; }
    }
}
