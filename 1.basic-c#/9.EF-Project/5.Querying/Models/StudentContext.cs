using Microsoft.EntityFrameworkCore;


namespace _5.Querying.Models
{

    public class StudentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Data Source=CVPNHONVTT; Initial Catalog=schooldb; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer("Data Source=TRUONGNHON; Initial Catalog=schooldb; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true; User Id = TRUONGNHON; Password = 123");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)

        {
            builder.Entity<Student>().HasData(
                new Student { FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(2002, 5, 5), Height = 5.5m, Weight = 140f, GradeId = 1 },
                new Student { FirstName = "Jane", LastName = "Doe", DateOfBirth = new DateTime(2003, 6, 6), Height = 5.2m, Weight = 110f, GradeId = 2 },
                new Student { FirstName = "Tom", LastName = "Smith", DateOfBirth = new DateTime(2004, 7, 7), Height = 4.8m, Weight = 90f, GradeId = 3 }
            );
            builder.Entity<Grade>().HasData(
                new Grade { GradeName = "Grade 1", Section = "A" },
                new Grade { GradeName = "Grade 2", Section = "B" },
                new Grade { GradeName = "Grade 3", Section = "C" }
            );
        }

    }
}