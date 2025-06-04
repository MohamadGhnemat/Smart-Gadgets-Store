using smartGadgetsStore.Models;
using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.ViewModels
{
    public class VwProductReviewUserProduct
    {
        public int ProductReviewID { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }
        public List<Product> lstProducts { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
        public List<User> lstUsers { get; set; }



        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Range(1, 5)]
        public int Rating { get; set; }
        [MaxLength(1000)]
        public string ReviewText { get; set; }
    }
}
