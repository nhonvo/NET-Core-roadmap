
List<Person> people = new List<Person>()
{
    new Person() { FirstName = "Alice", LastName = "Smith", Age = 25 },
    new Person() { FirstName = "Alice", LastName = "Johnson", Age = 25 },
    new Person() { FirstName = "Bob", LastName = "Jones", Age = 30 },
    new Person() { FirstName = "Bob", LastName = "Smith", Age = 25 }
};

var groups = people.GroupBy(p => new { p.FirstName, p.Age });

foreach (var group in groups)
{
    Console.WriteLine($"First Name: {group.Key.FirstName}, Age: {group.Key.Age}");

    foreach (var person in group)
    {
        Console.WriteLine($"\t{person.FirstName} {person.LastName}");
    }
}

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}


