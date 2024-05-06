using System.Reflection;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    // public DbSet<Order> Orders { get; set; }
    // public DbSet<Product> Products { get; set; }
    // public DbSet<OrderDetail> OrderDetails { get; set; }
    // public DbSet<Customer> Customers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=TRUONGNHON; Initial Catalog=productmanage; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true; User Id = TRUONGNHON; Password = 123");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
}
public class Address
{
    public int Id { get; set; }
    public string Detail { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Post> Posts { get; set; }
}
public class Post
{
    public int Id { get; set; }
    public string Detail { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public ICollection<Tag> Tags { get; set; }
}
public class Tag
{
    public int Id { get; set; }
    public int Name { get; set; }
    public int PostId { get; set; }
    public Post Post { get; set; }
}
