using Microsoft.AspNetCore.Mvc;
using ASP_ADO_Student.Models;
using ASP_ADO_Student.Repositories;

namespace ASP_ADO_Student.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var students = _repository.GetAllStudents();

            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _repository.AddStudent(student);

                return RedirectToAction("Index");
            }

            return View(student);
        }
    }
}