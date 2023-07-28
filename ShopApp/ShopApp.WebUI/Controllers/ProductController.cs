using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {           
            return View();
        }

        public IActionResult List(int? id, string q) 
        {

            //Console.WriteLine(HttpContext.Request.Query["q"].ToString());


            var products = ProductRepository.Products;
            if (id!=null)
            {
                products = products.Where(p=>p.CategoryId==id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                //burada to lowerları biyük küçük harf gözetmeksizin arasın diye kullandık
                products = products.Where(i=>i.Name.ToLower().Contains(q.ToLower()) || i.Description.Contains(q)).ToList();
            }

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }

        public IActionResult Details(int id) 
        {

            return View(ProductRepository.GetProductById(id));
        }

        public IActionResult Create(string name, double price) 
        {
            Console.WriteLine(name);
            Console.WriteLine(price);
            return View();
        }
    }
}
