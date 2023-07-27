namespace Orders.API.Dtos
{
    public class OrdersDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<ProductsDto> Products { get; set; }  = new List<ProductsDto>();
    }
}
