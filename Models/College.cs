using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace studentManagement.Models
{
    public class College
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students {get; set;}
        public ICollection<Course> Courses {get; set;}

    }
}
