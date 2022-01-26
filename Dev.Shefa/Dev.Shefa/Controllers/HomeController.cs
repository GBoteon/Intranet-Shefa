using Dev.Shefa.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dev.Shefa.Controllers
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
        public IActionResult Rh()
        {
            return View();
        }
        public IActionResult Controladoria()
        {
            return View();
        }
        public IActionResult Financeiro()
        {
            return View();
        }
        public IActionResult Loja()
        {
            return View();
        }
        public IActionResult Marketing()
        {
            return View();
        }
        public IActionResult TI()
        {
            return View();
        }
        public IActionResult ST()
        {
            return View();
        }
        public IActionResult QA()
        {
            return View();
        }
        public IActionResult AgendarSala()
        {
            return View();
        }
        public IActionResult AgendarEquipamento()
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