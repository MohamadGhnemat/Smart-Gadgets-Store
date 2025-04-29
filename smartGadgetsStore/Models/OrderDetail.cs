using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }

        // العلاقة مع Order
        public int OrderID { get; set; }
        public Order Order { get; set; }

        // العلاقة مع Product
        public int ProductID { get; set; }
        public Product Product { get; set; }

        // الكمية التي تم شراؤها من المنتج

        public int Quantity { get; set; }

        // سعر الوحدة وقت الشراء
      
        public decimal UnitPrice { get; set; }
    }
}
