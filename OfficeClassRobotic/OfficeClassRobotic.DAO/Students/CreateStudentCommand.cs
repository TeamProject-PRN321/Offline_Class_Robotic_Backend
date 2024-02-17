using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeClassRobotic.DAO.Students
{
    public class CreateStudentCommand
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public DateOnly Birthday { get; set; }
        
        public string ParentID { get; set; }
    }

    public class DeleteStudentCommand
    {
        public string StudentId { get; set; }
    }

    public class UpdateStudentCommand
    {
        public string StudentId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public DateOnly Birthday { get; set; }

        public string ParentID { get; set; }
    }

    public class StudentResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public DateOnly Birthday { get; set; }

        public Guid ParentId { get; set; }
        public DateTime? Created {  get; set; }
    }
}
