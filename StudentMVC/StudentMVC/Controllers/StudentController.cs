using Microsoft.AspNetCore.Mvc;
using StudentMVC.Services;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var student = _service.GetStudent();
            return View(student);
        }
    }
}