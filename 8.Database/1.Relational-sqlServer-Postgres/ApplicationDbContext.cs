using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace _1.Relational_sqlServer_Postgres
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : DbContext(context)
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Name = "Principal",
                    DateRelease = DateTime.SpecifyKind(DateTime.Parse("2002/12/02 00:00:00"), DateTimeKind.Utc),
                },
                new Book
                {
                    Id = 2,
                    Name = "Implement",
                    DateRelease = DateTime.SpecifyKind(DateTime.Parse("2002/12/01 00:00:00"), DateTimeKind.Utc)
                }
            );
        }
    }
}