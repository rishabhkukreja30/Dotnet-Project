using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using studentManagement.Models;



public interface IRepository {

    Student getStudentsById();
}

