﻿using OfficeClassRobotic.BuisnessObject.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.OfficeClassRobotic.BuisnessObject
{
    public class Classroom : BaseAuditableEntity
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        //public int ClassRoomID { get; set; }
        public string ClassName { get; set; }
        public string? Description { get; set; }
        [ForeignKey("TrungTamRobotic")]
        public Guid TrungTamRoboticId { get; set; }

        public virtual TrungTamRobotic TrungTamRobotic { get; set; }
        public virtual IList<Device> Devices { get; set; }
    }
}
