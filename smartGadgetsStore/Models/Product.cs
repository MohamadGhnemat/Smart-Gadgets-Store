using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }

          [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int QuantityInStock { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string ImageURL { get; set; }

        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
