using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;
        static CategoryRepository() 
        {
            _categories = new List<Category>
            {
                new Category {CategoryId=1, Name = "Araba", Description = "Araba Kateggorisi"},
                new Category {CategoryId=2, Name = "Rocket", Description = "Rocket Kateggorisi"},
                new Category {CategoryId=3, Name = "Telefon", Description = "Telefon Kateggorisi"}
            };
        }
    

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategoryById(int id) 
        {
            return _categories.FirstOrDefault(p => p.CategoryId == id);
        }
    }
}
