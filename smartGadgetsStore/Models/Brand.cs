namespace smartGadgetsStore.Models
{
    public class Brand
    {

    public int BrandId { get; set; }
        public string Name { get; set; }

        public string Country { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
