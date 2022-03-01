using Microsoft.EntityFrameworkCore;

namespace studentManagement.Models
{
    public class StudentManagementContext:DbContext
    {
        public StudentManagementContext(DbContextOptions<StudentManagementContext> options) : base(options)
        {
        }

        public DbSet<Student> Students{ get; set; }
        public DbSet <College> Colleges {get; set;}
        public DbSet <Course> Courses {get; set;}
    }
}