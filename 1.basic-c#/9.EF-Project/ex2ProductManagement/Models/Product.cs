public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
}
