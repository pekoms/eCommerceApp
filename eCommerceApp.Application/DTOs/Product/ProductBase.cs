namespace eCommerceApp.Application.DTOs.Product
{
    public class ProductBase
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public int Quatity { get; set; }
        public Guid CategoryId { get; set; }
    }
}
