namespace _1.Entity_Framework_Core.Models;

public class OrderDetail
{
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}
