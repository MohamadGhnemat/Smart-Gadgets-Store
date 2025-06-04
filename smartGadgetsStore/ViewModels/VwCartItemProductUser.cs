using smartGadgetsStore.Models;

namespace smartGadgetsStore.ViewModels
{
    public class VwCartItemProductUser
    {
        public int CartItemID { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
        public List<User> lstUsers { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public List<Product> lstProducts { get; set; }

        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.Now;

    }
}
