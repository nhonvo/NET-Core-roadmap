using _5.Querying.Models;
using Microsoft.EntityFrameworkCore;

StudentContext context = new StudentContext();



// LINQ Method syntax
var studentsWithSameName = context.Students
                                  .Where(s => s.FirstName == "truong")
                                  .ToList();
foreach (var s in studentsWithSameName)
{
    Console.WriteLine(s.FirstName);
}
// Include
var studentWithGrade1 = context.Students
                           .Where(s => s.FirstName == "truong")
                           .Include(s => s.Grade)
                           .FirstOrDefault();
if (studentWithGrade1 != null)
{
    Console.WriteLine(studentWithGrade1.FirstName + " " + studentWithGrade1.Grade.GradeName);
}

var studentWithGrade2 = context.Students
                        .Where(s => s.FirstName == "truong")
                        .Include("Grade")
                        .FirstOrDefault();
if (studentWithGrade2 != null)
{
    Console.WriteLine(studentWithGrade2.FirstName + " " + studentWithGrade2.Grade.GradeName);
}


var studentWithGrade = context.Students
                        .FromSql($"Select * from Students where FirstName ='truong'")
                        .Include(s => s.Grade)
                        .FirstOrDefault();
if (studentWithGrade != null)
{
    Console.WriteLine(studentWithGrade.FirstName + " " + studentWithGrade.Grade.GradeName);
}

// multiple include
var studentWithGrade4 = context.Students.Where(s => s.FirstName == "truong")
                        .Include(s => s.Grade)
                        .Include(s => s.Course)
                        .FirstOrDefault();

if (studentWithGrade4 != null)
{
    Console.WriteLine(studentWithGrade4.FirstName + " " + studentWithGrade4.Grade.GradeName);
}
// Then include:  used to include related data for a navigation property that itself has a navigation property. from grade -> students
var student = context.Students.Where(s => s.FirstName == "truong")
                        .Include(s => s.Grade)
                            .ThenInclude(g => g.Students)
                        .FirstOrDefault();

// Projection Query

var stud = context.Students.Where(s => s.FirstName == "truong")
                        .Select(s => new
                        {
                            Student = s,
                            Grade = s.Grade,
                            GradeTeachers = s.Grade.Teachers
                        })
                        .FirstOrDefault();
var stdInsert = new Student()
{
    FirstName = "Bill",
    LastName = "Gates"
};
context.Students.Add(stdInsert);

// or
// context.Add<Student>(std);

context.SaveChanges();

var stdUpdate = context.Students.First<Student>();
stdUpdate.FirstName = "Steve";
context.SaveChanges();

var stdDelete = context.Students.First<Student>();
context.Students.Remove(stdDelete);

// or
// context.Remove<Student>(std);

context.SaveChanges();


