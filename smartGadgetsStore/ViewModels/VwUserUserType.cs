using smartGadgetsStore.Models;
using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.ViewModels
{
    public class VwUserUserType
    {

        public int UserID { get; set; }
     
        [MaxLength(50)]
        public string UserName { get; set; }
      
        [MaxLength(100)]
        public string? FullName { get; set; }


        [MaxLength(255)]
        public string PasswordHash { get; set; }
        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        public int UserTypeID { get; set; }


        public UserType UserType { get; set; }
        public List<UserType> lstUserTypes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;


        [Required]
        [EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; }


    }
}
