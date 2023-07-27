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
            var product = new Product
            {
                Name = "Aroma",
                Price = 9599,
                Description = "Ph derecesi 8.15 su"
            };
            //ViewData["Category"] = "Sular";
            //ViewData["Product"] = product;


            ViewBag.Kategori = "Suuular";
            ViewBag.okok = product;
            

            return View(product);
        }

        public IActionResult List(int? id) 
        {
           

            var products = ProductRepository.Products;
            if (id!=null)
            {
                products = products.Where(p=>p.CategoryId==id).ToList();
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
    }
}
