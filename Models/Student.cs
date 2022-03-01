using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace studentManagement.Models
{
    public class Student
    {
        [Key]
        public long Id { get; set; }
        public long RollNo {get; set;}
        public string Name { get; set; }

        public ICollection <Course> Courses {get; set;}
    }
}
