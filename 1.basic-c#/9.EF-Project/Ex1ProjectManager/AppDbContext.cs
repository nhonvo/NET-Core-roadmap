using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Projects> Projects { get; set; }
    public DbSet<Employees> Employees { get; set; }
    public DbSet<ProjectEmployee> ProjectEmployees { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=TRUONGNHON; Initial Catalog=testTracking; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true; User Id = TRUONGNHON; Password = 123");
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Projects>().HasKey(x => x.ProjectId);
        builder.Entity<Employees>().HasKey(x => x.EmployeeId);
        builder.Entity<ProjectEmployee>().HasKey(x => new { x.ProjectId, x.EmployeeId });

    }
}
