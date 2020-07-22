namespace OrderModule.Models.Products
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int TenantId { get; set; }
        public int? ProductManufacturerId { get; set; }
        public string ProductCode { get; set; }
        public bool NewProduct { get; set; }
        public bool SaleProduct { get; set; }
        public bool SellingProduct { get; set; }
        public string Image { get; set; }
    }
}
