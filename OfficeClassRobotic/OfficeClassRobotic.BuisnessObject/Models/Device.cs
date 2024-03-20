using OfficeClassRobotic.BuisnessObject.Models;
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
        public double? PriceOfDevice { get; set; }
        /// <summary>
        /// 0. Bình thường, sử dụng được
        /// 1. Đã được mượn
        /// 2. Đang chờ sửa chữa
        /// 3. Không sử dụng được
        /// </summary>
        public int StatusOfDevice { get; set; }

        [ForeignKey("DeviceCategory")]
        public Guid DeviceCategoryId { get; set; }


        public virtual DeviceCategory DeviceCategory { get; set; }
    }
}
