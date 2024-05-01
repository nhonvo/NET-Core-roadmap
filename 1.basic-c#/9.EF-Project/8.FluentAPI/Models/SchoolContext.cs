using Microsoft.EntityFrameworkCore;

public class SchoolContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=CVPNHONVTT; Initial Catalog=testschooldb; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // one to many relationship
        modelBuilder.Entity<Student>()
            .HasOne<Grade>(s => s.Grade)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.CurrentGradeId);
        // .OnDelete(DeleteBehavior.Cascade);

        // one to one relationship
        modelBuilder.Entity<Student>()
        .HasOne<StudentAddress>(s => s.Address)
        .WithOne(ad => ad.Student)
        .HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);

        // many to many relationship
        modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });

        modelBuilder.Entity<StudentCourse>()
            .HasOne<Student>(sc => sc.Student)
            .WithMany(s => s.StudentCourses)
            .HasForeignKey(sc => sc.StudentId);

        modelBuilder.Entity<StudentCourse>()
            .HasOne<Course>(sc => sc.Course)
            .WithMany(s => s.StudentCourses)
            .HasForeignKey(sc => sc.CourseId);

        // Data seed
        modelBuilder.Entity<Grade>().HasData(
            new Grade { GradeId = 1, GradeName = "A", Section = "abc1" },
            new Grade { GradeId = 2, GradeName = "B", Section = "abc2" },
            new Grade { GradeId = 3, GradeName = "C", Section = "abc3" });

        modelBuilder.Entity<Student>().HasData(
            new Student { Id = 1, Name = "John", CurrentGradeId = 1 },
            new Student { Id = 2, Name = "Jane", CurrentGradeId = 2 },
            new Student { Id = 3, Name = "Jim", CurrentGradeId = 3 }
        );
        modelBuilder.Entity<StudentAddress>().HasData(
           new StudentAddress { Id = 1, Address = "123 Main St", City = "New York", State = "NY", Country = "USA", AddressOfStudentId = 1 },
           new StudentAddress { Id = 2, Address = "456 Elm St", City = "Los Angeles", State = "CA", Country = "USA", AddressOfStudentId = 2 },
           new StudentAddress { Id = 3, Address = "789 Oak St", City = "Chicago", State = "IL", Country = "USA", AddressOfStudentId = 3 }
       );
        modelBuilder.Entity<Course>().HasData(
            new Course { CourseId = 1, CourseName = "Mathematics", Description = "This is a Mathematics course" },
            new Course { CourseId = 2, CourseName = "Science", Description = "This is a Science course" },
            new Course { CourseId = 3, CourseName = "History", Description = "This is a History course" }
        );

        modelBuilder.Entity<StudentCourse>().HasData(
            new StudentCourse { StudentId = 1, CourseId = 1 },
            new StudentCourse { StudentId = 1, CourseId = 2 },
            new StudentCourse { StudentId = 2, CourseId = 2 },
            new StudentCourse { StudentId = 2, CourseId = 3 },
            new StudentCourse { StudentId = 3, CourseId = 1 }
        );
    }

    public DbSet<Grade> Grades { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentAddress> StudentAddresses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
}