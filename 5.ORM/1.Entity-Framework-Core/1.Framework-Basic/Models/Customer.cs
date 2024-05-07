namespace _1.Entity_Framework_Core.Models;

public class Customer    
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Order> Orders { get; set; }
    public Address Address { get; set; }
}
