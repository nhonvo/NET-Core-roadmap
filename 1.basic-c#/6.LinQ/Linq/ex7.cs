
var students = new List<Student>
{
    new Student { Name = "Alice", Grade = "A" },
    new Student { Name = "Bob", Grade = "B" },
    new Student { Name = "Charlie", Grade = "A" },
    new Student { Name = "David", Grade = "C" }
};

// group student by Grate

var result = students.GroupBy(x => x.Grade)
    .Select(x => new { x.Key, count = x.Count() });
foreach (var group in result)
{
    Console.WriteLine($"group key {group.Key} count {group.count}");
}
class Student
{
    public string Name { get; set; }
    public string Grade { get; set; }
}

