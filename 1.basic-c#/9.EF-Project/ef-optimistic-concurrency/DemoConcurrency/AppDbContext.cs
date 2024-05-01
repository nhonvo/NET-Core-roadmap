using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{

    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connect = "Data Source=TRUONGNHON; Initial Catalog=DemoDB; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true; User Id = TRUONGNHON; Password = 123";
        optionsBuilder.UseSqlServer(connect);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
                    .Property(x => x.Name)
                    .HasMaxLength(100);

        modelBuilder.Entity<Customer>()
                    .Property(x => x.Wallet)
                    .HasColumnType("money")
                    .IsConcurrencyToken(); // mark as uptimistic concurrency check
    }
}