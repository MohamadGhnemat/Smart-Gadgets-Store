using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.Models
{
    public class ProductReview
    {
        public int ReviewID { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        [MaxLength(1000)]
        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Range(1, 5)]
        public int Rating { get; set; } 
    }
}
