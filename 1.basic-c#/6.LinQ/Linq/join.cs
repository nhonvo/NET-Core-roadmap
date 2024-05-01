var students = new List<Student>
{
    new Student { Name = "Alice", Grade = "A" },
    new Student { Name = "Bob", Grade = "B" },
    new Student { Name = "Charlie", Grade = "A" },
    new Student { Name = "David", Grade = "C" }
};


var groups = students.GroupBy(p => p.Grade)
                    .Select(group => new
                    {
                        Key = group.Key,
                        Names = string.Join("|", group.Select(x => x.Name))
                    });

foreach (var group in groups)
{
    Console.WriteLine($"Key: {group.Key}, ListName: {group.Names}");
}

class Student
{
    public string Name { get; set; }
    public string Grade { get; set; }
}
