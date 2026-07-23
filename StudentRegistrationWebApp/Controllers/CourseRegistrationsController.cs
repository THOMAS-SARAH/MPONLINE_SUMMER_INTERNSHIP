using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentRegistrationWebApp.Data;
using StudentRegistrationWebApp.Models;

namespace StudentRegistrationWebApp.Controllers
{
    public class CourseRegistrationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseRegistrationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var registrations = _context.CourseRegistrations
                .Include(r => r.Course)
                .Include(r => r.StudentProfile);

            return View(await registrations.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewBag.Courses = new SelectList(_context.Courses, "Id", "CourseName");
            ViewBag.Students = new SelectList(_context.StudentProfiles, "Id", "FullName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseRegistration registration)
        {
            if (ModelState.IsValid)
            {
                _context.CourseRegistrations.Add(registration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Courses = new SelectList(_context.Courses, "Id", "CourseName");
            ViewBag.Students = new SelectList(_context.StudentProfiles, "Id", "FullName");

            return View(registration);
        }
    }
}