using Microsoft.EntityFrameworkCore;

namespace StudentManage.ConsoleApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Score> Scores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=TRUONGNHON; Initial Catalog=studentconsoledb; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true; User Id = TRUONGNHON; Password = 123");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Class>().HasKey(x => x.ID);
            builder.Entity<Student>().HasKey(x => x.ID);
            builder.Entity<Subject>().HasKey(x => x.ID);
            builder.Entity<Score>().HasKey(x => x.ID);
            builder.Entity<Student>()
                .HasOne(x => x.Class)
                .WithMany(x => x.Students)
                .HasForeignKey(x => x.ClassID);
            builder.Entity<Score>()
                .HasOne(x => x.Subject)
                .WithMany(x => x.Scores)
                .HasForeignKey(x => x.SubjectID);
            builder.Entity<Score>()
                .HasOne(x => x.Student)
                .WithMany(x => x.Scores)
                .HasForeignKey(x => x.StudentID);
        }
    }
}