using System.ComponentModel.DataAnnotations;

namespace smartGadgetsStore.Models
{
    public class UserType
    {
        public int UserTypeID { get; set; }
        [Display(Name = "Role")]
        public string Name { get; set; }
    }
}
