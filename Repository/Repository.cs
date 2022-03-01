using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using studentManagement.Models;



public class Repository : IRepository {

    private StudentManagementContext _context;
    public Repository (StudentManagementContext context) {
        _context = context;
    }



    public Student getStudentsById()
    {
        long id = 1;
       return _context.Students.Find(id);
    }
}