using Microsoft.AspNetCore.Mvc;
using ASP_ADO.Models;
using ASP_ADO.Repositories;

namespace ASP_ADO.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        // Display all employees
        public IActionResult Index()
        {
            var employees = _repository.GetAllEmployees();
            return View(employees);
        }

        // Load Create Employee page
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Save Employee
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _repository.AddEmployee(employee);
                return RedirectToAction("Index");
            }

            return View(employee);
        }
    }
}
