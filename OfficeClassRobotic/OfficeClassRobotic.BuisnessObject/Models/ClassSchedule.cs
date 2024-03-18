using Microsoft.EntityFrameworkCore;
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
    /// <summary>
    /// Clas Schedule
    /// </summary>
    public class ClassSchedule : BaseAuditableEntity
    {
        /// <summary>
        /// Ngày học
        /// </summary>
        public DateTime DateStudy { get; set; }
        /// <summary>
        /// Số lượng học sinh
        /// </summary>
        public int NumberOfSudent { get; set; }

        // Khóa ngoại
        [ForeignKey("Class")]
        public Guid ClassId { get; set; }

        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

        [ForeignKey("Teacher")]
        public Guid TeacherId { get; set; }

        [ForeignKey("ClassRoom")]
        public Guid ClassRoomID { get; set; }

        // Quan hệ
        public virtual Class Class { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Teacher Teacher { get; set; }

    }
}


