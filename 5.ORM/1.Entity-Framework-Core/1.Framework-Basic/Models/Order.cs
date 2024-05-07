namespace _1.Entity_Framework_Core.Models;

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
}
