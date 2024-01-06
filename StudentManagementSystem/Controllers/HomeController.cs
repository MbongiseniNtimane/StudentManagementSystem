using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;
using StudentManagementSystem.Interfaces;
using StudentManagementSystem.Models;
using System.Diagnostics;

namespace StudentManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SQliteDbContext _context;
        private readonly IDBInitializer _seedDatabase;
        //Constructor Injection
        public HomeController(ILogger<HomeController> logger, SQliteDbContext context, IDBInitializer seedDatabase)
        {
            _logger = logger;
            _context = context;
            _seedDatabase = seedDatabase;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SeedDatabase()
        {
            _seedDatabase.Initialize(_context);
            ViewBag.SeedDbFeedback = "Database created and Student Table populated with Data.Check Database folder. ";
            return View("SeedDatabase");
        }
    }
}