using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;
        static ProductRepository() 
        {
            _products = new List<Product>
            {
                new Product {ProductId = 1, Name = "Tesla ModelX", Price = 46854, Description= "Kaliteli", IsApproved=true, ImageUrl="1.png", CategoryId=1},
                new Product {ProductId = 2, Name = "Tesla ModelY", Price = 48484, Description = "Eh işte", IsApproved = true, ImageUrl="2.png", CategoryId=1},
                new Product {ProductId = 3, Name = "Tesla ModelZ", Price = 78449, Description = "İyi", IsApproved = false, ImageUrl="3.png", CategoryId=1},
                new Product {ProductId = 4, Name = "Tesla ModelW", Price = 48484, Description = "Oluru var", IsApproved = false, ImageUrl="4.png", CategoryId=1},

                new Product {ProductId = 5, Name = "FALCON 9", Price = 46854, Description= "FIRST ORBITAL CLASS ROCKET CAPABLE OF REFLIGHT", IsApproved=true, ImageUrl="5.jpg", CategoryId=2},
                new Product {ProductId = 6, Name = "FALCON HEAVY", Price = 48484, Description = "OVER 5 MILLION LBS OF THRUST", IsApproved = true, ImageUrl="6.jpg", CategoryId=2},
                new Product {ProductId = 7, Name = "DRAGON", Price = 78449, Description = "SENDING HUMANS AND CARGO INTO SPACE", IsApproved = false, ImageUrl="7.jpg", CategoryId=2},
                new Product {ProductId = 8, Name = "STARSHIP", Price = 48484, Description = "SERVICE TO EARTH ORBIT, MOON, MARS AND BEYOND", IsApproved = false, ImageUrl="8.jpg", CategoryId=2}
            };
        }
    

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id) 
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }

        public static void EditProduct(Product product)
        {
            foreach(var p in _products) 
            {
                if (p.ProductId == product.ProductId)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.ImageUrl = product.ImageUrl;
                    p.Description = product.Description;
                    p.IsApproved = product.IsApproved;
                    p.CategoryId = product.CategoryId;
                }
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);

            if (product != null)
            {
                _products.Remove(product); 
            }
        }
    }
}
