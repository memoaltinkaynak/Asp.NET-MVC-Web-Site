using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System.Diagnostics;

namespace ShopApp.WebUI.Controllers
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
            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
            };

            return View(productViewModel);
        }

        public IActionResult Details()
        {
            var p = new Product();

            p.Name = "Spacex";
            p.Price = 4685454;
            p.Description = "Rocket";


            return View(p);
        }

        public IActionResult About(int id) 
        {
            ViewBag.Name = "Tesla";
            ViewBag.Price = 468595;
            ViewBag.Description = "Elektrikli araba";

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