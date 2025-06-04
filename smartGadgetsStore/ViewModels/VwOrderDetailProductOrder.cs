using Microsoft.AspNetCore.Mvc.Rendering;
using smartGadgetsStore.Models;

namespace smartGadgetsStore.ViewModels
{
    public class VwOrderDetailProductOrder
    {
        public int OrderDetailID { get; set; }


        public int OrderID { get; set; }

        public Order Order { get; set; }
        public List<Order> lstOrders { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public List<Product> lstProducts { get; set; }
        public int Quantity { get; set; }

        public string OrderDisplayName => $"Order #{OrderID} - {Order?.User?.FullName}";
        public List<SelectListItem> OrderSelectList => lstOrders
    .Select(o => new SelectListItem
    {
        Value = o.OrderID.ToString(),
        Text = $"Order #{o.OrderID} - {o.User?.FullName}"
    }).ToList();

        public decimal UnitPrice { get; set; }
     //   public decimal TotalPrice => UnitPrice * Quantity;
    }
}
