using System.Reflection;
using _1.Entity_Framework_Core.Models;
using Microsoft.EntityFrameworkCore;
namespace _1.Entity_Framework_Core;

public class AppDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Address> Addresses { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=truongnhon;Database=manageproduct;Trusted_Connection=true; MultipleActiveResultSets=true; TrustServerCertificate=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        DataSeeding(modelBuilder);
    }
    private static void DataSeeding(ModelBuilder builder)
    {
        builder.Entity<Customer>(o =>
        {
            o.HasData(new Customer { Id = 1, Name = "Nhon" });
        });
        builder.Entity<Address>(o =>
        {
            o.HasData(new Address { Id = 1, CustomerId = 1, Detail = "nha o binh dinh" });
        });
        builder.Entity<Product>(o =>
        {
            o.HasData(new Product { Id = 1, Name = "Ổi" });
        });
        builder.Entity<Order>(o =>
        {
            o.HasData(new Order { Id = 1,  CustomerId =1,        TotalAmount = 10});
        });
        builder.Entity<OrderDetail>(o =>
        {
            o.HasData(new OrderDetail { OrderId = 1, ProductId = 1 });
        });
    }
}
