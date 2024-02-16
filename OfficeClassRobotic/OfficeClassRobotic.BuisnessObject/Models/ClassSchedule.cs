using Microsoft.EntityFrameworkCore;
using OfficeClassRobotic.BuisnessObject.Models;
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
    public class ClassSchedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassID { get; set; }
        /// <summary>
        /// Ngày học
        /// </summary>
        public DateTime DayStudy { get; set; }
        /// <summary>
        /// Số lượng học sinh
        /// </summary>
        public int NumberOfSudent { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }

        //   public int SubjectID { get; set; }

        // Khóa ngoại
        [ForeignKey("ClassSubject")]
        public int ClassSubjectID { get; set; }

        [ForeignKey("ClassRoom")]
        public int ClassRoomID { get; set; }

        // Quan hệ
        public virtual ClassSubject ClassSubject { get; set; }
        public virtual Classroom Classroom { get; set; }
    }
}

//  public string ClassName { get; set; }
//  public virtual TrungTamRobotic TrungTamRobotic { get; set; }
//  public double? MarkOfStudent { get; set; }

