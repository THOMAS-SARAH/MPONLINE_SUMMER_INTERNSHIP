using ASP_Registration.AppHost.Repositories;
using ASP_Registration.Models;
using ASP_Registration.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Registration.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        // Display all users
        public IActionResult Index()
        {
            var users = _repository.GetAllUsers();
            return View(users);
        }

        // Registration Page
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Save User
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _repository.AddUser(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // Edit User Page
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = _repository.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // Update User
        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdateUser(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // Delete User
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _repository.DeleteUser(id);
            return RedirectToAction("Index");
        }
    }
}
