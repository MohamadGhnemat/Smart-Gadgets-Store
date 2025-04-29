using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "Pending";

     
        public decimal TotalAmount { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
