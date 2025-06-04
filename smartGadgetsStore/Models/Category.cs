using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required]
        [MaxLength(100)]

        [Display(Name = "CategoryName")]
        public string Name { get; set; }

        public string Description { get; set; }
   

    }
}
