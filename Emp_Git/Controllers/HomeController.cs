using System.Diagnostics;
using Emp_Git.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emp_Git.Controllers
{
    public class HomeController : Controller
    {
        // This is my first GitHub change

        // Testing my new branch

        // "Testing my second branch"



        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Content("Testing my second branch");
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
    }
}
