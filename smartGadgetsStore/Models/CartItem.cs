using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.Models
{
    public class CartItem
    {
        public int CartItemID { get; set; }

        // العلاقة مع User
        public int UserID { get; set; }
        public User User { get; set; }

        // العلاقة مع Product
        public int ProductID { get; set; }
        public Product Product { get; set; }

        // الكمية التي تم إضافتها إلى السلة
        
        public int Quantity { get; set; }
    }
}
