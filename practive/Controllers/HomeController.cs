using Microsoft.AspNetCore.Mvc;
using practive.Models;
using System.Diagnostics;

namespace practive.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /* Có 3 cách để truyền dữ liệu từ Controller sang view
        Casch1 : Sử dụng ViewData
        Cách 2: Sử dụng viewBag
        c3: Sử dụng tempdata
        */
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
    }
}