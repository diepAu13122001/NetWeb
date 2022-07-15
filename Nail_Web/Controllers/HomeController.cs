using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Nail_Web.Models;

namespace Nail_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: Home/Contact
        public IActionResult Contact()
        {
            return View("Contact");
        }

        // GET: Home/News
        public IActionResult News()
        {
            return View("News");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}