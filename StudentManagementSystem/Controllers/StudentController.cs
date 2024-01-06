using Microsoft.AspNetCore.Mvc;

using StudentManagementSystem.Interfaces;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _studentRepo;
        public StudentController(IStudent studentRepo)
        {
            _studentRepo = studentRepo;
        }
        public IActionResult Index()
        {
            return View(_studentRepo.GetStudents());
        }

        public IActionResult Details(string id)
        {
            return View(_studentRepo.Details(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("StudentNumber, FirstName , LastName , Course , EnrollmentDate ")]Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _studentRepo.Create(student);
                }
            }
            catch { }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            return View(_studentRepo.Details(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("StudentNumber, FirstName , LastName , Course , EnrollmentDate ")] Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _studentRepo.Edit(student);
                }
            }
            catch { }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            return View(_studentRepo.Details(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([Bind("StudentNumber, FirstName, LastName, Course , EnrollmentDate ")] Student student)
        {
            _studentRepo.Delete(student);
            return RedirectToAction(nameof(Index));
        }

    }
}
