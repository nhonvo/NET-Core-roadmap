using Microsoft.EntityFrameworkCore;
var context = new AppDbContext();

var personData = new List<Person>
{
    new Person
    {
        Name = "A",
    },
    new Person
    {
        Name = "B",
    }
};

await context.Persons.AddRangeAsync(personData);
await context.SaveChangesAsync();

var persons = await context.Persons.ToListAsync();

foreach (var person in persons)
{
    Console.WriteLine($"{person.Id}  {person.Name}");
}
System.Console.WriteLine("----------------------------------------------------------------");

await context.SaveChangesAsync();
var newPersons = await context.Persons.ToListAsync();

foreach (var person in newPersons)
{
    Console.WriteLine($"{person.Id}  {person.Name}");
}
