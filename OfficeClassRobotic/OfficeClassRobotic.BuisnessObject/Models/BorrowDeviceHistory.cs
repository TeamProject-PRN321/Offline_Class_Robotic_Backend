﻿using Models.OfficeClassRobotic.BuisnessObject;
using OfficeClassRobotic.BuisnessObject.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeClassRobotic.BuisnessObject.Models
{
    public class BorrowDeviceHistory : BaseAuditableEntity
    {
        /// <summary>
        /// Mượn device nào
        /// </summary>
        [ForeignKey("Device")]
        public Guid DeviceId { get; set; }
        [ForeignKey("DeviceCategory")]
        public Guid DeviceCategoryId { get; set; }  
        [ForeignKey("BorrowDevice")]
        public Guid BorrowDeviceId { get; set; }    

        //public int Quantity { get; set; }

        public virtual Device Device { get; set; }
        public virtual DeviceCategory DeviceCategory { get; set; }
        public virtual BorrowDevice BorrowDevice { get; set; }
    }
}
