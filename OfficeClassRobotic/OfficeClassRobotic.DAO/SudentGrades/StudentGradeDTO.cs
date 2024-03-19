using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.SudentGrades
{
    public class StudentGradeDTO
    {
        public string? ClassName { get; set; }
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public List<GradeSubjectOfStudent> GradeSubjectOfStudents { get; set; }
    }

    public class GradeSubjectOfStudent
    {
        public Guid SubjetcId { get; set; }
        /// <summary>
        /// Dạng kiểm tra : Kiểm tra 15P, Kiểm tra kết thúc môn
        /// </summary>
        public string? AssesessmentType { get; set; }
        /// <summary>
        /// % của mỗi dạng kiểm tra
        /// Ví dụ: 
        /// Kiểm tra 15p : 15%
        /// Kiểm tra 1 tiết lần 1: 20%
        /// </summary>
        public int WeightPercentage { get; set; }

        public double Grade { get; set; }
    }
}
