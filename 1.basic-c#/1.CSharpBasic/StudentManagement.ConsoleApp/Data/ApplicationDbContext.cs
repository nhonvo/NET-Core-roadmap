using Microsoft.EntityFrameworkCore;
using StudentManagement.ConsoleApp.Models.CourseViewModel;
using StudentManagement.ConsoleApp.Models.GradeViewModel;
using StudentManagement.ConsoleApp.Models.StudentViewModel;
using StudentManagement.ConsoleApp.Models.StudentAddressViewModel;
using StudentManagement.ConsoleApp.Models.StudentCourseViewModel;

namespace StudentManagement.ConsoleApp.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=TRUONGNHON; Initial Catalog=studentdb; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true; User Id = TRUONGNHON; Password = 123");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // one to many relationship
            builder.Entity<Student>()
                .HasOne<Grade>(s => s.Grade)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GradeId);
            // .OnDelete(DeleteBehavior.Cascade);

            // one to one relationship
            builder.Entity<Student>()
            .HasOne<StudentAddress>(s => s.Address)
            .WithOne(ad => ad.Student)
            .HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);

            // many to many relationship
            builder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.Entity<StudentCourse>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            builder.Entity<StudentCourse>()
                .HasOne<Course>(sc => sc.Course)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);

            // Data seed
            builder.Entity<Grade>().HasData(
                new Grade { Id = 1, Name = "University", Section = "A" },
                new Grade { Id = 2, Name = "High school", Section = "B" },
                new Grade { Id = 3, Name = "Low school", Section = "C" });

            builder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "John", GradeId = 1 },
                new Student { Id = 2, Name = "Jane", GradeId = 2 },
                new Student { Id = 3, Name = "Jim", GradeId = 3 }
            );
            builder.Entity<StudentAddress>().HasData(
                new StudentAddress { Id = 1, Address = "123 Main St", City = "New York", State = "NY", Country = "USA", AddressOfStudentId = 1 },
                new StudentAddress { Id = 2, Address = "456 Elm St", City = "Los Angeles", State = "CA", Country = "USA", AddressOfStudentId = 2 },
                new StudentAddress { Id = 3, Address = "789 Oak St", City = "Chicago", State = "IL", Country = "USA", AddressOfStudentId = 3 }
            );
            builder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Mathematics", Description = "This is a Mathematics course" },
                new Course { Id = 2, Name = "Science", Description = "This is a Science course" },
                new Course { Id = 3, Name = "History", Description = "This is a History course" }
            );

            builder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentId = 1, CourseId = 1 },
                new StudentCourse { StudentId = 1, CourseId = 2 },
                new StudentCourse { StudentId = 2, CourseId = 2 },
                new StudentCourse { StudentId = 2, CourseId = 3 },
                new StudentCourse { StudentId = 3, CourseId = 1 }
            );
        }


    }
}