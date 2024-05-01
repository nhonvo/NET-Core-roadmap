using ex2ProductManagement.Repository;

public class Customer : Base    
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Order> Orders { get; set; }
    public Address Address { get; set; }
}
