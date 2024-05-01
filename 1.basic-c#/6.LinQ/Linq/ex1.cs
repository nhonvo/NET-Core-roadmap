var numbers = new List<int> { 5, 1, 5, 1, 3 };

var groupedNumber = numbers.GroupBy(x => x);

foreach (var group in groupedNumber)
{
    Console.WriteLine($"group key {group.Key}");
    foreach (var item in group)
    {
        Console.WriteLine(item);
    }
}