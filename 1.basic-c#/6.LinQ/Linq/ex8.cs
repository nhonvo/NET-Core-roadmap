var students = new List<Student>
{
    new Student { Name = "Alice", Grade = "A" },
    new Student { Name = "Bob", Grade = "B" },
    new Student { Name = "Charlie", Grade = "A" },
    new Student { Name = "David", Grade = "C" }
};
var grouped = students.GroupBy(p => p.Grade);
var names = grouped.SelectMany(
                groupKey => groupKey.Select(
                    item => $"key: {groupKey.Key} {item.Name}"
                )
            );

foreach (var name in names)
{
    Console.WriteLine($"name: {name}");
}

class Student
{
    public string Name { get; set; }
    public string Grade { get; set; }
}
