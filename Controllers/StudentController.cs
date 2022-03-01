using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;



[ApiController]
[Route("[controller]")]

public class studentController : ControllerBase {

    private IRepository _repository;
    public studentController (IRepository repository) {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetStudents() {
        return Ok(_repository.getStudentsById());
    }


}

