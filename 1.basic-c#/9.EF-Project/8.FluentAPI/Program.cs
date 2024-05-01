
using _8.FluentAPI.BLL;

InsertStudent insertStudent = new InsertStudent();

insertStudent.ViewAll();

//Disconnected entity
// Insert 
var std = new Student() { Name = "Nhon", CurrentGradeId = 1 };
insertStudent.Insert(std);
insertStudent.ViewAll();

// Insert relation data

var stdAddress = new StudentAddress()
{
    City = "SFO",
    State = "CA",
    Country = "USA"
};

var studentAddressRelation = new Student()
{
    Name = "Steve",
    Address = stdAddress
};
insertStudent.Insert(studentAddressRelation);
// Insert Multiple Records
// option 1
var studentList = new List<Student>() {
                new Student(){ Name = "Bill" },
                new Student(){ Name = "Steve" }
            };

using (var context = new SchoolContext())
{
    context.AddRange(studentList);
    context.SaveChanges();
}

// Option 2
var std11 = new Student() { Name = "Bill" };
var std22 = new Student() { Name = "Steve" };
var computer = new Course() { CourseName = "Computer Science" };

var entityList = new List<Object>() {
                std11,
                std22,
                computer
            };
insertStudent.InsertMultiped(entityList);

UpdateStudent updateStudent = new UpdateStudent();

var stud = new Student() { Id = 1, Name = "Bill" };

updateStudent.Update(stud);
// Update Multiple Entities
var modifiedStudent1 = new Student()
{
    Id = 1,
    Name = "Bill"
};

var modifiedStudent2 = new Student()
{
    Id = 3,
    Name = "Steve"
};

var modifiedStudent3 = new Student()
{
    Id = 3,
    Name = "James"
};

IList<Student> modifiedStudents = new List<Student>()
{
    modifiedStudent1,
    modifiedStudent2,
    modifiedStudent3
};
updateStudent.UpdateMultiped(modifiedStudents);

// Change in EntityState ???

DeleteStudent deleteStudent = new DeleteStudent();
var student = new Student()
{
    Id = 1
};
deleteStudent.Remove(student);

IList<Student> students = new List<Student>() {
    new Student(){ Id = 1 },
    new Student(){ Id = 2 },
    new Student(){ Id = 3 },
    new Student(){ Id = 4 }
};

deleteStudent.RemoveMultiple(students);