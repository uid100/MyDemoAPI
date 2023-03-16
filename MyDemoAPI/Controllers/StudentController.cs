using Microsoft.AspNetCore.Mvc;
using MyDemoAPI.Models;

namespace MyDemoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private static readonly List<Student> _students = Student.GetStudents();

        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetStudentList")]
        public IEnumerable<Student> Get() => Student.GetStudents();
    }
}