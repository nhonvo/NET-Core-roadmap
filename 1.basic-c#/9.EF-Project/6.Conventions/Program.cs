using Microsoft.EntityFrameworkCore;
// Convention1: this still can create foreign keys gradeid in student table 
// public class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public Grade Grade { get; set; }
// }

// public class Grade
// {
//     public int GradeId { get; set; }
//     public string GradeName { get; set; }
//     public string Section { get; set; }
// }
// Convention 2: include a collection navigation property in the principal entity as shown below.

// public class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
// }

// public class Grade
// {
//     public int GradeId { get; set; }
//     public string GradeName { get; set; }
//     public string Section { get; set; }

//     public ICollection<Student> Students { get; set; }
// }
// Convention 3: include navigation property at both ends, which will also result in a one-to-many relationship (convention 1 + convention 2).
// public class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     public Grade Grade { get; set; }
// }

// public class Grade
// {
//     public int GradeID { get; set; }
//     public string GradeName { get; set; }

//     public ICollection<Student> Students { get; set; }
// }

// Convention 4: fully at both ends with the foreign key property in the dependent entity creates a one-to-many relationship.


// one-to-one relationship : student with student addresses
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int GradeId { get; set; }
    public Grade Grade { get; set; }
    public StudentAddress Address { get; set; }
}

public class Grade
{
    public int GradeId { get; set; }
    public string GradeName { get; set; }

    public ICollection<Student> Students { get; set; }
}

public class StudentAddress
{
    public int StudentAddressId { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }
}
public class StudentContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=TRUONGNHON; Initial Catalog=testdb; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true; User Id = TRUONGNHON; Password = 123");
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<StudentAddress> Addresses { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Grade>().HasData(
            new Grade { GradeId = 1, GradeName = "A" },
            new Grade { GradeId = 2, GradeName = "B" },
            new Grade { GradeId = 3, GradeName = "C" }
        );

        builder.Entity<Student>().HasData(
            new Student { Id = 1, Name = "John", GradeId = 1 },
            new Student { Id = 2, Name = "Jane", GradeId = 2 },
            new Student { Id = 3, Name = "Jim", GradeId = 3 }
        );
        builder.Entity<StudentAddress>().HasData(
                   new StudentAddress { StudentAddressId = 1, Address = "123 Main St", City = "New York", State = "NY", Country = "USA", StudentId = 1 },
                   new StudentAddress { StudentAddressId = 2, Address = "456 Elm St", City = "Los Angeles", State = "CA", Country = "USA", StudentId = 2 },
                   new StudentAddress { StudentAddressId = 3, Address = "789 Oak St", City = "Chicago", State = "IL", Country = "USA", StudentId = 3 }
               );
    }
}
class Program
{
    public static void Main(string[] args)
    {

    }
}