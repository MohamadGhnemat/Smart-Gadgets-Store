using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.Models
{
    public class OrderItem
    {

        public int OrderItemID { get; set; }

        // العلاقة مع Order
        public int OrderID { get; set; }
        public Order Order { get; set; }

        // العلاقة مع Product
        public int ProductID { get; set; }
        public Product Product { get; set; }

        // الكمية المشتراة من المنتج
        
        public int Quantity { get; set; }

        // سعر الوحدة وقت الشراء
    
        public decimal UnitPrice { get; set; }

        // المجموع الكلي للعنصر في الطلب
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}
