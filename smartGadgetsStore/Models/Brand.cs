using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.Models
{
    public class Brand
    {

    public int BrandId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "BrandName")]
        public string Name { get; set; }

    public string Country { get; set; }


    }
}
