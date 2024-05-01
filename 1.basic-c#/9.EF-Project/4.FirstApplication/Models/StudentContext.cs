using Microsoft.EntityFrameworkCore;


namespace _4.FirstApplication.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CVPNHONVTT; Initial Catalog=schooldb; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}