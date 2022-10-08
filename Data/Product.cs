namespace WebApiEntityFrameworkDockerSqlServer.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? SKU { get; set; }
        public string? Code { get; set; }
    }
}