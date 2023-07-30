using System.ComponentModel.DataAnnotations;

namespace ShopApp.WebUI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(60, MinimumLength =10, ErrorMessage ="Ürün ismi 10-60 karakter arasında olmalıdır.")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Fiyat girmelisin!")]
        [Range(1,100000)]
        public double Price { get; set; }
        [Required(ErrorMessage ="Açıklama giriniz!")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Resim Url'si giriniz!")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
