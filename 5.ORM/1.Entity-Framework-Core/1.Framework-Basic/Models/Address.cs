namespace _1.Entity_Framework_Core.Models;

public class Address
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public string Detail { get; set; }
}
