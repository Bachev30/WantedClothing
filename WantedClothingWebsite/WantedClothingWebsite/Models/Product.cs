namespace WantedClothingWebsite.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // e.g., Men, Women, Limited
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
