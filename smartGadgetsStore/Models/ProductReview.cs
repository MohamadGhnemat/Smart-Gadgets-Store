using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.Models
{
    public class ProductReview
    {
        public int ProductReviewID { get; set; }

        public int ProductID { get; set; }

        public int UserID { get; set; }

  

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Range(1, 5)]
        public int Rating { get; set; }
        [MaxLength(1000)]
        public string ReviewText { get; set; }
    }
}
