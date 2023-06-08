using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Testing_N_Tier.Domain.Interfaces;
using Testing_N_Tier.MVC.Models;

namespace Testing_N_Tier.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICostumerService _service;

        public HomeController(ILogger<HomeController> logger, ICostumerService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetByNames());
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