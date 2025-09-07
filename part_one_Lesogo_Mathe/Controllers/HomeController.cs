using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using part_one_Lesogo_Mathe.Models;

namespace part_one_Lesogo_Mathe.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();
        }
        public IActionResult home()
        {
            return View();
        }
        public IActionResult claim()
        {
            return View();
        }


        public IActionResult track()
        {
            return View();
        }

        public IActionResult Pre_approve()
        {
            return View();
        }

        public IActionResult Approve()
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
