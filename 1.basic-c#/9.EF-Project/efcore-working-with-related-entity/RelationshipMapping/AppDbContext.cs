using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Address> Addresss { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connect = "Data Source=TRUONGNHON; Initial Catalog=RelationshipMapping; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true; User Id = TRUONGNHON; Password = 123";
        optionsBuilder.UseSqlServer(connect);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
                    .HasOne(c => c.Address)
                    .WithOne(o => o.Customer)
                    .HasForeignKey<Address>(ad => ad.CustomerId);

        // config customer with order
        modelBuilder.Entity<Customer>()
                    .HasMany(c => c.Orders)
                    .WithOne(o => o.Customer)
                    .HasForeignKey(o => o.CustomerId);

        // config order with order detail
        modelBuilder.Entity<OrderDetail>()
                    .HasOne(od => od.Order)
                    .WithMany(o => o.OrderDetails)
                    .HasForeignKey(od => od.OrderId);

        modelBuilder.Entity<OrderDetail>()
                    .HasOne(od => od.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(od => od.OrderId);

        modelBuilder.Entity<OrderDetail>().HasKey(sc => new { sc.OrderId, sc.ProductId });
    }
}

public class Address
{
    public int Id { get; set; }
    public string Detail { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public ICollection<Order> Orders { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
}

public class OrderDetail
{
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public int ProductName { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
}

