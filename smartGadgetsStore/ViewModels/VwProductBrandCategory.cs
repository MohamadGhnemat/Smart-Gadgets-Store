using smartGadgetsStore.Models;
using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.ViewModels
{
    public class VwProductBrandCategory
    {
        public int ProductID { get; set; }


        [MaxLength(150)]
        [Display(Name = "ProductName")]
        public string Name { get; set; }

        public string? Description { get; set; }

        public int QuantityInStock { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string? ImageURL { get; set; }
    
        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        public List<Brand> lstBrands { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Category> lstCategories { get; set; }

    }
}
