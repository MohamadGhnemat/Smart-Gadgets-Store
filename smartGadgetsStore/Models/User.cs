using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; }
        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(20)]
        public string Role { get; set; } = "customer";
        [Required]
        [EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; }

         public ICollection<Order> Orders { get; set; }
        public ICollection<ProductReviews> Reviews { get; set; }
        public ICollection<CartItem> CartItems { get; set; }

    }
}
