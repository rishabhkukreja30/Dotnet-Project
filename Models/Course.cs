using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace studentManagement.Models
{
    public class Course
    {
        public long Id { get; set; }
        public string Name { get; set; }


    }
}
