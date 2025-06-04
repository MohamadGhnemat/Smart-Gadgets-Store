using smartGadgetsStore.Models;
using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.ViewModels
{
    public class VwOrderUser
    {

        public int OrderID { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
        public List<User> lstUsers { get; set; }

  
        [MaxLength(20)]
        public string Status { get; set; } = "Pending";


        public decimal TotalAmount { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

    }
}
